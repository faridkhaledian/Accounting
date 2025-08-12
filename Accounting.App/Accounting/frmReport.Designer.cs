namespace Accounting.App
{
	partial class frmReport
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnEdite = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.btnPrint = new System.Windows.Forms.ToolStripButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtToDate = new System.Windows.Forms.MaskedTextBox();
			this.btnFilter = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFromDate = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbCustomer = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgReport = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stiPrint = new Stimulsoft.Report.StiReport();
			this.toolStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgReport)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEdite,
            this.btnDelete,
            this.btnRefresh,
            this.btnPrint});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(801, 68);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
			// 
			// btnEdite
			// 
			this.btnEdite.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdite.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
			this.btnEdite.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnEdite.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdite.Name = "btnEdite";
			this.btnEdite.Size = new System.Drawing.Size(66, 63);
			this.btnEdite.Text = "ویرایش";
			this.btnEdite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
			this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(50, 63);
			this.btnDelete.Text = "حذف";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh.Image = global::Accounting.App.Properties.Resources._1371476342_Refresh;
			this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(99, 63);
			this.btnRefresh.Text = "بروز رسانی";
			this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrint.Image = global::Accounting.App.Properties.Resources._1371476276_Print;
			this.btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(45, 63);
			this.btnPrint.Text = "چاپ";
			this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtToDate);
			this.groupBox1.Controls.Add(this.btnFilter);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtFromDate);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cbCustomer);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 90);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(777, 86);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "جستجو";
			// 
			// txtToDate
			// 
			this.txtToDate.Location = new System.Drawing.Point(87, 41);
			this.txtToDate.Mask = "0000/00/00";
			this.txtToDate.Name = "txtToDate";
			this.txtToDate.Size = new System.Drawing.Size(132, 27);
			this.txtToDate.TabIndex = 9;
			this.txtToDate.ValidatingType = typeof(System.DateTime);
			// 
			// btnFilter
			// 
			this.btnFilter.Location = new System.Drawing.Point(5, 39);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(75, 32);
			this.btnFilter.TabIndex = 8;
			this.btnFilter.Text = "انجام";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(219, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "تا تاریخ :";
			// 
			// txtFromDate
			// 
			this.txtFromDate.Location = new System.Drawing.Point(301, 38);
			this.txtFromDate.Mask = "0000/00/00";
			this.txtFromDate.Name = "txtFromDate";
			this.txtFromDate.Size = new System.Drawing.Size(132, 27);
			this.txtFromDate.TabIndex = 5;
			this.txtFromDate.ValidatingType = typeof(System.DateTime);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(435, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "از تاریخ :";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// cbCustomer
			// 
			this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCustomer.FormattingEnabled = true;
			this.cbCustomer.Location = new System.Drawing.Point(519, 36);
			this.cbCustomer.Name = "cbCustomer";
			this.cbCustomer.Size = new System.Drawing.Size(140, 27);
			this.cbCustomer.TabIndex = 3;
			this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(661, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "طرف حساب :";
			// 
			// dgReport
			// 
			this.dgReport.AllowUserToAddRows = false;
			this.dgReport.AllowUserToDeleteRows = false;
			this.dgReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dgReport.Location = new System.Drawing.Point(12, 182);
			this.dgReport.Name = "dgReport";
			this.dgReport.ReadOnly = true;
			this.dgReport.RowHeadersWidth = 62;
			this.dgReport.RowTemplate.Height = 28;
			this.dgReport.Size = new System.Drawing.Size(777, 256);
			this.dgReport.TabIndex = 2;
			this.dgReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReport_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "ID";
			this.Column1.HeaderText = "Column1";
			this.Column1.MinimumWidth = 8;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "CustomerID";
			this.Column2.HeaderText = "طرف حساب";
			this.Column2.MinimumWidth = 8;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Amount";
			this.Column3.HeaderText = "مبلغ";
			this.Column3.MinimumWidth = 8;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "DateTime";
			this.Column4.HeaderText = "تاریخ";
			this.Column4.MinimumWidth = 8;
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Description";
			this.Column5.HeaderText = "بابت";
			this.Column5.MinimumWidth = 8;
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// stiPrint
			// 
			this.stiPrint.CookieContainer = null;
			this.stiPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
			this.stiPrint.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
			this.stiPrint.ReportAlias = "Report";
			this.stiPrint.ReportGuid = "1b14fff57f0b4710b402960b0e2b2161";
			this.stiPrint.ReportName = "Report";
			this.stiPrint.ReportSource = null;
			this.stiPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
			this.stiPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
			this.stiPrint.UseProgressInThread = false;
			// 
			// frmReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(801, 442);
			this.Controls.Add(this.dgReport);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.toolStrip1);
			this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmReport";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "مدیریت تراکنش ها";
			this.Load += new System.EventHandler(this.frmReport_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgReport)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnEdite;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private System.Windows.Forms.ToolStripButton btnPrint;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox txtFromDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbCustomer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox txtToDate;
		private System.Windows.Forms.DataGridView dgReport;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private Stimulsoft.Report.StiReport stiPrint;
	}
}