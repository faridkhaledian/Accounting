using Accounting.DataLayer.Context;
using Accounting.ViewModels.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Business
{
	public class Account
	{

		public static ReportViewModel ReportForm()
		{
			
	ReportViewModel rp = new ReportViewModel();
			using (UnitOfWork db = new UnitOfWork())
			{
				DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
				DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

				var recive = db.AccoountingRepository.Get(x => x.TypeID == 1 && x.DateTime >= startDate && x.DateTime <= endDate).Select(x => x.Amount).ToList();
				var pay = db.AccoountingRepository.Get(x => x.TypeID == 2 && x.DateTime >= startDate && x.DateTime <= endDate).Select(x => x.Amount).ToList();
				rp.Recive = recive.Sum();
				rp.Pay = pay.Sum();
				rp.AccountBalance = (recive.Sum() - pay.Sum());
			}
			return rp;

		}


	}
}
