/*
 * Created by SharpDevelop.
 * User: joheri11
 * Date: 2011-12-04
 * Time: 14:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace iptool
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ButtonRenewClick(object sender, EventArgs e)
		{
			processIpTool.StartInfo.Arguments = "/renew";
			if(processIpTool.Start())
			{
				processIpTool.WaitForExit();
			}
			buttonRelease.Enabled = false;
			buttonRenew.Enabled = false;			
		}
		
		void ButtonReleaseClick(object sender, EventArgs e)
		{
			processIpTool.StartInfo.Arguments = "/release";
			if(processIpTool.Start())
			{
				processIpTool.WaitForExit();
			}
			buttonRelease.Enabled = false;
			buttonRenew.Enabled = false;
		}
		
		void ProcessIpToolExited(object sender, EventArgs e)
		{
			buttonRelease.Enabled = true;
			buttonRenew.Enabled = true;
		}
	}
}
