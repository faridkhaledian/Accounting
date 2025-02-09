namespace Accounting.App
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
			this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtUserName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(9, 19);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(514, 161);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ورود به برنامه";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(399, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "نام کاربری :";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(9, 42);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(366, 27);
			this.txtUserName.TabIndex = 1;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(8, 103);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(367, 27);
			this.txtPassword.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(398, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "کلمه عبور :";
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(395, 186);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(111, 37);
			this.btnLogin.TabIndex = 1;
			this.btnLogin.Text = "ورود/ثبت نام";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// requiredFieldValidator1
			// 
			this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
			this.requiredFieldValidator1.ControlToValidate = this.txtUserName;
			this.requiredFieldValidator1.ErrorMessage = "لطفا نام کاربری را وارد کنید!";
			this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
			// 
			// requiredFieldValidator2
			// 
			this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
			this.requiredFieldValidator2.ControlToValidate = this.txtPassword;
			this.requiredFieldValidator2.ErrorMessage = "لطفا کلمه عبور را وارد کنید!";
			this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 236);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmLogin";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "فرم حسابداری من  ";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLogin;
		private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
		private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
	}
}