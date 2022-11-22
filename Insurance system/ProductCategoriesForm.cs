using Insurance_system.Model.ViewModel;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insurance_system
{
	public partial class ProductCategoriesForm : Form
	{
		
		ProductCategoryVM[] categories;
		public ProductCategoriesForm()
		{
			InitializeComponent();
			DisplayProductCateories();
		}
		private void DisplayProductCateories()
		{
			string sql = "SELECT * FROM [Type of insurance] ORDER BY ID ";
			categories = new SqlDbHelper("default").Select(sql, null)
				.AsEnumerable().Select(x => ToProductCategoryVM(x)).ToArray();

			BindData(categories);
		}

		private ProductCategoryVM ToProductCategoryVM(DataRow x)
		{
			return new ProductCategoryVM
			{
				Id = x.Field<int>("ID"),
				Name = x.Field<string>("Name"),
			};
		}

		private void BindData(ProductCategoryVM[] model)
		{
			dataGridView1.DataSource = model;
		}
		private void Addnewbutton_Click(object sender, EventArgs e)
		{
			var frm = new CreateProductCategoryForm();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayProductCateories();
			}
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindx = e.RowIndex;
			if (rowindx < 0) return;
			ProductCategoryVM row = categories[rowindx];//使用者點到的那筆紀錄
			int id = row.Id;//使用者點到的那一筆紀錄的id值
			//把id傳給編輯表單的建構函數
			  var frm = new EditProductCategoryForm(id);
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayProductCateories();
			}
		}
	}
}
