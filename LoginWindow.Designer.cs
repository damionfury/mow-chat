﻿namespace MowChat
{
	partial class LoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.loginStatus = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 152);
            this.progressBar.MarqueeAnimationSpeed = 30;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.Size = new System.Drawing.Size(360, 49);
            this.progressBar.Style = MetroFramework.MetroColorStyle.Blue;
            this.progressBar.TabIndex = 0;
            this.progressBar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.progressBar.UseWaitCursor = true;
            // 
            // loginStatus
            // 
            this.loginStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.loginStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.loginStatus.Location = new System.Drawing.Point(12, 60);
            this.loginStatus.Name = "loginStatus";
            this.loginStatus.Size = new System.Drawing.Size(360, 89);
            this.loginStatus.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginStatus.TabIndex = 1;
            this.loginStatus.Text = "Status";
            this.loginStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginStatus.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginStatus.UseWaitCursor = true;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 213);
            this.Controls.Add(this.loginStatus);
            this.Controls.Add(this.progressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginWindow";
            this.Resizable = false;
            this.Text = "Chat - March of War";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.ResumeLayout(false);

		}

		#endregion

		private MetroFramework.Controls.MetroProgressBar progressBar;
		private MetroFramework.Controls.MetroLabel loginStatus;
	}
}

