using Accounting.Business;
using Accounting.utility.Convertor;
using Accounting.ViewModels.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
			this.Hide();
			frmLogin frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK  )
            {
				this.Show();
				lblDate.Text = DateTime.Now.ToShamsi();
				lblTime.Text = DateTime.Now.ToString("HH:mm:ss");

				Report();
				
			}
            else
            {
                Application.Exit();
            }

        }
		void Report()
		{
			ReportViewModel report = Account.ReportForm();
			lblPay.Text=report.Pay.ToString("#,0");
			lblRecive.Text=report.Recive.ToString("#,0");
			lblAccountBalance.Text = report.AccountBalance.ToString("#,0");
		}


		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			frmCustomers frmCustomer = new frmCustomers();
			frmCustomer.ShowDialog();


		}

		private void toolStripComboBox1_Click(object sender, EventArgs e)
		{

		}

		private void toolStripDropDownButton1_Click(object sender, EventArgs e)
		{

		}

		private void btnNewAccounting_Click(object sender, EventArgs e)
		{
			frmNewAccounting frmCustomer = new frmNewAccounting();
				
		frmCustomer.ShowDialog();

		}

		private void btnReportPay_Click(object sender, EventArgs e)
		{
			frmReport frmReport = new frmReport();
			frmReport.TypeID = 2; // pay
			frmReport.ShowDialog();
		}

		private void btnReportRecive_Click(object sender, EventArgs e)
		{
			frmReport frmReport = new frmReport();
			frmReport.TypeID = 1; // Recive
			frmReport.ShowDialog();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
		}

		private void btnEditLogin_Click(object sender, EventArgs e)
		{
			frmLogin frmLogin = new frmLogin();
			frmLogin.IsEdit = true;	
			frmLogin.ShowDialog();
		}

		private void lblDate_Click(object sender, EventArgs e)
		{

		}

		private void lblTime_Click(object sender, EventArgs e)
		{

		}
	}
}
