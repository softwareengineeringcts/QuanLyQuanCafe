using Coffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.DAO
{
	class TableDAO
	{
		private static TableDAO instance;

		public static TableDAO Instance
		{
			get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
			private set { TableDAO.instance = value; }
		}

		public static int TableWidth = 140;
		public static int TableHeight = 140;

		private TableDAO() { }

		public void SwitchTable(int id1, int id2)
		{
			DataProvider.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[] { id1, id2 }); //Đổi bàn
		}

		public List<Table> LoadTableList()
		{
			List<Table> tableList = new List<Table>();

			DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList"); //Lấy danh sách bàn

			foreach (DataRow item in data.Rows)
			{
				Table table = new Table(item);
				tableList.Add(table);
			}

			return tableList;
		}
	}
}
