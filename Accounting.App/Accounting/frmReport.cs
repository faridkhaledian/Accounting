using Accounting.DataLayer.Context;
using Accounting.utility.Convertor;
using Accounting.ViewModels.Customers;
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
	public partial class frmReport : Form
	{
		public int TypeID = 0;
		public frmReport()
		{
			InitializeComponent();
		}

		private void frmReport_Load(object sender, EventArgs e)
		{

			using (UnitOfWork db = new UnitOfWork() )
			{
				List<ListCustomerViewModel> list = new List<ListCustomerViewModel>();

                list.Add(new ListCustomerViewModel()
				{
					CustomerId = 0,
					FullName = "انتخاب کنید"

				});
				list.AddRange(db.CustomerRepository.GetNameCustomer());
				cbCustomer.DataSource = list;
				cbCustomer.DisplayMember = "FullName";
				cbCustomer.ValueMember = "CustomerId";


			}


			if (TypeID == 1)
			{
				this.Text = "گزارش دریافتی ها";
			}
			else
			{
				this.Text = "گزارش پرداختی ها";
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			Filter();
		}

		void Filter()
		{
			using (UnitOfWork db = new UnitOfWork())
			{

				List<DataLayer.Accounting> result = new List<DataLayer.Accounting>();


				DateTime? startDate; // Can be null
				DateTime? endDate; // 



				if ((int)cbCustomer.SelectedValue != 0)
				{
					var customerID = int.Parse(cbCustomer.SelectedValue.ToString());
					result.AddRange(db.AccoountingRepository.Get(x => x.TypeID == TypeID && x.CustomerID == customerID));

				}
				else
				{
					result.AddRange(db.AccoountingRepository.Get(x => x.TypeID == TypeID));
				}


				if (txtFromDate.Text != "    /  /")
				{
					startDate = Convert.ToDateTime(txtFromDate.Text);
				startDate = DateConvertor.ToMiladi(startDate.Value);
					result = result.Where( x=> x.DateTime>=startDate.Value ).ToList();
				}
				if (txtToDate.Text != "    /  /")
				{
					endDate = Convert.ToDateTime(txtToDate.Text);

					endDate = DateConvertor.ToMiladi(endDate.Value);
					result = result.Where(x => x.DateTime <= endDate.Value).ToList();
				}





                //AccoountingRepository == genericRepository<Accounting>
              
				//dgReport.AutoGenerateColumns = false;
				//dgReport.DataSource = result;
				dgReport.Rows.Clear();

				foreach (var accounting in result)
				{

					string customerName = db.CustomerRepository.GetCustomerNameById(accounting.CustomerID);
					dgReport.Rows.Add(accounting.ID, customerName, accounting.Amount, accounting.DateTime.ToShamsi(), accounting.Description);
				}


			}


		}

		private void dgReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			Filter();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgReport.CurrentRow != null)
			{


				int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
				if (RtlMessageBox.Show("آیا از حذف این مورد مطمئن هستید ؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{

					using (UnitOfWork db = new UnitOfWork())
					{
						db.AccoountingRepository.Delete(id);
						db.Save();
						Filter();

					}


				}


			}
		}

		private void btnEdite_Click(object sender, EventArgs e)
		{
			if (dgReport.CurrentRow != null)
			{
				int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
			frmNewAccounting frmNew= new frmNewAccounting();
				frmNew.AccountID = id;
                if (frmNew.ShowDialog() == DialogResult.OK )
                {
					Filter();
                }



            }
		}

		private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
