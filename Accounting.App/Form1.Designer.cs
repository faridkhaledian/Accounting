namespace Accounting.App
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnCustomers = new System.Windows.Forms.ToolStripButton();
			this.btnNewAccounting = new System.Windows.Forms.ToolStripButton();
			this.btnReportPay = new System.Windows.Forms.ToolStripButton();
			this.btnReportRecive = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.btnEditLogin = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(778, 38);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStrip2
			// 
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustomers,
            this.btnNewAccounting,
            this.btnReportPay,
            this.btnReportRecive});
			this.toolStrip2.Location = new System.Drawing.Point(0, 38);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(778, 68);
			this.toolStrip2.TabIndex = 1;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
			this.statusStrip1.Location = new System.Drawing.Point(0, 512);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(778, 32);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblDate
			// 
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(179, 25);
			this.lblDate.Text = "toolStripStatusLabel1";
			// 
			// lblTime
			// 
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(179, 25);
			this.lblTime.Text = "toolStripStatusLabel2";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Accounting.App.Properties.Resources.output;
			this.pictureBox1.Location = new System.Drawing.Point(26, 155);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(258, 220);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// btnCustomers
			// 
			this.btnCustomers.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCustomers.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
			this.btnCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCustomers.Name = "btnCustomers";
			this.btnCustomers.Size = new System.Drawing.Size(105, 63);
			this.btnCustomers.Text = "طرف حساب";
			this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnCustomers.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// btnNewAccounting
			// 
			this.btnNewAccounting.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewAccounting.Image = global::Accounting.App.Properties.Resources._1371476499_todo_list;
			this.btnNewAccounting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnNewAccounting.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNewAccounting.Name = "btnNewAccounting";
			this.btnNewAccounting.Size = new System.Drawing.Size(108, 63);
			this.btnNewAccounting.Text = "تراکنش جدید";
			this.btnNewAccounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnNewAccounting.Click += new System.EventHandler(this.btnNewAccounting_Click);
			// 
			// btnReportPay
			// 
			this.btnReportPay.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReportPay.Image = global::Accounting.App.Properties.Resources.servicesCosts;
			this.btnReportPay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnReportPay.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnReportPay.Name = "btnReportPay";
			this.btnReportPay.Size = new System.Drawing.Size(135, 63);
			this.btnReportPay.Text = "گزارش پرداختی ";
			this.btnReportPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnReportPay.Click += new System.EventHandler(this.btnReportPay_Click);
			// 
			// btnReportRecive
			// 
			this.btnReportRecive.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReportRecive.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
			this.btnReportRecive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnReportRecive.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnReportRecive.Name = "btnReportRecive";
			this.btnReportRecive.Size = new System.Drawing.Size(137, 63);
			this.btnReportRecive.Text = "گزارش دریافتی  ";
			this.btnReportRecive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnReportRecive.Click += new System.EventHandler(this.btnReportRecive_Click);
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditLogin});
			this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(96, 33);
			this.toolStripDropDownButton2.Text = "تنظیمات";
			// 
			// btnEditLogin
			// 
			this.btnEditLogin.Name = "btnEditLogin";
			this.btnEditLogin.Size = new System.Drawing.Size(270, 34);
			this.btnEditLogin.Text = "تنظیمات ورود";
			this.btnEditLogin.Click += new System.EventHandler(this.btnEditLogin_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 544);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.toolStrip2);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "حسابداری شخصی من";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton btnCustomers;
		private System.Windows.Forms.ToolStripButton btnNewAccounting;
		private System.Windows.Forms.ToolStripButton btnReportPay;
		private System.Windows.Forms.ToolStripButton btnReportRecive;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblDate;
		private System.Windows.Forms.ToolStripStatusLabel lblTime;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripMenuItem btnEditLogin;
	}
}

