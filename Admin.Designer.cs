namespace PASPAS
{
	partial class Admin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
			this.Label_join = new System.Windows.Forms.Label();
			this.Title = new System.Windows.Forms.Label();
			this.LogoPanel = new System.Windows.Forms.Panel();
			this.Logo = new System.Windows.Forms.PictureBox();
			this.ControlPanel = new System.Windows.Forms.Panel();
			this.Exit = new System.Windows.Forms.Button();
			this.Minimize = new System.Windows.Forms.Button();
			this.OldWindows_select = new System.Windows.Forms.CheckBox();
			this.OldWindows_title = new System.Windows.Forms.Label();
			this.DownloadCache_select = new System.Windows.Forms.CheckBox();
			this.DownloadCache_title = new System.Windows.Forms.Label();
			this.FontCache_select = new System.Windows.Forms.CheckBox();
			this.FontCache_title = new System.Windows.Forms.Label();
			this.Prefetch_select = new System.Windows.Forms.CheckBox();
			this.Prefetch_title = new System.Windows.Forms.Label();
			this.MemoryDumps_select = new System.Windows.Forms.CheckBox();
			this.MemoryDumps_title = new System.Windows.Forms.Label();
			this.SystemCache_select = new System.Windows.Forms.CheckBox();
			this.SystemCache_title = new System.Windows.Forms.Label();
			this.Logs_select = new System.Windows.Forms.CheckBox();
			this.Logs_title = new System.Windows.Forms.Label();
			this.DNSCache_select = new System.Windows.Forms.CheckBox();
			this.DNSCache_title = new System.Windows.Forms.Label();
			this.PreviewCache_select = new System.Windows.Forms.CheckBox();
			this.PreviewCache_title = new System.Windows.Forms.Label();
			this.RecentlyUsed_select = new System.Windows.Forms.CheckBox();
			this.RecentlyUsed_title = new System.Windows.Forms.Label();
			this.DownloadedInstallations_select = new System.Windows.Forms.CheckBox();
			this.DownloadedInstallations_title = new System.Windows.Forms.Label();
			this.TemporaryFiles_select = new System.Windows.Forms.CheckBox();
			this.TemporaryFiles_title = new System.Windows.Forms.Label();
			this.Clipboard_select = new System.Windows.Forms.CheckBox();
			this.Clipboard_title = new System.Windows.Forms.Label();
			this.id_textbox = new System.Windows.Forms.TextBox();
			this.user_textbox = new System.Windows.Forms.TextBox();
			this.password_textbox = new System.Windows.Forms.TextBox();
			this.id_lbl = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Getir_button = new System.Windows.Forms.Button();
			this.DeleteUser_button = new System.Windows.Forms.Button();
			this.UpdateUser_button = new System.Windows.Forms.Button();
			this.AllUsers_DataGrid = new System.Windows.Forms.DataGridView();
			this.Refresh_button = new System.Windows.Forms.Button();
			this.dtuser_lbl = new System.Windows.Forms.Label();
			this.UserSettings_DataGrid = new System.Windows.Forms.DataGridView();
			this.dtsettings_lbl = new System.Windows.Forms.Label();
			this.Logout_button = new System.Windows.Forms.Button();
			this.LogoPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AllUsers_DataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UserSettings_DataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// Label_join
			// 
			this.Label_join.AutoSize = true;
			this.Label_join.BackColor = System.Drawing.Color.Red;
			this.Label_join.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Label_join.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.Label_join.Location = new System.Drawing.Point(168, 21);
			this.Label_join.Name = "Label_join";
			this.Label_join.Size = new System.Drawing.Size(176, 47);
			this.Label_join.TabIndex = 49;
			this.Label_join.Text = "MANAGE";
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Title.Location = new System.Drawing.Point(18, 119);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(102, 32);
			this.Title.TabIndex = 11;
			this.Title.Text = "PASPAS";
			// 
			// LogoPanel
			// 
			this.LogoPanel.BackColor = System.Drawing.Color.Yellow;
			this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.LogoPanel.Controls.Add(this.Logo);
			this.LogoPanel.Controls.Add(this.Title);
			this.LogoPanel.Location = new System.Drawing.Point(10, 0);
			this.LogoPanel.Name = "LogoPanel";
			this.LogoPanel.Size = new System.Drawing.Size(140, 150);
			this.LogoPanel.TabIndex = 48;
			// 
			// Logo
			// 
			this.Logo.BackColor = System.Drawing.Color.Transparent;
			this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Logo.Image = global::PASPAS.Properties.Resources.paspas;
			this.Logo.Location = new System.Drawing.Point(10, 6);
			this.Logo.Name = "Logo";
			this.Logo.Size = new System.Drawing.Size(120, 120);
			this.Logo.TabIndex = 5;
			this.Logo.TabStop = false;
			// 
			// ControlPanel
			// 
			this.ControlPanel.BackColor = System.Drawing.Color.Yellow;
			this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ControlPanel.Location = new System.Drawing.Point(1, 0);
			this.ControlPanel.Name = "ControlPanel";
			this.ControlPanel.Size = new System.Drawing.Size(894, 15);
			this.ControlPanel.TabIndex = 43;
			this.ControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
			this.ControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseMove);
			this.ControlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseUp);
			// 
			// Exit
			// 
			this.Exit.BackColor = System.Drawing.Color.Red;
			this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Exit.Location = new System.Drawing.Point(850, 21);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(38, 38);
			this.Exit.TabIndex = 27;
			this.Exit.Text = "X";
			this.Exit.UseVisualStyleBackColor = false;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// Minimize
			// 
			this.Minimize.BackColor = System.Drawing.Color.Gold;
			this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Minimize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Minimize.Location = new System.Drawing.Point(806, 21);
			this.Minimize.Name = "Minimize";
			this.Minimize.Size = new System.Drawing.Size(38, 38);
			this.Minimize.TabIndex = 28;
			this.Minimize.Text = "—";
			this.Minimize.UseVisualStyleBackColor = false;
			this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
			// 
			// OldWindows_select
			// 
			this.OldWindows_select.Appearance = System.Windows.Forms.Appearance.Button;
			this.OldWindows_select.AutoSize = true;
			this.OldWindows_select.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.OldWindows_select.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.OldWindows_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.OldWindows_select.ForeColor = System.Drawing.Color.White;
			this.OldWindows_select.Location = new System.Drawing.Point(226, 729);
			this.OldWindows_select.Name = "OldWindows_select";
			this.OldWindows_select.Size = new System.Drawing.Size(24, 31);
			this.OldWindows_select.TabIndex = 75;
			this.OldWindows_select.Text = " ";
			this.OldWindows_select.UseVisualStyleBackColor = false;
			// 
			// OldWindows_title
			// 
			this.OldWindows_title.AutoSize = true;
			this.OldWindows_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.OldWindows_title.Location = new System.Drawing.Point(222, 705);
			this.OldWindows_title.Name = "OldWindows_title";
			this.OldWindows_title.Size = new System.Drawing.Size(133, 21);
			this.OldWindows_title.TabIndex = 74;
			this.OldWindows_title.Text = "OLD WINDOWS:";
			// 
			// DownloadCache_select
			// 
			this.DownloadCache_select.Appearance = System.Windows.Forms.Appearance.Button;
			this.DownloadCache_select.AutoSize = true;
			this.DownloadCache_select.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.DownloadCache_select.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.DownloadCache_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.DownloadCache_select.ForeColor = System.Drawing.Color.White;
			this.DownloadCache_select.Location = new System.Drawing.Point(226, 660);
			this.DownloadCache_select.Name = "DownloadCache_select";
			this.DownloadCache_select.Size = new System.Drawing.Size(24, 31);
			this.DownloadCache_select.TabIndex = 73;
			this.DownloadCache_select.Text = " ";
			this.DownloadCache_select.UseVisualStyleBackColor = false;
			// 
			// DownloadCache_title
			// 
			this.DownloadCache_title.AutoSize = true;
			this.DownloadCache_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.DownloadCache_title.Location = new System.Drawing.Point(222, 636);
			this.DownloadCache_title.Name = "DownloadCache_title";
			this.DownloadCache_title.Size = new System.Drawing.Size(166, 21);
			this.DownloadCache_title.TabIndex = 72;
			this.DownloadCache_title.Text = "DOWNLOAD CACHE:";
			// 
			// FontCache_select
			// 
			this.FontCache_select.Appearance = System.Windows.Forms.Appearance.Button;
			this.FontCache_select.AutoSize = true;
			this.FontCache_select.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.FontCache_select.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.FontCache_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FontCache_select.ForeColor = System.Drawing.Color.White;
			this.FontCache_select.Location = new System.Drawing.Point(226, 593);
			this.FontCache_select.Name = "FontCache_select";
			this.FontCache_select.Size = new System.Drawing.Size(24, 31);
			this.FontCache_select.TabIndex = 71;
			this.FontCache_select.Text = " ";
			this.FontCache_select.UseVisualStyleBackColor = false;
			// 
			// FontCache_title
			// 
			this.FontCache_title.AutoSize = true;
			this.FontCache_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FontCache_title.Location = new System.Drawing.Point(222, 569);
			this.FontCache_title.Name = "FontCache_title";
			this.FontCache_title.Size = new System.Drawing.Size(112, 21);
			this.FontCache_title.TabIndex = 70;
			this.FontCache_title.Text = "FONT CACHE:";
			// 
			// Prefetch_select
			// 
			this.Prefetch_select.Appearance = System.Windows.Forms.Appearance.Button;
			this.Prefetch_select.AutoSize = true;
			this.Prefetch_select.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.Prefetch_select.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Prefetch_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Prefetch_select.ForeColor = System.Drawing.Color.White;
			this.Prefetch_select.Location = new System.Drawing.Point(226, 526);
			this.Prefetch_select.Name = "Prefetch_select";
			this.Prefetch_select.Size = new System.Drawing.Size(24, 31);
			this.Prefetch_select.TabIndex = 69;
			this.Prefetch_select.Text = " ";
			this.Prefetch_select.UseVisualStyleBackColor = false;
			// 
			// Prefetch_title
			// 
			this.Prefetch_title.AutoSize = true;
			this.Prefetch_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Prefetch_title.Location = new System.Drawing.Point(222, 502);
			this.Prefetch_title.Name = "Prefetch_title";
			this.Prefetch_title.Size = new System.Drawing.Size(90, 21);
			this.Prefetch_title.TabIndex = 68;
			this.Prefetch_title.Text = "PREFETCH:";
			// 
			// MemoryDumps_select
			// 
			this.MemoryDumps_select.Appearance = System.Windows.Forms.Appearance.Button;
			this.MemoryDumps_select.AutoSize = true;
			this.MemoryDumps_select.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.MemoryDumps_select.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.MemoryDumps_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.MemoryDumps_select.ForeColor = System.Drawing.Color.White;
			this.MemoryDumps_select.Location = new System.Drawing.Point(226, 454);
			this.MemoryDumps_select.Name = "MemoryDumps_select";
			this.MemoryDumps_select.Size = new System.Drawing.Size(24, 31);
			this.MemoryDumps_select.TabIndex = 67;
			this.MemoryDumps_select.Text = " ";
			this.MemoryDumps_select.UseVisualStyleBackColor = false;
			// 
			// MemoryDumps_title
			// 
			this.MemoryDumps_title.AutoSize = true;
			this.MemoryDumps_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.MemoryDumps_title.Location = new System.Drawing.Point(222, 430);
			this.MemoryDumps_title.Name = "MemoryDumps_title";
			this.MemoryDumps_title.Size = new System.Drawing.Size(147, 21);
			this.MemoryDumps_title.TabIndex = 66;
			this.MemoryDumps_title.Text = "MEMORY DUMPS:";
			// 
			// SystemCache_select
			// 
			this.SystemCache_select.Appearance = System.Windows.Forms.Appearance.Button;
			this.SystemCache_select.AutoSize = true;
			this.SystemCache_select.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.SystemCache_select.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.SystemCache_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.SystemCache_select.ForeColor = System.Drawing.Color.White;
			this.SystemCache_select.Location = new System.Drawing.Point(226, 386);
			this.SystemCache_select.Name = "SystemCache_select";
			this.SystemCache_select.Size = new System.Drawing.Size(24, 31);
			this.SystemCache_select.TabIndex = 65;
			this.SystemCache_select.Text = " ";
			this.SystemCache_select.UseVisualStyleBackColor = false;
			// 
			// SystemCache_title
			// 
			this.SystemCache_title.AutoSize = true;
			this.SystemCache_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.SystemCache_title.Location = new System.Drawing.Point(222, 362);
			this.SystemCache_title.Name = "SystemCache_title";
			this.SystemCache_title.Size = new System.Drawing.Size(131, 21);
			this.SystemCache_title.TabIndex = 64;
			this.SystemCache_title.Text = "SYSTEM CACHE:";
			// 
			// Logs_select
			// 
			this.Logs_select.Appearance = System.Windows.Forms.Appearance.Button;
			this.Logs_select.AutoSize = true;
			this.Logs_select.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.Logs_select.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Logs_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Logs_select.ForeColor = System.Drawing.Color.White;
			this.Logs_select.Location = new System.Drawing.Point(30, 787);
			this.Logs_select.Name = "Logs_select";
			this.Logs_select.Size = new System.Drawing.Size(24, 31);
			this.Logs_select.TabIndex = 63;
			this.Logs_select.Text = " ";
			this.Logs_select.UseVisualStyleBackColor = false;
			// 
			// Logs_title
			// 
			this.Logs_title.AutoSize = true;
			this.Logs_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Logs_title.Location = new System.Drawing.Point(26, 763);
			this.Logs_title.Name = "Logs_title";
			this.Logs_title.Size = new System.Drawing.Size(54, 21);
			this.Logs_title.TabIndex = 62;
			this.Logs_title.Text = "LOGS:";
			// 
			// DNSCache_select
			// 
			this.DNSCache_select.Appearance = System.Windows.Forms.Appearance.Button;
			this.DNSCache_select.AutoSize = true;
			this.DNSCache_select.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.DNSCache_select.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.DNSCache_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.DNSCache_select.ForeColor = System.Drawing.Color.White;
			this.DNSCache_select.Location = new System.Drawing.Point(30, 718);
			this.DNSCache_select.Name = "DNSCache_select";
			this.DNSCache_select.Size = new System.Drawing.Size(24, 31);
			this.DNSCache_select.TabIndex = 61;
			this.DNSCache_select.Text = " ";
			this.DNSCache_select.UseVisualStyleBackColor = false;
			// 
			// DNSCache_title
			// 
			this.DNSCache_title.AutoSize = true;
			this.DNSCache_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.DNSCache_title.Location = new System.Drawing.Point(26, 694);
			this.DNSCache_title.Name = "DNSCache_title";
			this.DNSCache_title.Size = new System.Drawing.Size(104, 21);
			this.DNSCache_title.TabIndex = 60;
			this.DNSCache_title.Text = "DNS CACHE:";
			// 
			// PreviewCache_select
			// 
			this.PreviewCache_select.Appearance = System.Windows.Forms.Appearance.Button;
			this.PreviewCache_select.AutoSize = true;
			this.PreviewCache_select.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.PreviewCache_select.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.PreviewCache_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.PreviewCache_select.ForeColor = System.Drawing.Color.White;
			this.PreviewCache_select.Location = new System.Drawing.Point(30, 651);
			this.PreviewCache_select.Name = "PreviewCache_select";
			this.PreviewCache_select.Size = new System.Drawing.Size(24, 31);
			this.PreviewCache_select.TabIndex = 59;
			this.PreviewCache_select.Text = " ";
			this.PreviewCache_select.UseVisualStyleBackColor = false;
			// 
			// PreviewCache_title
			// 
			this.PreviewCache_title.AutoSize = true;
			this.PreviewCache_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.PreviewCache_title.Location = new System.Drawing.Point(26, 627);
			this.PreviewCache_title.Name = "PreviewCache_title";
			this.PreviewCache_title.Size = new System.Drawing.Size(140, 21);
			this.PreviewCache_title.TabIndex = 58;
			this.PreviewCache_title.Text = "PREVIEW CACHE:";
			// 
			// RecentlyUsed_select
			// 
			this.RecentlyUsed_select.Appearance = System.Windows.Forms.Appearance.Button;
			this.RecentlyUsed_select.AutoSize = true;
			this.RecentlyUsed_select.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.RecentlyUsed_select.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.RecentlyUsed_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.RecentlyUsed_select.ForeColor = System.Drawing.Color.White;
			this.RecentlyUsed_select.Location = new System.Drawing.Point(30, 587);
			this.RecentlyUsed_select.Name = "RecentlyUsed_select";
			this.RecentlyUsed_select.Size = new System.Drawing.Size(24, 31);
			this.RecentlyUsed_select.TabIndex = 57;
			this.RecentlyUsed_select.Text = " ";
			this.RecentlyUsed_select.UseVisualStyleBackColor = false;
			// 
			// RecentlyUsed_title
			// 
			this.RecentlyUsed_title.AutoSize = true;
			this.RecentlyUsed_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.RecentlyUsed_title.Location = new System.Drawing.Point(26, 563);
			this.RecentlyUsed_title.Name = "RecentlyUsed_title";
			this.RecentlyUsed_title.Size = new System.Drawing.Size(137, 21);
			this.RecentlyUsed_title.TabIndex = 56;
			this.RecentlyUsed_title.Text = "RECENTLY USED:";
			// 
			// DownloadedInstallations_select
			// 
			this.DownloadedInstallations_select.Appearance = System.Windows.Forms.Appearance.Button;
			this.DownloadedInstallations_select.AutoSize = true;
			this.DownloadedInstallations_select.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.DownloadedInstallations_select.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.DownloadedInstallations_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.DownloadedInstallations_select.ForeColor = System.Drawing.Color.White;
			this.DownloadedInstallations_select.Location = new System.Drawing.Point(30, 520);
			this.DownloadedInstallations_select.Name = "DownloadedInstallations_select";
			this.DownloadedInstallations_select.Size = new System.Drawing.Size(24, 31);
			this.DownloadedInstallations_select.TabIndex = 55;
			this.DownloadedInstallations_select.Text = " ";
			this.DownloadedInstallations_select.UseVisualStyleBackColor = false;
			// 
			// DownloadedInstallations_title
			// 
			this.DownloadedInstallations_title.AutoSize = true;
			this.DownloadedInstallations_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.DownloadedInstallations_title.Location = new System.Drawing.Point(26, 496);
			this.DownloadedInstallations_title.Name = "DownloadedInstallations_title";
			this.DownloadedInstallations_title.Size = new System.Drawing.Size(168, 21);
			this.DownloadedInstallations_title.TabIndex = 54;
			this.DownloadedInstallations_title.Text = "INSTALLATION FILES:";
			// 
			// TemporaryFiles_select
			// 
			this.TemporaryFiles_select.Appearance = System.Windows.Forms.Appearance.Button;
			this.TemporaryFiles_select.AutoSize = true;
			this.TemporaryFiles_select.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.TemporaryFiles_select.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.TemporaryFiles_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TemporaryFiles_select.ForeColor = System.Drawing.Color.White;
			this.TemporaryFiles_select.Location = new System.Drawing.Point(30, 453);
			this.TemporaryFiles_select.Name = "TemporaryFiles_select";
			this.TemporaryFiles_select.Size = new System.Drawing.Size(24, 31);
			this.TemporaryFiles_select.TabIndex = 53;
			this.TemporaryFiles_select.Text = " ";
			this.TemporaryFiles_select.UseVisualStyleBackColor = false;
			// 
			// TemporaryFiles_title
			// 
			this.TemporaryFiles_title.AutoSize = true;
			this.TemporaryFiles_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.TemporaryFiles_title.Location = new System.Drawing.Point(26, 429);
			this.TemporaryFiles_title.Name = "TemporaryFiles_title";
			this.TemporaryFiles_title.Size = new System.Drawing.Size(153, 21);
			this.TemporaryFiles_title.TabIndex = 52;
			this.TemporaryFiles_title.Text = "TEMPORARY FILES:";
			// 
			// Clipboard_select
			// 
			this.Clipboard_select.Appearance = System.Windows.Forms.Appearance.Button;
			this.Clipboard_select.AutoSize = true;
			this.Clipboard_select.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.Clipboard_select.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Clipboard_select.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Clipboard_select.ForeColor = System.Drawing.Color.White;
			this.Clipboard_select.Location = new System.Drawing.Point(30, 386);
			this.Clipboard_select.Name = "Clipboard_select";
			this.Clipboard_select.Size = new System.Drawing.Size(24, 31);
			this.Clipboard_select.TabIndex = 51;
			this.Clipboard_select.Text = " ";
			this.Clipboard_select.UseVisualStyleBackColor = false;
			// 
			// Clipboard_title
			// 
			this.Clipboard_title.AutoSize = true;
			this.Clipboard_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Clipboard_title.Location = new System.Drawing.Point(26, 362);
			this.Clipboard_title.Name = "Clipboard_title";
			this.Clipboard_title.Size = new System.Drawing.Size(102, 21);
			this.Clipboard_title.TabIndex = 50;
			this.Clipboard_title.Text = "CLIPBOARD:";
			// 
			// id_textbox
			// 
			this.id_textbox.Location = new System.Drawing.Point(70, 201);
			this.id_textbox.Name = "id_textbox";
			this.id_textbox.Size = new System.Drawing.Size(100, 20);
			this.id_textbox.TabIndex = 76;
			// 
			// user_textbox
			// 
			this.user_textbox.Enabled = false;
			this.user_textbox.Location = new System.Drawing.Point(70, 237);
			this.user_textbox.Name = "user_textbox";
			this.user_textbox.Size = new System.Drawing.Size(100, 20);
			this.user_textbox.TabIndex = 77;
			// 
			// password_textbox
			// 
			this.password_textbox.Location = new System.Drawing.Point(70, 276);
			this.password_textbox.Name = "password_textbox";
			this.password_textbox.Size = new System.Drawing.Size(100, 20);
			this.password_textbox.TabIndex = 78;
			// 
			// id_lbl
			// 
			this.id_lbl.AutoSize = true;
			this.id_lbl.Location = new System.Drawing.Point(43, 204);
			this.id_lbl.Name = "id_lbl";
			this.id_lbl.Size = new System.Drawing.Size(21, 13);
			this.id_lbl.TabIndex = 79;
			this.id_lbl.Text = "ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 240);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 80;
			this.label2.Text = "User:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 279);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 81;
			this.label3.Text = "PW:";
			// 
			// Getir_button
			// 
			this.Getir_button.Location = new System.Drawing.Point(176, 199);
			this.Getir_button.Name = "Getir_button";
			this.Getir_button.Size = new System.Drawing.Size(50, 23);
			this.Getir_button.TabIndex = 82;
			this.Getir_button.Text = "Getir";
			this.Getir_button.UseVisualStyleBackColor = true;
			this.Getir_button.Click += new System.EventHandler(this.Getir_button_Click);
			// 
			// DeleteUser_button
			// 
			this.DeleteUser_button.Location = new System.Drawing.Point(295, 319);
			this.DeleteUser_button.Name = "DeleteUser_button";
			this.DeleteUser_button.Size = new System.Drawing.Size(93, 23);
			this.DeleteUser_button.TabIndex = 83;
			this.DeleteUser_button.Text = "Delete User";
			this.DeleteUser_button.UseVisualStyleBackColor = true;
			this.DeleteUser_button.Click += new System.EventHandler(this.DeleteUser_button_Click);
			// 
			// UpdateUser_button
			// 
			this.UpdateUser_button.Location = new System.Drawing.Point(70, 302);
			this.UpdateUser_button.Name = "UpdateUser_button";
			this.UpdateUser_button.Size = new System.Drawing.Size(100, 40);
			this.UpdateUser_button.TabIndex = 84;
			this.UpdateUser_button.Text = "Update User";
			this.UpdateUser_button.UseVisualStyleBackColor = true;
			this.UpdateUser_button.Click += new System.EventHandler(this.UpdateUser_button_Click);
			// 
			// AllUsers_DataGrid
			// 
			this.AllUsers_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AllUsers_DataGrid.Location = new System.Drawing.Point(437, 107);
			this.AllUsers_DataGrid.Name = "AllUsers_DataGrid";
			this.AllUsers_DataGrid.Size = new System.Drawing.Size(447, 209);
			this.AllUsers_DataGrid.TabIndex = 85;
			// 
			// Refresh_button
			// 
			this.Refresh_button.Location = new System.Drawing.Point(809, 79);
			this.Refresh_button.Name = "Refresh_button";
			this.Refresh_button.Size = new System.Drawing.Size(75, 23);
			this.Refresh_button.TabIndex = 86;
			this.Refresh_button.Text = "Refresh";
			this.Refresh_button.UseVisualStyleBackColor = true;
			this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
			// 
			// dtuser_lbl
			// 
			this.dtuser_lbl.AutoSize = true;
			this.dtuser_lbl.BackColor = System.Drawing.Color.RoyalBlue;
			this.dtuser_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dtuser_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.dtuser_lbl.Location = new System.Drawing.Point(437, 79);
			this.dtuser_lbl.Name = "dtuser_lbl";
			this.dtuser_lbl.Size = new System.Drawing.Size(60, 25);
			this.dtuser_lbl.TabIndex = 87;
			this.dtuser_lbl.Text = "Users";
			// 
			// UserSettings_DataGrid
			// 
			this.UserSettings_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UserSettings_DataGrid.Location = new System.Drawing.Point(437, 372);
			this.UserSettings_DataGrid.Name = "UserSettings_DataGrid";
			this.UserSettings_DataGrid.Size = new System.Drawing.Size(447, 235);
			this.UserSettings_DataGrid.TabIndex = 88;
			// 
			// dtsettings_lbl
			// 
			this.dtsettings_lbl.AutoSize = true;
			this.dtsettings_lbl.BackColor = System.Drawing.Color.RoyalBlue;
			this.dtsettings_lbl.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dtsettings_lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.dtsettings_lbl.Location = new System.Drawing.Point(437, 344);
			this.dtsettings_lbl.Name = "dtsettings_lbl";
			this.dtsettings_lbl.Size = new System.Drawing.Size(84, 25);
			this.dtsettings_lbl.TabIndex = 89;
			this.dtsettings_lbl.Text = "Settings";
			// 
			// Logout_button
			// 
			this.Logout_button.BackColor = System.Drawing.Color.Red;
			this.Logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Logout_button.ForeColor = System.Drawing.Color.White;
			this.Logout_button.Location = new System.Drawing.Point(725, 32);
			this.Logout_button.Name = "Logout_button";
			this.Logout_button.Size = new System.Drawing.Size(75, 23);
			this.Logout_button.TabIndex = 90;
			this.Logout_button.Text = "Logout";
			this.Logout_button.UseVisualStyleBackColor = false;
			this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
			// 
			// Admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(896, 839);
			this.Controls.Add(this.Logout_button);
			this.Controls.Add(this.dtsettings_lbl);
			this.Controls.Add(this.UserSettings_DataGrid);
			this.Controls.Add(this.dtuser_lbl);
			this.Controls.Add(this.Refresh_button);
			this.Controls.Add(this.AllUsers_DataGrid);
			this.Controls.Add(this.UpdateUser_button);
			this.Controls.Add(this.DeleteUser_button);
			this.Controls.Add(this.Getir_button);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.id_lbl);
			this.Controls.Add(this.password_textbox);
			this.Controls.Add(this.user_textbox);
			this.Controls.Add(this.id_textbox);
			this.Controls.Add(this.OldWindows_select);
			this.Controls.Add(this.OldWindows_title);
			this.Controls.Add(this.DownloadCache_select);
			this.Controls.Add(this.DownloadCache_title);
			this.Controls.Add(this.FontCache_select);
			this.Controls.Add(this.FontCache_title);
			this.Controls.Add(this.Prefetch_select);
			this.Controls.Add(this.Prefetch_title);
			this.Controls.Add(this.MemoryDumps_select);
			this.Controls.Add(this.MemoryDumps_title);
			this.Controls.Add(this.SystemCache_select);
			this.Controls.Add(this.SystemCache_title);
			this.Controls.Add(this.Logs_select);
			this.Controls.Add(this.Logs_title);
			this.Controls.Add(this.DNSCache_select);
			this.Controls.Add(this.DNSCache_title);
			this.Controls.Add(this.PreviewCache_select);
			this.Controls.Add(this.PreviewCache_title);
			this.Controls.Add(this.RecentlyUsed_select);
			this.Controls.Add(this.RecentlyUsed_title);
			this.Controls.Add(this.DownloadedInstallations_select);
			this.Controls.Add(this.DownloadedInstallations_title);
			this.Controls.Add(this.TemporaryFiles_select);
			this.Controls.Add(this.TemporaryFiles_title);
			this.Controls.Add(this.Clipboard_select);
			this.Controls.Add(this.Clipboard_title);
			this.Controls.Add(this.Minimize);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.Label_join);
			this.Controls.Add(this.LogoPanel);
			this.Controls.Add(this.ControlPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Admin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Admin";
			this.Load += new System.EventHandler(this.Admin_Load);
			this.LogoPanel.ResumeLayout(false);
			this.LogoPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AllUsers_DataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UserSettings_DataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label Label_join;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Panel LogoPanel;
		private System.Windows.Forms.PictureBox Logo;
		private System.Windows.Forms.Panel ControlPanel;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.Button Minimize;
		private System.Windows.Forms.CheckBox OldWindows_select;
		private System.Windows.Forms.Label OldWindows_title;
		private System.Windows.Forms.CheckBox DownloadCache_select;
		private System.Windows.Forms.Label DownloadCache_title;
		private System.Windows.Forms.CheckBox FontCache_select;
		private System.Windows.Forms.Label FontCache_title;
		private System.Windows.Forms.CheckBox Prefetch_select;
		private System.Windows.Forms.Label Prefetch_title;
		private System.Windows.Forms.CheckBox MemoryDumps_select;
		private System.Windows.Forms.Label MemoryDumps_title;
		private System.Windows.Forms.CheckBox SystemCache_select;
		private System.Windows.Forms.Label SystemCache_title;
		private System.Windows.Forms.CheckBox Logs_select;
		private System.Windows.Forms.Label Logs_title;
		private System.Windows.Forms.CheckBox DNSCache_select;
		private System.Windows.Forms.Label DNSCache_title;
		private System.Windows.Forms.CheckBox PreviewCache_select;
		private System.Windows.Forms.Label PreviewCache_title;
		private System.Windows.Forms.CheckBox RecentlyUsed_select;
		private System.Windows.Forms.Label RecentlyUsed_title;
		private System.Windows.Forms.CheckBox DownloadedInstallations_select;
		private System.Windows.Forms.Label DownloadedInstallations_title;
		private System.Windows.Forms.CheckBox TemporaryFiles_select;
		private System.Windows.Forms.Label TemporaryFiles_title;
		private System.Windows.Forms.CheckBox Clipboard_select;
		private System.Windows.Forms.Label Clipboard_title;
		private System.Windows.Forms.TextBox id_textbox;
		private System.Windows.Forms.TextBox user_textbox;
		private System.Windows.Forms.TextBox password_textbox;
		private System.Windows.Forms.Label id_lbl;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Getir_button;
		private System.Windows.Forms.Button DeleteUser_button;
		private System.Windows.Forms.Button UpdateUser_button;
		private System.Windows.Forms.DataGridView AllUsers_DataGrid;
		private System.Windows.Forms.Button Refresh_button;
		private System.Windows.Forms.Label dtuser_lbl;
		private System.Windows.Forms.DataGridView UserSettings_DataGrid;
		private System.Windows.Forms.Label dtsettings_lbl;
		private System.Windows.Forms.Button Logout_button;
	}
}