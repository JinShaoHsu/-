using Insurance_system.Model.Servers;
using Insurance_system.Model.ViewModel;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insurance_system
{
	public partial class ProductForm : Form
	{
		private ProductindexVM[] products = null;
		public ProductForm()
		{
			InitializeComponent();
			InitForm();
			DisplayProducts();
		}
		private void DisplayProducts()
		{
			int typecateory = ((ProductindexVM)comboBox1.SelectedItem).type_ID;
			products = new productservies().GetAll(typecateory).ToArray();
			BindData(products);
		}
		
		private void BindData(ProductindexVM[] data)
		{
			dataGridView1.DataSource = data;
		}
		private ProductindexVM ToProductIndexVM(DataRow row)
		{
			return new ProductindexVM
			{
				Id = row.Field<int>("ID"),
				//type_ID = row.Field<int>("type_ID"),
				//company_ID = row.Field<int>("company_ID"),
				ProductName = row.Field<string>("ProductName"),
				Price = row.Field<int>("Price"),
				Name = row.Field<string>("Name"),
				CompanyName = row.Field<string>("CompanyName")
			};
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindx = e.RowIndex;
			if (rowindx < 0) return;
			ProductindexVM row = this.products[rowindx];
			//使用者點到的那筆紀錄
			int id = row.Id;
			//使用者點到的那一筆紀錄的id值
			//把id傳給編輯表單的建構函數
			var frm = new EditProductForm(id);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayProducts();
			}
		}
		private void Addnewbutton_Click(object sender, EventArgs e)
		{
			var frm = new CreateProductForm();
			//frm.Show();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayProducts();
			}
		}
		private void Searchbutton1_Click(object sender, EventArgs e)
		{
			DisplayProducts();
		}
		private void InitForm()//下拉式清單
		{
			
			//設定 comboBox property
			comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
			comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems; 

			//Prepend 是在清單上面+1
			//Apend是在清單下面+1
			var sql = "select* from [dbo].[Type of insurance]";
			//var sql = "SELECT Distinct t.Name FROM Products p join [Type of insurance] t on t.ID = p.type_ID join [Insurance Company] c on c.ID = p.company_ID";
			var dbHelper = new SqlDbHelper("default");
			var types = dbHelper.Select(sql, null).AsEnumerable().Select(row => ToCategoryVM(row)).Prepend(new ProductindexVM { type_ID = 0, Name = String.Empty }).ToList();
			//List<ProductindexVM> categories = dbHelper.Select(sql, null).AsEnumerable().Select(row => ToCategoryVM(row))
			//	//.Prepend(new ProductindexVM { Id = 0, ProductName = String.Empty })
			//	.ToList();
			this.comboBox1.DataSource = types;
		}
		private ProductindexVM ToCategoryVM(DataRow row)
		{
			return new ProductindexVM
			{
				type_ID = row.Field<int>("ID"),
				Name = row.Field<string>("Name"),
			};
		}
	}
}
