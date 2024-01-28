using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace PASPAS
{
	public partial class Main : Form
	{
		readonly SqlConnection conn = new SqlConnection("Data Source=YOURSERVERNAME;Initial Catalog=PASPAS;Persist Security Info=true;User ID=sa;Password=1");
		int MoveCP;
		int MapX;
		int MapY;
		int FileCount = 0;
		int RejectCount = 0;
		int SelectedThread;

		readonly string SystemDirectory = Path.GetPathRoot(Environment.SystemDirectory);

		Dictionary<string, string> folders = new Dictionary<string, string>();
		List<string> temporaryExtensions = new List<string>();

		public Main()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
		}
		private void PASPAS_Main_Shown(object sender, EventArgs e)
		{
			DarkModeSwitch();
		}

		private void PASPAS_Main_Load(object sender, EventArgs e)
		{
			try
			{
				conn.Open();
				try
				{
					string usersettingsQuery = "SELECT * FROM UserSettings WHERE username = @username";
					SqlCommand usersettingsCmd = new SqlCommand(usersettingsQuery, conn);
					usersettingsCmd.Parameters.AddWithValue("@username", Properties.Settings.Default.Username);
					SqlDataReader usersettingsReader = usersettingsCmd.ExecuteReader();

					if (usersettingsReader.HasRows)
					{
						while (usersettingsReader.Read())
						{
							Properties.Settings.Default.Username = (string)usersettingsReader["username"];
							Account_label.Text = Properties.Settings.Default.Username;
							Properties.Settings.Default.SelectedThread = (int)usersettingsReader["SelectedThread"];
							if (SelectedThread == 0)
							{
							}
							else if (SelectedThread == 1)
							{
								Basic_select.Checked = true;
							}
							else if (SelectedThread == 2)
							{
								Advanced_select.Checked = true;
							}
							else if (SelectedThread == 3)
							{
								Special_select.Checked = true;
								SidePanel.Top = Home_btn.Top;
								SidePanel.Height = Home_btn.Height;
								Home_panel.BringToFront();
							}
							else
							{
								new Error().ShowDialog();
							}
							Properties.Settings.Default.Clipboard = (bool)usersettingsReader["Clipboard"];
							Clipboard_select.Checked = Properties.Settings.Default.Clipboard;
							Properties.Settings.Default.TemporaryFiles = (bool)usersettingsReader["TemporaryFiles"];
							TemporaryFiles_select.Checked = Properties.Settings.Default.TemporaryFiles;
							Properties.Settings.Default.DownloadedInstallations = (bool)usersettingsReader["DownloadedInstallations"];
							DownloadedInstallations_select.Checked = Properties.Settings.Default.DownloadedInstallations;
							Properties.Settings.Default.RecentlyUsed = (bool)usersettingsReader["RecentlyUsed"];
							RecentlyUsed_select.Checked = Properties.Settings.Default.RecentlyUsed;
							Properties.Settings.Default.PreviewCache = (bool)usersettingsReader["PreviewCache"];
							PreviewCache_select.Checked = Properties.Settings.Default.PreviewCache;
							Properties.Settings.Default.DNSCache = (bool)usersettingsReader["DNSCache"];
							DNSCache_select.Checked = Properties.Settings.Default.DNSCache;
							Properties.Settings.Default.Logs = (bool)usersettingsReader["Logs"];
							Logs_select.Checked = Properties.Settings.Default.Logs;
							Properties.Settings.Default.SystemCache = (bool)usersettingsReader["SystemCache"];
							SystemCache_select.Checked = Properties.Settings.Default.SystemCache;
							Properties.Settings.Default.MemoryDumps = (bool)usersettingsReader["MemoryDumps"];
							MemoryDumps_select.Checked = Properties.Settings.Default.MemoryDumps;
							Properties.Settings.Default.Prefetch = (bool)usersettingsReader["Prefetch"];
							Prefetch_select.Checked = Properties.Settings.Default.Prefetch;
							Properties.Settings.Default.FontCache = (bool)usersettingsReader["FontCache"];
							FontCache_select.Checked = Properties.Settings.Default.FontCache;
							Properties.Settings.Default.DownloadCache = (bool)usersettingsReader["DownloadCache"];
							DownloadCache_select.Checked = Properties.Settings.Default.DownloadCache;
							Properties.Settings.Default.OldWindows = (bool)usersettingsReader["OldWindows"];
							OldWindows_select.Checked = Properties.Settings.Default.OldWindows;
							Properties.Settings.Default.DarkMode = (bool)usersettingsReader["DarkMode"];
							DarkModeSwitch();
							Properties.Settings.Default.Save();
						}
					}
					else
					{
						MessageBox.Show("Kullanıcı ayarları bulunamadı!");
					}
					usersettingsReader.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("SYNC ERROR - " + ex.ToString());
				}
				try
				{
					string extensionquery = "SELECT * FROM Extensions;";
					SqlCommand extensioncmd = new SqlCommand(extensionquery, conn);
					SqlDataReader extensionreader = extensioncmd.ExecuteReader();

					if (extensionreader.HasRows)
					{
						while (extensionreader.Read())
						{
							temporaryExtensions.Add(extensionreader["extensions"].ToString());
						}
					}
					else
					{
						MessageBox.Show("Uzantı bulunamadı.\n\n");
						Auth auth = new Auth();
						auth.Show();
						Close();
					}
					extensionreader.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("EXTENSION ERROR - \n\n" + ex.ToString());
					Application.Exit();
				}
				try
				{
					string foldersquery = "SELECT * FROM FolderPaths";
					SqlCommand folderscmd = new SqlCommand(foldersquery, conn);
					SqlDataReader foldersreader = folderscmd.ExecuteReader();

					while (foldersreader.Read())
					{
						string key = foldersreader["key"].ToString();
						string folder = foldersreader["folders"].ToString();
						string optional = foldersreader["folders_optional"].ToString();

						string value = folder;

						if (!string.IsNullOrEmpty(optional))
						{
							value += Environment.UserName + optional;
						}

						folders[key] = value;
					}

					foldersreader.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show("PATH ERROR - \n\n" + ex.ToString());
					Application.Exit();
				}
				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("LOAD ERROR - " + ex.ToString());
			}

		}
		private void Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void Minimize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
		private void ControlPanel_MouseDown(object sender, MouseEventArgs e)
		{
			MoveCP = 1;
			MapX = e.X;
			MapY = e.Y;
		}
		private void ControlPanel_MouseUp(object sender, MouseEventArgs e)
		{
			MoveCP = 0;
		}
		private void ControlPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (MoveCP == 1)
			{
				SetDesktopLocation(MousePosition.X - MapX, MousePosition.Y - MapY);
			}
		}
		private void Home_btn_Click(object sender, EventArgs e)
		{
			SidePanel.Top = Home_btn.Top;
			SidePanel.Height = Home_btn.Height;
			Home_panel.BringToFront();
		}
		private void Options_btn_Click(object sender, EventArgs e)
		{
			SidePanel.Top = Options_btn.Top;
			SidePanel.Height = Options_btn.Height;
			Options_panel.BringToFront();
		}
		private void About_btn_Click(object sender, EventArgs e)
		{
			SidePanel.Top = About_btn.Top;
			SidePanel.Height = About_btn.Height;
			About_panel.BringToFront();
		}
		private void CheckboxPropertySave(CheckBox checkbox, bool status, string property)
		{
			try
			{
				checkbox.Checked = status;
				Properties.Settings.Default[property] = status;
				Properties.Settings.Default.Save();

				if (status)
				{
					checkbox.Text = "✓";
					checkbox.BackColor = Color.Lime;
					checkbox.ForeColor = Color.Black;
				}
				else
				{
					checkbox.Text = "X";
					checkbox.BackColor = Color.Red;
					checkbox.ForeColor = Color.White;
				}
			}
			catch { }
		}

		private void Clipboard_select_CheckedChanged(object sender, EventArgs e)
		{
			bool status = Clipboard_select.Checked;
			CheckboxPropertySave((CheckBox)sender, status, "Clipboard");
		}
		private void TemporaryFiles_select_CheckedChanged(object sender, EventArgs e)
		{
			bool status = TemporaryFiles_select.Checked;
			CheckboxPropertySave((CheckBox)sender, status, "TemporaryFiles");
		}
		private void DownloadedInstallations_select_CheckedChanged(object sender, EventArgs e)
		{
			bool status = DownloadedInstallations_select.Checked;
			CheckboxPropertySave((CheckBox)sender, status, "DownloadedInstallations");
		}
		private void RecentlyUsed_select_CheckedChanged(object sender, EventArgs e)
		{
			bool status = RecentlyUsed_select.Checked;
			CheckboxPropertySave((CheckBox)sender, status, "RecentlyUsed");
		}
		private void PreviewCache_select_CheckedChanged(object sender, EventArgs e)
		{
			bool status = PreviewCache_select.Checked;
			CheckboxPropertySave((CheckBox)sender, status, "PreviewCache");
		}
		private void DNSCache_select_CheckedChanged(object sender, EventArgs e)
		{
			bool status = DNSCache_select.Checked;
			CheckboxPropertySave((CheckBox)sender, status, "DNSCache");
		}
		private void Logs_select_CheckedChanged(object sender, EventArgs e)
		{
			bool status = Logs_select.Checked;
			CheckboxPropertySave((CheckBox)sender, status, "Logs");
		}
		private void SystemCache_select_CheckedChanged(object sender, EventArgs e)
		{
			bool status = SystemCache_select.Checked;
			CheckboxPropertySave((CheckBox)sender, status, "SystemCache");
		}
		private void MemoryDumps_select_CheckedChanged(object sender, EventArgs e)
		{
			bool status = MemoryDumps_select.Checked;
			CheckboxPropertySave((CheckBox)sender, status, "MemoryDumps");
		}
		private void Prefetch_select_CheckedChanged(object sender, EventArgs e)
		{
			bool status = Prefetch_select.Checked;
			CheckboxPropertySave((CheckBox)sender, status, "Prefetch");
		}
		private void FontCache_select_CheckedChanged(object sender, EventArgs e)
		{
			bool status = FontCache_select.Checked;
			CheckboxPropertySave((CheckBox)sender, status, "FontCache");
		}
		private void DownloadCache_select_CheckedChanged(object sender, EventArgs e)
		{
			bool status = DownloadCache_select.Checked;
			CheckboxPropertySave((CheckBox)sender, status, "DownloadCache");
		}
		private void OldWindows_select_CheckedChanged(object sender, EventArgs e)
		{
			bool status = OldWindows_select.Checked;
			CheckboxPropertySave((CheckBox)sender, status, "OldWindows");
		}
		private void Basic_select_CheckedChanged(object sender, EventArgs e)
		{
			SelectedThread = 1;
			Properties.Settings.Default.SelectedThread = SelectedThread;
			Properties.Settings.Default.Save();
			SidePanel.Top = Home_btn.Top;
			SidePanel.Height = Home_btn.Height;
			Home_panel.BringToFront();
		}
		private void Advanced_select_CheckedChanged(object sender, EventArgs e)
		{
			SelectedThread = 2;
			Properties.Settings.Default.SelectedThread = SelectedThread;
			Properties.Settings.Default.Save();
			SidePanel.Top = Home_btn.Top;
			SidePanel.Height = Home_btn.Height;
			Home_panel.BringToFront();
		}
		private void Special_select_CheckedChanged(object sender, EventArgs e)
		{
			SelectedThread = 3;
			Properties.Settings.Default.SelectedThread = SelectedThread;
			Properties.Settings.Default.Save();
			SidePanel.Top = Options_btn.Top;
			SidePanel.Height = Options_btn.Height;
			Options_panel.BringToFront();
		}

		private void ClipboardClear()
		{
			try
			{
				ProcessBox.Items.Add("");
				ProcessBox.Items.Add("--->cmd.exe");
				ProcessStartInfo startinfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = "c/c echo off | clip"
				};
				ProcessBox.Items.Add("- " + startinfo.Arguments);
				ProcessBox.Items.Add("");
				new Process().StartInfo = startinfo;
				new Process().Start();
			}
			catch { RejectCount++; }
		}
		private void DNSCacheRefresh()
		{
			try
			{
				ProcessBox.Items.Add("");
				ProcessBox.Items.Add("--->cmd.exe");
				ProcessStartInfo startinfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = "/c ipconfig /flushdns && ipconfig /release && ipconfig /renew"
				};
				ProcessBox.Items.Add("- " + startinfo.Arguments);
				ProcessBox.Items.Add("");
				new Process().StartInfo = startinfo;
				new Process().Start();
			}
			catch { RejectCount++; }
		}
		private void DeleteFiles(string directory, string extension)
		{
			try
			{
				FileInfo fileinfo;
				foreach (string file in Directory.GetFiles(SystemDirectory + directory))
				{
					fileinfo = new FileInfo(file);
					if (fileinfo.Extension == extension.ToUpper() || fileinfo.Extension == extension.ToLower())
					{
						fileinfo.Delete();
						if (fileinfo.Exists == false)
						{
							FileCount++;
							ProcessBox.Items.Add(FileCount + " | " + fileinfo.ToString());
						}
						else { RejectCount++; }
					}
				}
			}
			catch { }
		}
		private void AnalyzeFiles(string directory, string extension)
		{
			try
			{
				FileInfo fileinfo;
				foreach (string file in Directory.GetFiles(SystemDirectory + directory))
				{
					fileinfo = new FileInfo(file);
					if (fileinfo.Extension == extension.ToUpper() || fileinfo.Extension == extension.ToLower())
					{
						if (fileinfo.Exists)
						{
							FileCount++;
							ProcessBox.Items.Add(FileCount + " | " + fileinfo.ToString());
						}
						else { RejectCount++; }
					}
				}
			}
			catch { }
		}
		private void SingleDirectoryDeletion(string directory)
		{
			try
			{
				if (Directory.Exists(directory))
				{
					Directory.Delete(SystemDirectory + directory);
					if (Directory.Exists(directory) == false)
					{
						FileCount++;
						ProcessBox.Items.Add(FileCount + " | " + directory);
					}
					else { RejectCount++; }
				}
			}
			catch { }
		}
		private void SingleDirectoryAnalyze(string directory)
		{
			if (Directory.Exists(directory))
			{
				FileCount++;
				ProcessBox.Items.Add(FileCount + " | " + directory);
			}
			else { RejectCount++; }
		}
		private void SingleFileDeletion(string directory, string file)
		{
			try
			{
				if (File.Exists(file))
				{
					File.Delete(SystemDirectory + directory + file);
					if (File.Exists(file) == false)
					{
						FileCount++;
						ProcessBox.Items.Add(FileCount + " | " + directory + file);
					}
					else { RejectCount++; }
				}
			}
			catch { }
		}
		private void SingleFileAnalyze(string directory, string file)
		{
			if (File.Exists(file))
			{
				FileCount++;
				ProcessBox.Items.Add(FileCount + " | " + directory + file);
			}
			else { RejectCount++; }
		}
		private void ThreadBasic()
		{
			ClipboardClear();
			foreach (string extensions in temporaryExtensions)
			{
				DeleteFiles(folders["WinTemp"], extensions.ToString());
			}
			foreach (string extensions in temporaryExtensions)
			{
				DeleteFiles(folders["WinTemp2"], extensions.ToString());
			}
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			SingleDirectoryDeletion(folders["DownloadedInstallations"]);
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			DeleteFiles(folders["RecentFiles"], ".lnk");
			DeleteFiles(folders["RecentFiles2"], ".automaticDestinations-ms");
			DeleteFiles(folders["RecentFiles3"], ".customDestinations-ms");
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			DeleteFiles(folders["PreviewCache"], ".db");
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			DNSCacheRefresh();

			SingleDirectoryDeletion(folders["Logs"]);
			SingleDirectoryDeletion(folders["Logs2"]);
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			SingleFileDeletion(folders["UpdateReport"], "ReportingEvents.log");
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			process_img.Visible = false;
			Finish.Visible = true;
			finish_img.Visible = true;
			Start.Enabled = true;
		}
		private void ThreadAdvanced()
		{
			ClipboardClear();
			foreach (string extensions in temporaryExtensions)
			{
				DeleteFiles(folders["WinTemp"], extensions.ToString());
			}
			foreach (string extensions in temporaryExtensions)
			{
				DeleteFiles(folders["WinTemp2"], extensions.ToString());
			}
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			SingleDirectoryDeletion(folders["DownloadedInstallations"]);
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			DeleteFiles(folders["RecentFiles"], ".lnk");
			DeleteFiles(folders["RecentFiles2"], ".automaticDestinations-ms");
			DeleteFiles(folders["RecentFiles3"], ".customDestinations-ms");
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			DeleteFiles(folders["PreviewCache"], ".db");
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			DNSCacheRefresh();

			SingleDirectoryDeletion(folders["Logs"]);
			SingleDirectoryDeletion(folders["Logs2"]);
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			SingleFileDeletion(folders["UpdateReport"], "ReportingEvents.log");
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			DeleteFiles(folders["SystemCache"], ".db");
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			DeleteFiles(folders["LiveKernelReports"], ".dmp");
			DeleteFiles(folders["LiveKernelNDIS"], ".dmp");
			DeleteFiles(folders["CrashDumps"], ".dmp");
			DeleteFiles(folders["MiniDumps"], ".dmp");
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			DeleteFiles(folders["Prefetch"], ".pf");
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			SingleFileDeletion(folders["FontCache"], "FNTCACHE.DAT");
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			SingleDirectoryDeletion(folders["DownloadCache"]);
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();

			process_img.Visible = false;
			Finish.Visible = true;
			finish_img.Visible = true;
			Start.Enabled = true;
		}
		private void ThreadSpecial()
		{
			if (Properties.Settings.Default.Clipboard == true)
			{
				ClipboardClear();
			}
			if (Properties.Settings.Default.TemporaryFiles == true)
			{
				foreach (object extensions in temporaryExtensions)
				{
					DeleteFiles(folders["WinTemp"], extensions.ToString());
				}
				foreach (object extensions in temporaryExtensions)
				{
					DeleteFiles(folders["WinTemp2"], extensions.ToString());
				}

				Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();
			}
			if (Properties.Settings.Default.DownloadedInstallations == true)
			{
				SingleDirectoryDeletion(folders["DownloadedInstallations"]);
				Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();
			}
			if (Properties.Settings.Default.RecentlyUsed == true)
			{
				DeleteFiles(folders["RecentFiles"], ".lnk");
				DeleteFiles(folders["RecentFiles2"], ".automaticDestinations-ms");
				DeleteFiles(folders["RecentFiles3"], ".customDestinations-ms");
				Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();
			}
			if (Properties.Settings.Default.PreviewCache == true)
			{
				DeleteFiles(folders["PreviewCache"], ".db");
				Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();
			}
			if (Properties.Settings.Default.DNSCache == true)
			{
				DNSCacheRefresh();
			}
			if (Properties.Settings.Default.Logs == true)
			{
				SingleDirectoryDeletion(folders["Logs"]);
				SingleDirectoryDeletion(folders["Logs2"]);

				SingleFileDeletion(folders["UpdateReport"], "ReportingEvents.log");
				Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();
			}
			if (Properties.Settings.Default.SystemCache == true)
			{
				DeleteFiles(folders["SystemCache"], ".db");
				Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();
			}
			if (Properties.Settings.Default.MemoryDumps == true)
			{
				DeleteFiles(folders["LiveKernelReports"], ".dmp");
				DeleteFiles(folders["LiveKernelNDIS"], ".dmp");
				DeleteFiles(folders["CrashDumps"], ".dmp");
				DeleteFiles(folders["MiniDumps"], ".dmp");
				Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();
			}
			if (Properties.Settings.Default.Prefetch == true)
			{
				DeleteFiles(folders["Prefetch"], ".pf");
				Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();
			}
			if (Properties.Settings.Default.FontCache == true)
			{
				SingleFileDeletion(folders["FontCache"], "FNTCACHE.DAT");
				Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();
			}
			if (Properties.Settings.Default.DownloadCache == true)
			{
				SingleDirectoryDeletion(folders["DownloadCache"]);
				Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();
			}
			if (Properties.Settings.Default.OldWindows == true)
			{
				SingleDirectoryDeletion(folders["OldWindows"]);
			}
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();
			process_img.Visible = false;
			Finish.Visible = true;
			finish_img.Visible = true;
			Start.Enabled = true;
		}
		private void ThreadAnalysis()
		{
			FileCount = 0;
			RejectCount = 0;
			if (SelectedThread == 1 || SelectedThread == 2 || SelectedThread == 3)
			{
				if (Properties.Settings.Default.TemporaryFiles == true || SelectedThread == 1 || SelectedThread == 2)
				{
					foreach (object extensions in temporaryExtensions)
					{
						AnalyzeFiles(folders["WinTemp"], extensions.ToString());
					}
					foreach (object extensions in temporaryExtensions)
					{
						AnalyzeFiles(folders["WinTemp2"], extensions.ToString());
					}
				}
				if (Properties.Settings.Default.DownloadCache == true || SelectedThread == 1 || SelectedThread == 2)
				{
					SingleDirectoryAnalyze(folders["DownloadCache"]);
				}
				if (Properties.Settings.Default.RecentlyUsed == true || SelectedThread == 1 || SelectedThread == 2)
				{
					AnalyzeFiles(folders["RecentFiles"], ".lnk");
					AnalyzeFiles(folders["RecentFiles2"], ".automaticDestinations-ms");
					AnalyzeFiles(folders["RecentFiles3"], ".customDestinations-ms");
				}
				if (Properties.Settings.Default.PreviewCache == true || SelectedThread == 1 || SelectedThread == 2)
				{
					AnalyzeFiles(folders["PreviewCache"], ".db");
				}
				if (Properties.Settings.Default.Logs == true || SelectedThread == 1 || SelectedThread == 2)
				{
					SingleDirectoryAnalyze(folders["Logs"]);
					SingleDirectoryAnalyze(folders["Logs2"]);
					SingleFileAnalyze(folders["UpdateReport"], "ReportingEvents.log");
				}
				Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();
			}
			if (SelectedThread == 2 || SelectedThread == 3)
			{
				if (Properties.Settings.Default.SystemCache == true || SelectedThread == 2)
				{
					AnalyzeFiles(folders["SystemCache"], ".db");
				}
				if (Properties.Settings.Default.MemoryDumps == true || SelectedThread == 2)
				{
					AnalyzeFiles(folders["LiveKernelReports"], ".dmp");
					AnalyzeFiles(folders["LiveKernelNDIS"], ".dmp");
					AnalyzeFiles(folders["CrashDumps"], ".dmp");
					AnalyzeFiles(folders["MiniDumps"], ".dmp");
				}
				if (Properties.Settings.Default.Prefetch == true || SelectedThread == 2)
				{
					AnalyzeFiles(folders["Prefetch"], ".pf");
				}
				if (Properties.Settings.Default.FontCache == true || SelectedThread == 2)
				{
					SingleFileAnalyze(folders["FontCache"], "FNTCACHE.DAT");
				}
				if (Properties.Settings.Default.DownloadCache == true || SelectedThread == 2)
				{
					SingleDirectoryAnalyze(folders["DownloadCache"]);
				}
			}
			if (SelectedThread == 3)
			{
				if (Properties.Settings.Default.OldWindows == true)
				{
					SingleDirectoryAnalyze(folders["OldWindows"]);
				}
			}
			Process_count.Text = FileCount.ToString() + " / " + RejectCount.ToString();
			process_img.Visible = false;
			Finish.Visible = true;
			finish_img.Visible = true;
			Start.Enabled = true;
			Analysis.Enabled = true;
		}
		private void Start_Click(object sender, EventArgs e)
		{
			FileCount = 0;
			RejectCount = 0;
			if (SelectedThread == 1)
			{
				new Thread(ThreadBasic).Start();
			}
			else if (SelectedThread == 2)
			{
				new Thread(ThreadAdvanced).Start();
			}
			else if (SelectedThread == 3)
			{
				new Thread(ThreadSpecial).Start();
			}
			else
			{
				new Error().ShowDialog();
			}
			ProcessPanel.BringToFront();
			process_img.Visible = true;
			Finish.Visible = false;
			finish_img.Visible = false;
			Start.Enabled = false;
		}
		private void Analysis_Click(object sender, EventArgs e)
		{
			new Thread(ThreadAnalysis).Start();
			ProcessPanel.BringToFront();
			process_img.Visible = true;
			Finish.Visible = false;
			finish_img.Visible = false;
			Start.Enabled = false;
			Analysis.Enabled = false;
		}
		private void Finish_Click(object sender, EventArgs e)
		{
			ProcessBox.Items.Clear();
			Process_count.Text = "0 / 0";
			Home_panel.BringToFront();
		}
		private void DarkModeSwitch()
		{
			if (Properties.Settings.Default.DarkMode)
			{
				foreach (Control c in Controls)
				{
					if (c is Panel && (c.Name != "ControlPanel" && c.Name != "SidePanel" && c.Name != "LogoPanel" && c.Name != "ProcessTitlePanel" && c.Name != "DarkModeButton"))
					{
						c.BackColor = ColorTranslator.FromHtml("#444449");
						c.ForeColor = Color.White;
						BackColor = c.BackColor;
					}
				}
			}
			else if (!Properties.Settings.Default.DarkMode)
			{
				foreach (Control c in Controls)
				{
					if (c is Panel && (c.Name != "ControlPanel" && c.Name != "SidePanel" && c.Name != "LogoPanel" && c.Name != "ProcessTitlePanel" && c.Name != "DarkModeButton"))
					{
						c.BackColor = Color.WhiteSmoke;
						c.ForeColor = Color.Black;
						BackColor = c.BackColor;
					}
				}
			}
		}
		private void DarkModeButton_Click(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.DarkMode)
			{
				new Thread(DarkModeSwitch).Start();
				Properties.Settings.Default.DarkMode = false;
				Properties.Settings.Default.Save();
			}
			else if (!Properties.Settings.Default.DarkMode)
			{
				new Thread(DarkModeSwitch).Start();
				Properties.Settings.Default.DarkMode = true;
				Properties.Settings.Default.Save();
			}
		}
		private void ResetButton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.Reset();
			foreach (Control control in Options_panel.Controls)
			{
				if (control is CheckBox checkbox)
				{
					checkbox.Checked = false;
				}
			}
			DarkModeSwitch();
		}
		private void Github_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://github.com/berkaygediz");
		}

		private void Sync_button_Click(object sender, EventArgs e)
		{
			try
			{
				conn.Open();
				string updatesql = @"
					UPDATE UserSettings
					SET SelectedThread = @SelectedThread,
						Clipboard = @Clipboard,
						TemporaryFiles = @TemporaryFiles,
						DownloadedInstallations = @DownloadedInstallations,
						RecentlyUsed = @RecentlyUsed,
						PreviewCache = @PreviewCache,
						DNSCache = @DNSCache,
						Logs = @Logs,
						SystemCache = @SystemCache,
						MemoryDumps = @MemoryDumps,
						Prefetch = @Prefetch,
						FontCache = @FontCache,
						DownloadCache = @DownloadCache,
						OldWindows = @OldWindows,
						DarkMode = @DarkMode
					WHERE username = @username
				";

				SqlCommand updatecmd = new SqlCommand(updatesql, conn);
				updatecmd.Parameters.AddWithValue("@username", Properties.Settings.Default.Username);
				updatecmd.Parameters.AddWithValue("@SelectedThread", Properties.Settings.Default.SelectedThread);
				updatecmd.Parameters.AddWithValue("@Clipboard", Properties.Settings.Default.Clipboard);
				updatecmd.Parameters.AddWithValue("@TemporaryFiles", Properties.Settings.Default.TemporaryFiles);
				updatecmd.Parameters.AddWithValue("@DownloadedInstallations", Properties.Settings.Default.DownloadedInstallations);
				updatecmd.Parameters.AddWithValue("@RecentlyUsed", Properties.Settings.Default.RecentlyUsed);
				updatecmd.Parameters.AddWithValue("@PreviewCache", Properties.Settings.Default.PreviewCache);
				updatecmd.Parameters.AddWithValue("@DNSCache", Properties.Settings.Default.DNSCache);
				updatecmd.Parameters.AddWithValue("@Logs", Properties.Settings.Default.Logs);
				updatecmd.Parameters.AddWithValue("@SystemCache", Properties.Settings.Default.SystemCache);
				updatecmd.Parameters.AddWithValue("@MemoryDumps", Properties.Settings.Default.MemoryDumps);
				updatecmd.Parameters.AddWithValue("@Prefetch", Properties.Settings.Default.Prefetch);
				updatecmd.Parameters.AddWithValue("@FontCache", Properties.Settings.Default.FontCache);
				updatecmd.Parameters.AddWithValue("@DownloadCache", Properties.Settings.Default.DownloadCache);
				updatecmd.Parameters.AddWithValue("@OldWindows", Properties.Settings.Default.OldWindows);
				updatecmd.Parameters.AddWithValue("@DarkMode", Properties.Settings.Default.DarkMode);

				int islemsayisi = updatecmd.ExecuteNonQuery();

				if (islemsayisi > 0)
				{
					MessageBox.Show("Senkronize edildi!");
				}
				else
				{
					MessageBox.Show("Senkronize başarısız!");
				}

				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("SYNC ERROR - " + ex.ToString());
			}
		}

		private void Logout_button_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.Reset();
			Properties.Settings.Default.Save();
			Auth auth = new Auth();
			auth.Show();
			Close();

		}
	}
}