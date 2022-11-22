using Insurance_system.Model.ViewModel;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance_system.Model.Servers
{
	public class productservies
	{
		public List<ProductindexVM> GetAll(int type_ID)
		{
			string sql = @"SELECT p.ID, t.Name, c.CompanyName, p.ProductName, p.Price
							FROM Products p
							join [Type of insurance] t on t.ID = p.type_ID
							join [Insurance Company] c on c.ID = p.company_ID";
			SqlParameter[] parameters = new SqlParameter[] { };
			if (type_ID > 0)
			{
				sql += " WHERE type_Id = @type_Id";
				parameters = new SqlParameterBuilder().AddNInt("type_Id", type_ID).Build();
			}

			sql += " Order by p.ID";
			var dbHelper = new SqlDbHelper("default");
			return dbHelper.Select(sql, parameters).AsEnumerable()
							.Select(row => ParseToIndexVM(row)).ToList();
		}
		private ProductindexVM ParseToIndexVM(DataRow row)
		{
			return new ProductindexVM
			{
				Id = row.Field<int>("ID"),
				//type_ID = row.Field<int>("type_ID"),
				//company_ID = row.Field<int>("company_ID"),
				ProductName = row.Field<string>("ProductName"),
				Price = row.Field<int>("Price"),
				Name = row.Field<string>("Name"),
				CompanyName =row.Field<string>("CompanyName")
				
			};
		}
		public void Create(ProductVM model)
		{
			bool isExists = ProductExists(model.ProductName);
			if (isExists) throw new Exception("商品已存在");
			string sql = @"INSERT INTO Products(type_ID,company_ID,ProductName,Price)
						VALUES(@type_ID,@company_ID,@ProductName,@Price)";
			var parameters = new SqlParameterBuilder()
				.AddNInt("type_ID",model.type_ID)
				.AddNInt("company_ID", model.company_ID)
				.AddNVarchar("ProductName", 50, model.ProductName)
				.AddNullableInt("Price",model.Price)
				.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		private bool ProductExists(string ProductName)
		{
			string sql = @"SELECT Count(*) as count FROM Products WHERE ProductName = @ProductName";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("ProductName", 50, ProductName)
				.Build();
			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}
		public void Update(ProductVM model)
		{
			bool isExists = ProductExists_U(model);
			if (isExists) throw new Exception("商品已重複");
			string sql = @"UPDATE Products
			SET type_ID=@type_ID, company_ID = @company_ID,ProductName = @ProductName,Price = @Price WHERE ID =@ID";
			var parameters = new SqlParameterBuilder()
				.AddNInt("ID", model.Id)
				.AddNInt("type_ID",model.type_ID)
				.AddNInt("company_ID", model.company_ID)
				.AddNVarchar("ProductName", 50, model.ProductName)
				.AddNullableInt("Price", model.Price)
				.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		private bool ProductExists_U(ProductVM model)
		{
			string sql = @"SELECT Count(*) as count FROM Products WHERE ProductName = @ProductName and ID != @ID";
			var parameters = new SqlParameterBuilder()
				.AddNInt("ID",model.Id)
				.AddNVarchar("ProductName", 50, model.ProductName)
				.Build();
			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}
		//internal bool Authenticate(LoginVM model)
		//{
		//	var user = Get(model.Account);
		//	if (user == null) return false;//找不到符合的帳號
		//	return (user.Password == model.Password);
		//}
		public ProductindexVM Get(string ProductName)
		{
			string sql = "SELECT * FROM Products WHERE ProductName = @ProductName";
			var parameter = new SqlParameterBuilder()
				.AddNVarchar("ProductName", 50, ProductName).Build();
			DataTable data = new SqlDbHelper("default").Select(sql, parameter);
			if (data.Rows.Count == 0)
			{
				return null;
			}
			//將找到的一筆紀錄由DataTable 轉換到UserVM
			return ToProductVM(data.Rows[0]);
		}
		private ProductindexVM ToProductVM(DataRow row)
		{
			return new ProductindexVM
			{
				Id = row.Field<int>("id"),
				type_ID = row.Field<int>("type_ID"),
				company_ID = row.Field<int>("company_ID"),
				ProductName = row.Field<string>("ProductName"),
				Price = row.Field<int>("Price")
			};
		}
	}
}
