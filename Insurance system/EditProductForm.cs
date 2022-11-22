using Insurance_system.Infra.Extensions;
using Insurance_system.Model.Servers;
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
	public partial class EditProductForm : Form
	{
		private int id;
		public EditProductForm(int id)
		{
			InitializeComponent();
			this.id = id;
			//BindData(id);                         // 不要亂寫喔~~!!
			InitForm();
		}
		private void EditProductForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}
		private void BindData(int id)
		{
			string sql = "SELECT * FROM Products WHERE ID = @ID";
			var parameter = new SqlParameterBuilder()
							.AddNInt("ID", id)
							.Build();
			DataTable data = new SqlDbHelper("default")
							.Select(sql, parameter);
			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉,找不到要編輯的紀錄");
				this.DialogResult = DialogResult.OK;
				return;
			}
			ProductVM model = ToProductVM(data.Rows[0]);
			typecomboBox.SelectedItem = ((List<ProductCategoryVM>)typecomboBox.DataSource).FirstOrDefault(x => x.Id == model.type_ID);
			companycomboBox.SelectedItem = ((List<CompanyVM>)companycomboBox.DataSource).FirstOrDefault(x => x.ID == model.company_ID);
			productnametextBox.Text = model.ProductName;
			pricetextBox.Text = model.Price.ToString();
		}
		private void InitForm()
		{
			typecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			companycomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			string sqlt = @"select * from [dbo].[Type of insurance]";
			string sqlc = @"select * from [dbo].[Insurance Company]";
			var dbHelper = new SqlDbHelper("default");
			List<ProductCategoryVM> categories = dbHelper.Select(sqlt, null).AsEnumerable()
				.Select(row => ToTypeVM(row))
				.ToList();
			List<CompanyVM> resultc = dbHelper.Select(sqlc, null)
				.AsEnumerable().Select(row => ToCompanyVM(row)).ToList();
			this.typecomboBox.DataSource = categories;
			this.companycomboBox.DataSource = resultc;
		}
		private ProductCategoryVM ToTypeVM(DataRow row)
		{
			return new ProductCategoryVM
			{
				Id = row.Field<int>("ID"),
				Name = row.Field<string>("Name"),
			};
		}
		private CompanyVM ToCompanyVM(DataRow row)
		{
			return new CompanyVM
			{
				ID = row.Field<int>("ID"),
				CompanyName = row.Field<string>("CompanyName"),
			};
		}
		private ProductVM ToProductVM(DataRow row)
		{
			return new ProductVM
			{
				Id = row.Field<int>("ID"),
				type_ID = row.Field<int>("type_ID"),
				company_ID = row.Field<int>("company_ID"),
				ProductName = row.Field<string>("ProductName"),
				Price =row.Field<int>("Price")
			};
		}
		private void updateButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			int type_ID = ((ProductCategoryVM)this.typecomboBox.SelectedItem).Id;
			int company_ID = ((CompanyVM)this.companycomboBox.SelectedItem).ID;
			string ProductName = productnametextBox.Text;
			int? Price = pricetextBox.Text.ToNullableInt();
			// 將它們繫結到ViewModel
			ProductVM model = new ProductVM
			{
				Id = id,
				type_ID = type_ID,
				company_ID = company_ID,
				ProductName = ProductName,
				Price = Price,
			};
			//針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"ProductName", productnametextBox},
				{"Price",pricetextBox},
			};
			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;
			//如果通過驗證,就新增紀錄
			try
			{
				new productservies().Update(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗,原因:" + ex.Message);
			}
		}
		private void Deletebutton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您真的要刪除嗎?", "刪除紀錄", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{ return; }

			string sql = @"DELETE FROM Products WHERE ID = @ID";
			var parameters = new SqlParameterBuilder()
				.AddNInt("ID", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			//MessageBox.Show("紀錄已新增");
			this.DialogResult = DialogResult.OK;
		}
		
	}
}
