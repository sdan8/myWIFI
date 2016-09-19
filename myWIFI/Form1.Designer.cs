namespace myWIFI
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btn_start = new System.Windows.Forms.Button();
			this.txt_username = new System.Windows.Forms.TextBox();
			this.richTxt_log = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_password = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_stop = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_ipconfig = new System.Windows.Forms.Button();
			this.btn_exit = new System.Windows.Forms.Button();
			this.chk_showPsw = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.TSSL_status = new System.Windows.Forms.ToolStripStatusLabel();
			this.TSSL_line_1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.TSSL_ssid = new System.Windows.Forms.ToolStripStatusLabel();
			this.TSSL_line_2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.TSSL_key = new System.Windows.Forms.ToolStripStatusLabel();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_start
			// 
			this.btn_start.Location = new System.Drawing.Point(19, 95);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new System.Drawing.Size(72, 23);
			this.btn_start.TabIndex = 0;
			this.btn_start.Text = "开启";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
			// 
			// txt_username
			// 
			this.txt_username.Location = new System.Drawing.Point(76, 22);
			this.txt_username.MaxLength = 20;
			this.txt_username.Name = "txt_username";
			this.txt_username.Size = new System.Drawing.Size(127, 21);
			this.txt_username.TabIndex = 1;
			// 
			// richTxt_log
			// 
			this.richTxt_log.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.richTxt_log.Location = new System.Drawing.Point(19, 23);
			this.richTxt_log.Name = "richTxt_log";
			this.richTxt_log.Size = new System.Drawing.Size(315, 221);
			this.richTxt_log.TabIndex = 2;
			this.richTxt_log.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "用户名：";
			// 
			// txt_password
			// 
			this.txt_password.Location = new System.Drawing.Point(76, 51);
			this.txt_password.MaxLength = 20;
			this.txt_password.Name = "txt_password";
			this.txt_password.Size = new System.Drawing.Size(127, 21);
			this.txt_password.TabIndex = 4;
			this.txt_password.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "密码：";
			// 
			// btn_stop
			// 
			this.btn_stop.Location = new System.Drawing.Point(97, 95);
			this.btn_stop.Name = "btn_stop";
			this.btn_stop.Size = new System.Drawing.Size(75, 23);
			this.btn_stop.TabIndex = 6;
			this.btn_stop.Text = "关闭";
			this.btn_stop.UseVisualStyleBackColor = true;
			this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_ipconfig);
			this.groupBox1.Controls.Add(this.btn_exit);
			this.groupBox1.Controls.Add(this.chk_showPsw);
			this.groupBox1.Controls.Add(this.btn_stop);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btn_start);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txt_username);
			this.groupBox1.Controls.Add(this.txt_password);
			this.groupBox1.Location = new System.Drawing.Point(23, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(355, 133);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "操作";
			// 
			// btn_ipconfig
			// 
			this.btn_ipconfig.Location = new System.Drawing.Point(178, 95);
			this.btn_ipconfig.Name = "btn_ipconfig";
			this.btn_ipconfig.Size = new System.Drawing.Size(75, 23);
			this.btn_ipconfig.TabIndex = 10;
			this.btn_ipconfig.Text = "ipconfig";
			this.btn_ipconfig.UseVisualStyleBackColor = true;
			this.btn_ipconfig.Click += new System.EventHandler(this.btn_ipconfig_Click);
			// 
			// btn_exit
			// 
			this.btn_exit.Location = new System.Drawing.Point(259, 95);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(75, 23);
			this.btn_exit.TabIndex = 9;
			this.btn_exit.Text = "退出";
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			// 
			// chk_showPsw
			// 
			this.chk_showPsw.AutoSize = true;
			this.chk_showPsw.Location = new System.Drawing.Point(209, 56);
			this.chk_showPsw.Name = "chk_showPsw";
			this.chk_showPsw.Size = new System.Drawing.Size(72, 16);
			this.chk_showPsw.TabIndex = 6;
			this.chk_showPsw.Text = "显示密码";
			this.chk_showPsw.UseVisualStyleBackColor = true;
			this.chk_showPsw.CheckedChanged += new System.EventHandler(this.chk_showPsw_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.richTxt_log);
			this.groupBox2.Location = new System.Drawing.Point(23, 186);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(355, 257);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "日志";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_status,
            this.TSSL_line_1,
            this.TSSL_ssid,
            this.TSSL_line_2,
            this.TSSL_key});
			this.statusStrip1.Location = new System.Drawing.Point(0, 463);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(403, 22);
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// TSSL_status
			// 
			this.TSSL_status.Name = "TSSL_status";
			this.TSSL_status.Size = new System.Drawing.Size(43, 17);
			this.TSSL_status.Text = "未开启";
			// 
			// TSSL_line_1
			// 
			this.TSSL_line_1.Name = "TSSL_line_1";
			this.TSSL_line_1.Size = new System.Drawing.Size(10, 17);
			this.TSSL_line_1.Text = "|";
			// 
			// TSSL_ssid
			// 
			this.TSSL_ssid.Name = "TSSL_ssid";
			this.TSSL_ssid.Size = new System.Drawing.Size(0, 17);
			// 
			// TSSL_line_2
			// 
			this.TSSL_line_2.Name = "TSSL_line_2";
			this.TSSL_line_2.Size = new System.Drawing.Size(10, 17);
			this.TSSL_line_2.Text = "|";
			// 
			// TSSL_key
			// 
			this.TSSL_key.Name = "TSSL_key";
			this.TSSL_key.Size = new System.Drawing.Size(0, 17);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(99, 48);
			// 
			// showToolStripMenuItem
			// 
			this.showToolStripMenuItem.Name = "showToolStripMenuItem";
			this.showToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.showToolStripMenuItem.Text = "显示";
			this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.exitToolStripMenuItem.Text = "退出";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 485);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(419, 524);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MyWi-Fi";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_start;
		private System.Windows.Forms.TextBox txt_username;
		private System.Windows.Forms.RichTextBox richTxt_log;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_password;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_stop;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chk_showPsw;
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel TSSL_status;
		private System.Windows.Forms.ToolStripStatusLabel TSSL_line_1;
		private System.Windows.Forms.ToolStripStatusLabel TSSL_ssid;
		private System.Windows.Forms.ToolStripStatusLabel TSSL_line_2;
		private System.Windows.Forms.ToolStripStatusLabel TSSL_key;
		private System.Windows.Forms.Button btn_ipconfig;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}

