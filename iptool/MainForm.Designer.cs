/*
 * Created by SharpDevelop.
 * User: joheri11
 * Date: 2011-12-04
 * Time: 14:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace iptool
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonRelease = new System.Windows.Forms.Button();
			this.buttonRenew = new System.Windows.Forms.Button();
			this.processIpTool = new System.Diagnostics.Process();
			this.SuspendLayout();
			// 
			// buttonRelease
			// 
			this.buttonRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonRelease.Location = new System.Drawing.Point(12, 25);
			this.buttonRelease.Name = "buttonRelease";
			this.buttonRelease.Size = new System.Drawing.Size(75, 23);
			this.buttonRelease.TabIndex = 0;
			this.buttonRelease.Text = "Release";
			this.buttonRelease.UseVisualStyleBackColor = true;
			this.buttonRelease.Click += new System.EventHandler(this.ButtonReleaseClick);
			// 
			// buttonRenew
			// 
			this.buttonRenew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRenew.Location = new System.Drawing.Point(210, 25);
			this.buttonRenew.Name = "buttonRenew";
			this.buttonRenew.Size = new System.Drawing.Size(75, 23);
			this.buttonRenew.TabIndex = 1;
			this.buttonRenew.Text = "Renew";
			this.buttonRenew.UseVisualStyleBackColor = true;
			this.buttonRenew.Click += new System.EventHandler(this.ButtonRenewClick);
			// 
			// processIpTool
			// 
			this.processIpTool.EnableRaisingEvents = true;
			this.processIpTool.StartInfo.CreateNoWindow = true;
			this.processIpTool.StartInfo.Domain = "";
			this.processIpTool.StartInfo.ErrorDialog = true;
			this.processIpTool.StartInfo.FileName = "ipconfig";
			this.processIpTool.StartInfo.LoadUserProfile = false;
			this.processIpTool.StartInfo.Password = null;
			this.processIpTool.StartInfo.StandardErrorEncoding = null;
			this.processIpTool.StartInfo.StandardOutputEncoding = null;
			this.processIpTool.StartInfo.UserName = "";
			this.processIpTool.SynchronizingObject = this;
			this.processIpTool.Exited += new System.EventHandler(this.ProcessIpToolExited);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 67);
			this.Controls.Add(this.buttonRenew);
			this.Controls.Add(this.buttonRelease);
			this.Name = "MainForm";
			this.Text = "Very Small IpTool";
			this.ResumeLayout(false);
		}
		private System.Diagnostics.Process processIpTool;
		private System.Windows.Forms.Button buttonRenew;
		private System.Windows.Forms.Button buttonRelease;
	}
}
