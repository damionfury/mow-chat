﻿namespace MowChat
{
	partial class CharacterSelect
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
			this.characterButton = new System.Windows.Forms.Button();
			this.scrollPanel = new System.Windows.Forms.Panel();
			this.scrollPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// characterButton
			// 
			this.characterButton.Location = new System.Drawing.Point(3, 3);
			this.characterButton.Name = "characterButton";
			this.characterButton.Size = new System.Drawing.Size(197, 35);
			this.characterButton.TabIndex = 2;
			this.characterButton.Text = "Character";
			this.characterButton.UseVisualStyleBackColor = true;
			// 
			// scrollPanel
			// 
			this.scrollPanel.AutoScroll = true;
			this.scrollPanel.Controls.Add(this.characterButton);
			this.scrollPanel.Location = new System.Drawing.Point(12, 12);
			this.scrollPanel.Name = "scrollPanel";
			this.scrollPanel.Size = new System.Drawing.Size(203, 310);
			this.scrollPanel.TabIndex = 1;
			// 
			// CharacterSelect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(227, 334);
			this.Controls.Add(this.scrollPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "CharacterSelect";
			this.Text = "Chat - Select A Character - March of War";
			this.Load += new System.EventHandler(this.CharacterSelect_Load);
			this.scrollPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button characterButton;
		private System.Windows.Forms.Panel scrollPanel;

	}
}