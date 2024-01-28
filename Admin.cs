using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace PASPAS
{
	public partial class Admin : Form
	{
		int MoveCP;
		int MapX;
		int MapY;
		readonly SqlConnection conn = new SqlConnection("Data Source=YOURSERVERNAME;Initial Catalog=PASPAS;Persist Security Info=true;User ID=sa;Password=1");
		public Admin()
		{
			InitializeComponent();
			CheckForIllegalCrossThreadCalls = false;
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
		private void Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Minimize_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		void Guncelle()
		{
			DataTable dt_user = new DataTable();
			SqlDataAdapter da_user = new SqlDataAdapter("SELECT * FROM Users", conn);
			da_user.Fill(dt_user);
			AllUsers_DataGrid.DataSource = dt_user;

			DataTable dt_settings = new DataTable();
			SqlDataAdapter da_settings = new SqlDataAdapter("SELECT * FROM UserSettings", conn);
			da_settings.Fill(dt_settings);
			UserSettings_DataGrid.DataSource = dt_settings;
		}

		private void Admin_Load(object sender, EventArgs e)
		{
			try
			{
				conn.Open();

				new Thread(Guncelle).Start();

				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Veritabanından kullanıcılar okunamadı.\n\n" + ex.ToString());
			}
		}

		private void Refresh_button_Click(object sender, EventArgs e)
		{
			try
			{
				conn.Open();

				Guncelle();

				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Güncelleme hatası!\n\n" + ex.ToString());
			}
		}


		private void Getir_button_Click(object sender, EventArgs e)
		{
			conn.Open();
			SqlCommand getuserdetails = new SqlCommand("SELECT * FROM Users WHERE id=@id", conn);
			getuserdetails.Parameters.AddWithValue("id", id_textbox.Text);
			SqlDataReader getuserdetails_dr = getuserdetails.ExecuteReader();
			if (getuserdetails_dr.HasRows)
			{
				while (getuserdetails_dr.Read())
				{
					user_textbox.Text = (string)getuserdetails_dr["username"];
					password_textbox.Text = (string)getuserdetails_dr["password"];
				}
			}
			getuserdetails_dr.Close();

			SqlCommand getusersettings = new SqlCommand("SELECT * FROM UserSettings WHERE username=@username", conn);
			getusersettings.Parameters.AddWithValue("username", user_textbox.Text);
			SqlDataReader getusersettings_dr = getusersettings.ExecuteReader();
			if (getusersettings_dr.HasRows)
			{
				while (getusersettings_dr.Read())
				{
					Clipboard_select.Checked = (bool)getusersettings_dr["Clipboard"];
					TemporaryFiles_select.Checked = (bool)getusersettings_dr["TemporaryFiles"];
					DownloadedInstallations_select.Checked = (bool)getusersettings_dr["DownloadedInstallations"];
					RecentlyUsed_select.Checked = (bool)getusersettings_dr["RecentlyUsed"];
					PreviewCache_select.Checked = (bool)getusersettings_dr["PreviewCache"];
					DNSCache_select.Checked = (bool)getusersettings_dr["DNSCache"];

					Logs_select.Checked = (bool)getusersettings_dr["Logs"];
					SystemCache_select.Checked = (bool)getusersettings_dr["SystemCache"];
					MemoryDumps_select.Checked = (bool)getusersettings_dr["MemoryDumps"];
					Prefetch_select.Checked = (bool)getusersettings_dr["Prefetch"];
					FontCache_select.Checked = (bool)getusersettings_dr["FontCache"];
					DownloadCache_select.Checked = (bool)getusersettings_dr["OldWindows"];

					OldWindows_select.Checked = (bool)getusersettings_dr["Clipboard"];
				}
			}
			getusersettings_dr.Close();
			conn.Close();
		}

		private void UpdateUser_button_Click(object sender, EventArgs e)
		{
			try
			{
				if (!string.IsNullOrEmpty(password_textbox.Text))
				{
					conn.Open();
					string updatesettings_sql = @"
					UPDATE UserSettings
					SET Clipboard = @Clipboard,
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
						OldWindows = @OldWindows
					WHERE username = @username
				";

					SqlCommand updatesettings_cmd = new SqlCommand(updatesettings_sql, conn);
					updatesettings_cmd.Parameters.AddWithValue("@username", user_textbox.Text);

					updatesettings_cmd.Parameters.AddWithValue("@Clipboard", Clipboard_select.Checked);
					updatesettings_cmd.Parameters.AddWithValue("@TemporaryFiles", TemporaryFiles_select.Checked);
					updatesettings_cmd.Parameters.AddWithValue("@DownloadedInstallations", DownloadCache_select.Checked);
					updatesettings_cmd.Parameters.AddWithValue("@RecentlyUsed", RecentlyUsed_select.Checked);
					updatesettings_cmd.Parameters.AddWithValue("@PreviewCache", PreviewCache_select.Checked);
					updatesettings_cmd.Parameters.AddWithValue("@DNSCache", DNSCache_select.Checked);
					updatesettings_cmd.Parameters.AddWithValue("@Logs", Logs_select.Checked);
					updatesettings_cmd.Parameters.AddWithValue("@SystemCache", SystemCache_select.Checked);
					updatesettings_cmd.Parameters.AddWithValue("@MemoryDumps", MemoryDumps_select.Checked);
					updatesettings_cmd.Parameters.AddWithValue("@Prefetch", Prefetch_select.Checked);
					updatesettings_cmd.Parameters.AddWithValue("@FontCache", FontCache_select.Checked);
					updatesettings_cmd.Parameters.AddWithValue("@DownloadCache", DownloadCache_select.Checked);
					updatesettings_cmd.Parameters.AddWithValue("@OldWindows", OldWindows_select.Checked);

					int updatesettings_islemsayisi = updatesettings_cmd.ExecuteNonQuery();

					if (updatesettings_islemsayisi > 0)
					{
						MessageBox.Show(user_textbox.Text + " detayları güncellendi!");
					}
					else
					{
						MessageBox.Show("Güncelleme başarısız!");
					}

					string updateuser_sql = @"
					UPDATE Users
					SET password = @password
					WHERE username = @username";

					SqlCommand updateuser_cmd = new SqlCommand(updateuser_sql, conn);
					updateuser_cmd.Parameters.AddWithValue("@username", user_textbox.Text);
					updateuser_cmd.Parameters.AddWithValue("@password", password_textbox.Text);

					int islemsayisi = updateuser_cmd.ExecuteNonQuery();

					if (islemsayisi > 0)
					{
						MessageBox.Show(user_textbox.Text + " - Şifre detayları güncellendi!");
					}
					else
					{
						MessageBox.Show("Güncelleme başarısız!");
					}

					Guncelle();

					conn.Close();
				}
				else
				{
					MessageBox.Show("Bilgiler boş bırakılamaz!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("SYNC ERROR - " + ex.ToString());
			}
		}

		private void DeleteUser_button_Click(object sender, EventArgs e)
		{
			try
			{
				conn.Open();
				string deleteusersql = @"DELETE FROM Users WHERE username = @username";
				SqlCommand deleteusercmd = new SqlCommand(deleteusersql, conn);
				deleteusercmd.Parameters.AddWithValue("@username", user_textbox.Text);

				int islemsayisi_users = deleteusercmd.ExecuteNonQuery();

				if (islemsayisi_users > 0)
				{
				}
				else
				{
					MessageBox.Show("Users tablosundan silinemedi!");
				}

				string deletesettings_sql = @"DELETE FROM UserSettings WHERE username = @username";
				SqlCommand deletesettings_cmd = new SqlCommand(deletesettings_sql, conn);
				deletesettings_cmd.Parameters.AddWithValue("@username", user_textbox.Text);

				int islemsayisi_usersettings = deletesettings_cmd.ExecuteNonQuery();

				if (islemsayisi_usersettings > 0)
				{
				}
				else
				{
					MessageBox.Show("UserSettings tablosundan silinemedi!");
				}

				new Thread(Guncelle).Start();

				id_textbox.Text = "";
				user_textbox.Text = "";
				password_textbox.Text = "";

				conn.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("DELETE ERROR - " + ex.ToString());
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
