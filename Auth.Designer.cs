namespace PASPAS
{
	partial class Auth
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
			this.Minimize = new System.Windows.Forms.Button();
			this.ControlPanel = new System.Windows.Forms.Panel();
			this.Exit = new System.Windows.Forms.Button();
			this.Username_label = new System.Windows.Forms.Label();
			this.Username_textbox = new System.Windows.Forms.TextBox();
			this.Password_textbox = new System.Windows.Forms.TextBox();
			this.Password_label = new System.Windows.Forms.Label();
			this.Logo = new System.Windows.Forms.PictureBox();
			this.LogoPanel = new System.Windows.Forms.Panel();
			this.Title = new System.Windows.Forms.Label();
			this.Label_join = new System.Windows.Forms.Label();
			this.Label_join_intro = new System.Windows.Forms.Label();
			this.Join_button = new System.Windows.Forms.Button();
			this.connectionStatus = new System.Windows.Forms.Timer(this.components);
			this.Label_status = new System.Windows.Forms.Label();
			this.Label_statuslive = new System.Windows.Forms.Label();
			this.Join_panel = new System.Windows.Forms.Panel();
			this.Database_error = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
			this.LogoPanel.SuspendLayout();
			this.Join_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// Minimize
			// 
			this.Minimize.BackColor = System.Drawing.Color.Gold;
			this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Minimize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Minimize.Location = new System.Drawing.Point(631, 3);
			this.Minimize.Name = "Minimize";
			this.Minimize.Size = new System.Drawing.Size(38, 38);
			this.Minimize.TabIndex = 28;
			this.Minimize.Text = "—";
			this.Minimize.UseVisualStyleBackColor = false;
			this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
			// 
			// ControlPanel
			// 
			this.ControlPanel.BackColor = System.Drawing.Color.Yellow;
			this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ControlPanel.Location = new System.Drawing.Point(1, 2);
			this.ControlPanel.Name = "ControlPanel";
			this.ControlPanel.Size = new System.Drawing.Size(720, 15);
			this.ControlPanel.TabIndex = 26;
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
			this.Exit.Location = new System.Drawing.Point(675, 3);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(38, 38);
			this.Exit.TabIndex = 27;
			this.Exit.Text = "X";
			this.Exit.UseVisualStyleBackColor = false;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// Username_label
			// 
			this.Username_label.AutoSize = true;
			this.Username_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Username_label.Location = new System.Drawing.Point(292, 177);
			this.Username_label.Name = "Username_label";
			this.Username_label.Size = new System.Drawing.Size(37, 25);
			this.Username_label.TabIndex = 29;
			this.Username_label.Text = "ID:";
			// 
			// Username_textbox
			// 
			this.Username_textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Username_textbox.Location = new System.Drawing.Point(297, 205);
			this.Username_textbox.Name = "Username_textbox";
			this.Username_textbox.Size = new System.Drawing.Size(128, 25);
			this.Username_textbox.TabIndex = 30;
			// 
			// Password_textbox
			// 
			this.Password_textbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Password_textbox.Location = new System.Drawing.Point(297, 261);
			this.Password_textbox.Name = "Password_textbox";
			this.Password_textbox.PasswordChar = '*';
			this.Password_textbox.Size = new System.Drawing.Size(128, 25);
			this.Password_textbox.TabIndex = 32;
			// 
			// Password_label
			// 
			this.Password_label.AutoSize = true;
			this.Password_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Password_label.Location = new System.Drawing.Point(292, 233);
			this.Password_label.Name = "Password_label";
			this.Password_label.Size = new System.Drawing.Size(48, 25);
			this.Password_label.TabIndex = 31;
			this.Password_label.Text = "PW:";
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
			// LogoPanel
			// 
			this.LogoPanel.BackColor = System.Drawing.Color.Yellow;
			this.LogoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.LogoPanel.Controls.Add(this.Logo);
			this.LogoPanel.Controls.Add(this.Title);
			this.LogoPanel.Location = new System.Drawing.Point(56, 2);
			this.LogoPanel.Name = "LogoPanel";
			this.LogoPanel.Size = new System.Drawing.Size(140, 150);
			this.LogoPanel.TabIndex = 33;
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
			// Label_join
			// 
			this.Label_join.AutoSize = true;
			this.Label_join.BackColor = System.Drawing.Color.SteelBlue;
			this.Label_join.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Label_join.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.Label_join.Location = new System.Drawing.Point(230, 73);
			this.Label_join.Name = "Label_join";
			this.Label_join.Size = new System.Drawing.Size(102, 47);
			this.Label_join.TabIndex = 34;
			this.Label_join.Text = "JOIN";
			// 
			// Label_join_intro
			// 
			this.Label_join_intro.AutoSize = true;
			this.Label_join_intro.BackColor = System.Drawing.Color.SteelBlue;
			this.Label_join_intro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Label_join_intro.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.Label_join_intro.Location = new System.Drawing.Point(235, 121);
			this.Label_join_intro.Name = "Label_join_intro";
			this.Label_join_intro.Size = new System.Drawing.Size(185, 13);
			this.Label_join_intro.TabIndex = 35;
			this.Label_join_intro.Text = "Join for a personalized experience.";
			// 
			// Join_button
			// 
			this.Join_button.BackColor = System.Drawing.Color.Lime;
			this.Join_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Join_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Join_button.Location = new System.Drawing.Point(297, 307);
			this.Join_button.Name = "Join_button";
			this.Join_button.Size = new System.Drawing.Size(128, 33);
			this.Join_button.TabIndex = 38;
			this.Join_button.Text = "JOIN";
			this.Join_button.UseVisualStyleBackColor = false;
			this.Join_button.Click += new System.EventHandler(this.Join_button_Click);
			// 
			// connectionStatus
			// 
			this.connectionStatus.Interval = 10000;
			this.connectionStatus.Tick += new System.EventHandler(this.connectionStatus_Tick);
			// 
			// Label_status
			// 
			this.Label_status.AutoSize = true;
			this.Label_status.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Label_status.Location = new System.Drawing.Point(13, 425);
			this.Label_status.Name = "Label_status";
			this.Label_status.Size = new System.Drawing.Size(108, 13);
			this.Label_status.TabIndex = 39;
			this.Label_status.Text = "Connection Status: ";
			// 
			// Label_statuslive
			// 
			this.Label_statuslive.AutoSize = true;
			this.Label_statuslive.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Label_statuslive.Location = new System.Drawing.Point(117, 425);
			this.Label_statuslive.Name = "Label_statuslive";
			this.Label_statuslive.Size = new System.Drawing.Size(134, 13);
			this.Label_statuslive.TabIndex = 40;
			this.Label_statuslive.Text = "Status (-- / -- / --- hh:mm)";
			// 
			// Join_panel
			// 
			this.Join_panel.BackColor = System.Drawing.Color.SteelBlue;
			this.Join_panel.Controls.Add(this.Minimize);
			this.Join_panel.Controls.Add(this.Exit);
			this.Join_panel.Location = new System.Drawing.Point(1, 16);
			this.Join_panel.Name = "Join_panel";
			this.Join_panel.Size = new System.Drawing.Size(720, 137);
			this.Join_panel.TabIndex = 41;
			// 
			// Database_error
			// 
			this.Database_error.AutoSize = true;
			this.Database_error.BackColor = System.Drawing.SystemColors.Window;
			this.Database_error.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Database_error.ForeColor = System.Drawing.Color.Red;
			this.Database_error.Location = new System.Drawing.Point(223, 358);
			this.Database_error.Name = "Database_error";
			this.Database_error.Size = new System.Drawing.Size(267, 30);
			this.Database_error.TabIndex = 42;
			this.Database_error.Text = "DATABASE UNAVAILABLE";
			this.Database_error.Visible = false;
			// 
			// Auth
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(720, 450);
			this.Controls.Add(this.Database_error);
			this.Controls.Add(this.Label_statuslive);
			this.Controls.Add(this.Label_status);
			this.Controls.Add(this.Join_button);
			this.Controls.Add(this.Label_join_intro);
			this.Controls.Add(this.Label_join);
			this.Controls.Add(this.LogoPanel);
			this.Controls.Add(this.Password_textbox);
			this.Controls.Add(this.Password_label);
			this.Controls.Add(this.Username_textbox);
			this.Controls.Add(this.Username_label);
			this.Controls.Add(this.ControlPanel);
			this.Controls.Add(this.Join_panel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Auth";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Auth";
			this.Load += new System.EventHandler(this.Auth_Load);
			((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
			this.LogoPanel.ResumeLayout(false);
			this.LogoPanel.PerformLayout();
			this.Join_panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Minimize;
		private System.Windows.Forms.Panel ControlPanel;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.Label Username_label;
		private System.Windows.Forms.TextBox Username_textbox;
		private System.Windows.Forms.TextBox Password_textbox;
		private System.Windows.Forms.Label Password_label;
		private System.Windows.Forms.PictureBox Logo;
		private System.Windows.Forms.Panel LogoPanel;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Label Label_join;
		private System.Windows.Forms.Label Label_join_intro;
		private System.Windows.Forms.Button Join_button;
		private System.Windows.Forms.Timer connectionStatus;
		private System.Windows.Forms.Label Label_status;
		private System.Windows.Forms.Label Label_statuslive;
		private System.Windows.Forms.Panel Join_panel;
		private System.Windows.Forms.Label Database_error;
	}
}