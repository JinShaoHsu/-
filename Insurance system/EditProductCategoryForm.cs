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
	public partial class EditProductCategoryForm : Form
	{
		private int id;
		public EditProductCategoryForm(int id)
		{
			InitializeComponent();
			this.id = id;
			BindData(id);
		}
		private void BindData(int id)
		{
			string sql = "SELECT * FROM [Type of insurance] WHERE Id = @Id";
			var parameter = new SqlParameterBuilder().AddNInt("Id", id).Build();
			DataTable data = new SqlDbHelper("default").Select(sql, parameter);
			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉,找不到要編輯的紀錄");
				this.DialogResult = DialogResult.OK;
				this.Close();
				return;
			}
			//將欄位放在控制向裡
			DataRow row = data.Rows[0];
			nameTextbox.Text = row.Field<string>("Name");
		}

		private void Updatebutton_Click(object sender, EventArgs e)
		{
			string categoryName = nameTextbox.Text;

			

			string sql = @"UPDATE Type of insurance SET Name = @Name,
							WHERE Id = @Id ORDER BY ID";
			var parameters = new SqlParameterBuilder().AddNVarchar("CategoryName", 50, categoryName)
				.AddNInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			//MessageBox.Show("紀錄已新增");
			this.DialogResult = DialogResult.OK;
		}

		private void Deletebutton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您真的要刪除嗎?", "刪除紀錄", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{ return; }

			string sql = @"DELETE FROM [Type of insurance] WHERE Id = @Id";
			var parameters = new SqlParameterBuilder()
				.AddNInt("Id", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			//MessageBox.Show("紀錄已新增");
			this.DialogResult = DialogResult.OK;
		}
	}
}
