using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.DTO
{
	public class Bill
	{
		public Bill(int id,DateTime? dateCheckin,DateTime? dateCheckout,int status)
		{
			this.ID = id;
			this.DateCheckin = dateCheckin;
			this.DateCheckout = dateCheckout;
			this.Status = status;
		}

		public Bill(DataRow row)
		{
			this.ID = (int)row["id"];
			this.DateCheckin = (DateTime?)row["dateCheckin"];

			var dateCheckoutTemp = row["dateCheckout"];
			if (dateCheckoutTemp.ToString() != "")
				this.DateCheckout = (DateTime?)dateCheckoutTemp;

			this.Status = (int)row["status"];
		}

		private int iD;
		private DateTime? dateCheckin;
		private DateTime? dateCheckout;
		private int status;

		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}

		public DateTime? DateCheckin
		{
			get { return dateCheckin; }
			set { dateCheckin = value; }
		}

		public DateTime? DateCheckout
		{
			get { return dateCheckout; }
			set { dateCheckout = value; }
		}

		public int Status
		{
			get { return status; }
			set { status = value; }
		}
	}
}
