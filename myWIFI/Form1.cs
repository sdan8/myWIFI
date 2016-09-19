using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myWIFI
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			btn_start.Enabled = true;
			btn_stop.Enabled = false;
		}

		private void btn_start_Click(object sender, EventArgs e)
		{
			string ssid = txt_username.Text.Trim();
			string key = txt_password.Text.Trim();
			string cmd_allow = "netsh wlan set hostednetwork mode=allow ssid=" + ssid + " key=" + key;
			string cmd_start = "netsh wlan start hostednetwork";
			if (ssid == "" || key == "")
			{
				MessageBox.Show("请填写完整");
			}
			else if (key.Length < 8)
			{
				MessageBox.Show("密码至少8个字符");
			}
			else
			{
				btn_start.Enabled = false;
				btn_stop.Enabled = true;
				richTxt_log.Text = RunCMD(cmd_allow);
				richTxt_log.Text = RunCMD(cmd_start);
				TSSL_status.Text = "已开启";
				TSSL_ssid.Text = "SSID:" + ssid;
				TSSL_key.Text = "Key:" + key;
				notifyIcon1.Icon = new Icon(Application.StartupPath + @"\wifi_on.ico");
				
			}
		}

		private void btn_stop_Click(object sender, EventArgs e)
		{
			btn_stop.Enabled = false;
			btn_start.Enabled = true;
			string cmd_stop = "netsh wlan stop hostednetwork";
			richTxt_log.Text = RunCMD(cmd_stop);
			TSSL_status.Text = "未开启";
			TSSL_ssid.Text = "";
			TSSL_key.Text = "";
			notifyIcon1.Icon = new Icon(Application.StartupPath + @"\wifi_off.ico");
		}

		private void btn_ipconfig_Click(object sender, EventArgs e)
		{
			string cmd_ipconfig = "ipconfig";
			richTxt_log.Text = RunCMD(cmd_ipconfig);
		}

		private void btn_exit_Click(object sender, EventArgs e)
		{
			if (btn_stop.Enabled)
			{
				btn_stop.Enabled = false;
				btn_start.Enabled = true;
				string cmd_stop = "netsh wlan stop hostednetwork";
				richTxt_log.Text = RunCMD(cmd_stop);
				TSSL_status.Text = "未开启";
				TSSL_ssid.Text = "";
				TSSL_key.Text = "";
			}
			Application.Exit();
		}

		private void chk_showPsw_CheckedChanged(object sender, EventArgs e)
		{
			if (chk_showPsw.Checked)
			{
				txt_password.UseSystemPasswordChar = false;
			}
			else
			{
				txt_password.UseSystemPasswordChar = true;
			}
		}

		private string RunCMD(string str)
		{
			System.Diagnostics.Process p = new System.Diagnostics.Process();
			p.StartInfo.FileName = "cmd.exe";
			p.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动
			p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
			p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
			p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
			p.StartInfo.CreateNoWindow = true;//不显示程序窗口
			p.Start();//启动程序

			//向cmd窗口发送输入信息
			p.StandardInput.WriteLine(str + "&exit");

			p.StandardInput.AutoFlush = true;
			//p.StandardInput.WriteLine("exit");
			//向标准输入写入要执行的命令。这里使用&是批处理命令的符号，表示前面一个命令不管是否执行成功都执行后面(exit)命令，如果不执行exit命令，后面调用ReadToEnd()方法会假死
			//同类的符号还有&&和||前者表示必须前一个命令执行成功才会执行后面的命令，后者表示必须前一个命令执行失败才会执行后面的命令



			//获取cmd窗口的输出信息
			string output = p.StandardOutput.ReadToEnd();

			//StreamReader reader = p.StandardOutput;
			//string line=reader.ReadLine();
			//while (!reader.EndOfStream)
			//{
			//    str += line + "  ";
			//    line = reader.ReadLine();
			//}

			p.WaitForExit();//等待程序执行完退出进程
			p.Close();

			//richTextBox1.Text = output;
			//Console.WriteLine(output);
			return output;
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Hide();
				this.ShowInTaskbar = false;
				this.notifyIcon1.Visible = true;
			}
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Show();
				this.ShowInTaskbar = true;
				this.notifyIcon1.Visible = false;
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (btn_stop.Enabled)
			{
				btn_stop.Enabled = false;
				btn_start.Enabled = true;
				string cmd_stop = "netsh wlan stop hostednetwork";
				richTxt_log.Text = RunCMD(cmd_stop);
				TSSL_status.Text = "未开启";
				TSSL_ssid.Text = "";
				TSSL_key.Text = "";
			}
			Application.Exit();
		}

		private void showToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Show();
				this.ShowInTaskbar = true;
				this.notifyIcon1.Visible = false;
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (btn_stop.Enabled)
			{
				btn_stop.Enabled = false;
				btn_start.Enabled = true;
				string cmd_stop = "netsh wlan stop hostednetwork";
				richTxt_log.Text = RunCMD(cmd_stop);
				TSSL_status.Text = "未开启";
				TSSL_ssid.Text = "";
				TSSL_key.Text = "";
			}
			//Application.Exit();
		}

		

		

		

		

		

	}
}
