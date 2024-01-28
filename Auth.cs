using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PASPAS
{
	public partial class Auth : Form
	{
		readonly SqlConnection conn = new SqlConnection("Data Source=YOURSERVERNAME;Initial Catalog=PASPAS;Persist Security Info=true;User ID=sa;Password=1");

		int MoveCP;
		int MapX;
		int MapY;
		public Auth()
		{
			InitializeComponent();
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

		private void Exit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void Minimize_Click(object sender, System.EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private bool ValidEmail(string email)
		{
			string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

			return Regex.IsMatch(email, pattern);
		}

		private void Join_button_Click(object sender, System.EventArgs e)
		{

			string username = Username_textbox.Text;
			string password = Password_textbox.Text;

			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Kullanıcı adı ve şifre alanları boş olamaz!");
				return;
			}
			if (!ValidEmail(username))
			{
				MessageBox.Show("Geçerli bir eposta adresi girin!");
				return;
			}

			try
			{
				conn.Open();

				string query = "SELECT * FROM Users WHERE username = @username";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.Parameters.AddWithValue("@username", username);

				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							string savedPassword = reader["password"].ToString();
							bool isAdmin = (bool)reader["isadmin"];
							if (savedPassword == password)
							{
								Properties.Settings.Default.Username = username;
								Properties.Settings.Default.Password = password;
								Properties.Settings.Default.Save();

								DialogResult goadmin = MessageBox.Show("Admin ekranı için EVET / Ana ekran için HAYIR", "PASPAS - Onay", MessageBoxButtons.YesNo);

								if (isAdmin && goadmin == DialogResult.Yes)
								{
									Admin admin = new Admin();
									admin.Show();
								}
								else
								{
									Main main = new Main();
									main.Show();
								}
							}
						}
					}
					else if (!reader.HasRows)
					{
						reader.Close();
						string insertUserQuery = "INSERT INTO Users (username, password, creationtime) VALUES (@username, @password, GETDATE())";
						SqlCommand insertUserCmd = new SqlCommand(insertUserQuery, conn);
						insertUserCmd.Parameters.AddWithValue("@username", username);
						insertUserCmd.Parameters.AddWithValue("@password", password);
						insertUserCmd.ExecuteNonQuery();
						insertUserCmd.Dispose();

						string insertSettingsQuery = "INSERT INTO UserSettings (username) VALUES (@username)";
						SqlCommand insertSettingsCmd = new SqlCommand(insertSettingsQuery, conn);
						insertSettingsCmd.Parameters.AddWithValue("@username", username);
						insertSettingsCmd.ExecuteNonQuery();
						insertSettingsCmd.Dispose();

						MessageBox.Show("Kayıt olundu.");
					}

					string usersettingsQuery = "SELECT * FROM UserSettings WHERE username = @username";
					SqlCommand usersettingsCmd = new SqlCommand(usersettingsQuery, conn);
					usersettingsCmd.Parameters.AddWithValue("@username", username);
					reader.Close();
					SqlDataReader usersettingsReader = usersettingsCmd.ExecuteReader();
					if (usersettingsReader.HasRows)
					{
						while (usersettingsReader.Read())
						{
							Properties.Settings.Default.Username = (string)usersettingsReader["username"];
							Properties.Settings.Default.Clipboard = (bool)usersettingsReader["Clipboard"];
							Properties.Settings.Default.TemporaryFiles = (bool)usersettingsReader["TemporaryFiles"];
							Properties.Settings.Default.DownloadedInstallations = (bool)usersettingsReader["DownloadedInstallations"];
							Properties.Settings.Default.RecentlyUsed = (bool)usersettingsReader["RecentlyUsed"];

							Properties.Settings.Default.PreviewCache = (bool)usersettingsReader["PreviewCache"];
							Properties.Settings.Default.DNSCache = (bool)usersettingsReader["DNSCache"];
							Properties.Settings.Default.Logs = (bool)usersettingsReader["Logs"];
							Properties.Settings.Default.SystemCache = (bool)usersettingsReader["SystemCache"];
							Properties.Settings.Default.MemoryDumps = (bool)usersettingsReader["MemoryDumps"];
							Properties.Settings.Default.Prefetch = (bool)usersettingsReader["Prefetch"];
							Properties.Settings.Default.FontCache = (bool)usersettingsReader["FontCache"];
							Properties.Settings.Default.DownloadCache = (bool)usersettingsReader["DownloadCache"];
							Properties.Settings.Default.OldWindows = (bool)usersettingsReader["OldWindows"];
							Properties.Settings.Default.DarkMode = (bool)usersettingsReader["DarkMode"];
							Properties.Settings.Default.Save();
						}
					}
					else
					{
						MessageBox.Show("Kullanıcı ayarları bulunamadı!");
					}
					reader.Close();
					usersettingsReader.Close();

					Username_textbox.Text = "";
					Password_textbox.Text = "";
				}
				conn.Close();
			}
			catch (Exception ex)
			{
				Database_error.Visible = true;
				MessageBox.Show(ex.ToString());
			}
		}


		private void Auth_Load(object sender, System.EventArgs e)
		{
			try
			{
				connectionStatus_Tick(null, null);
				connectionStatus.Start();
			}
			catch
			{
				Database_error.Visible = true;
			}
		}

		private void connectionStatus_Tick(object sender, System.EventArgs e)
		{
			try
			{
				using (SqlConnection testconn = new SqlConnection("Data Source=YOURSERVERNAME;Initial Catalog=PASPAS;Persist Security Info=true;User ID=sa;Password=1"))
				{
					testconn.Open();
					if (testconn.State == ConnectionState.Open)
					{
						Label_statuslive.ForeColor = Color.LimeGreen;
						Label_statuslive.Text = "Online (" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + ")";
					}
					else
					{
						Label_statuslive.ForeColor = Color.Red;
						Label_statuslive.Text = "Status (Disconnected)";
					}
				}
			}
			catch
			{
				Label_statuslive.ForeColor = Color.Red;
				Label_statuslive.Text = "Status (Disconnected)";
			}
		}
	}
}