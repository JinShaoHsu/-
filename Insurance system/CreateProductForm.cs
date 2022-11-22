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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Insurance_system
{
	public partial class CreateProductForm : Form
	{
		private int id;
		public CreateProductForm()
		{
			InitializeComponent();
			InitFrom();
		}
		private void InitFrom()
		{
			typecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			//typecomboBox.DropDownStyle = ComboBoxStyle.DropDown;
			//typecomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			//typecomboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			companycomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			//companycomboBox.DropDownStyle = ComboBoxStyle.DropDown;
			//companycomboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			//companycomboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			string sqlt = @"select * from [dbo].[Type of insurance]";
			string sqlc = @"select * from [dbo].[Insurance Company]";
			var dbhelper = new SqlDbHelper("default");
			List<ProductVM> resultt = dbhelper.Select(sqlt,null)
				.AsEnumerable().Select(row=>ToTypeVM(row)).ToList();
			List<ProductVM> resultc = dbhelper.Select(sqlc, null)
				.AsEnumerable().Select(row => ToCompanyVM(row)).ToList();

			this.typecomboBox.DataSource = resultt;
			this.companycomboBox.DataSource = resultc;
		}

		private ProductVM ToTypeVM(DataRow row)
		{
			return new ProductVM
			{
				Id = row.Field<int>("ID"),
				Name = row.Field<string>("Name"),
			};
		}
		private ProductVM ToCompanyVM(DataRow row)
		{
			return new ProductVM
			{
				Id = row.Field<int>("ID"),
				CompanyName = row.Field<string>("CompanyName"),
			};
		}

		private void Savebutton_Click(object sender, EventArgs e)
		{
			//取得表單各欄位值
			int type_ID = ((ProductVM)this.typecomboBox.SelectedItem).Id;
			int company_ID = ((ProductVM)this.companycomboBox.SelectedItem).Id;
			string ProductName = productnametextBox.Text;
			int? Price = pricetextBox.Text.ToNullableInt();
			

			//將它們繫結到ViewModel
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
				new productservies().Create(model);
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗,原因:" + ex.Message);
			}
		}
	}
}
