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
	public partial class CompanyForm : Form
	{
		CompanyCategoryVM[] categories;
		public CompanyForm()
		{
			InitializeComponent();
			DisplayCompanyCateories();
		}
		private void DisplayCompanyCateories()
		{
			string sql = "SELECT * FROM [dbo].[Insurance Company] ORDER BY ID ";
			categories = new SqlDbHelper("default").Select(sql, null)
				.AsEnumerable().Select(x => ToCompanyCategoryVM(x)).ToArray();

			BindData(categories);
		}

		private CompanyCategoryVM ToCompanyCategoryVM(DataRow x)
		{
			return new CompanyCategoryVM
			{
				ID = x.Field<int>("ID"),
				CompanyName = x.Field<string>("CompanyName"),
			};
		}

		private void BindData(CompanyCategoryVM[] model)
		{
			dataGridView1.DataSource = model;
		}
		private void Addnewbutton_Click(object sender, EventArgs e)
		{
			var frm = new CreateCompanyForm();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayCompanyCateories();
			}
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindx = e.RowIndex;
			if (rowindx < 0) return;
			CompanyCategoryVM row = categories[rowindx];//使用者點到的那筆紀錄
			int id = row.ID;//使用者點到的那一筆紀錄的id值
							//把id傳給編輯表單的建構函數
			var frm = new EditCompanyForm(id);
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayCompanyCateories();
			}
		}
	}
}
