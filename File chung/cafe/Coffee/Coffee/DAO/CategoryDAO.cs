﻿using Coffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.DAO
{
	public class CategoryDAO
	{
		private static CategoryDAO instance;

		public static CategoryDAO Instance
		{
			get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
			private set { CategoryDAO.instance = value; }
		}

		private CategoryDAO() { }
        public static int CategoryWidth = 200; //chiều dài button danh sách
        public static int CategoryHeight = 100; //chiều cao button danh sách
		public List<Category> GetListCategory()
		{
			List<Category> list = new List<Category>();

			string query = "select * from FoodCategory";

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				Category category = new Category(item);
				list.Add(category);
			}

			return list;
		}
        public Category GetCategoryByID(int id)
        {
            Category category = null;

            string query = "select * from FoodCategory where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }

            return category;
        }
        public bool InsertCategory(int id, string name)
        {
            string query = string.Format("INSERT dbo.FoodCategory (name )VALUES  ( N'{0}')",  name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCategory(int id, string name)
        {
            string query = string.Format("UPDATE dbo.FoodCategory SET name = N'{0}'WHERE id = {1}", name,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCategory(int id)
        {
            string query = string.Format("Delete dbo.FoodCategory where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
	}
}
