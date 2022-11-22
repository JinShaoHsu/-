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
	public partial class EditCompanyForm : Form
	{
		private int id;
		public EditCompanyForm(int id)
		{
			InitializeComponent();
			this.id = id;
			BindData(id);
		}
		private void BindData(int id)
		{
			string sql = "SELECT * FROM [dbo].[Insurance Company] WHERE ID = @ID";
			var parameter = new SqlParameterBuilder().AddNInt("ID", id).Build();
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
			nameTextbox.Text = row.Field<string>("CompanyName");
		}

		private void Updatebutton_Click(object sender, EventArgs e)
		{
			string CompantName = nameTextbox.Text;



			string sql = @"UPDATE [dbo].[Insurance Company] SET CompanyName = @CompanyName
							WHERE ID = @ID ";
			var parameters = new SqlParameterBuilder().AddNVarchar("CompanyName", 50, CompantName)
				.AddNInt("ID", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			//MessageBox.Show("紀錄已新增");
			this.DialogResult = DialogResult.OK;
		}

		private void Deletebutton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("您真的要刪除嗎?", "刪除紀錄", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{ return; }

			string sql = @"DELETE FROM [dbo].[Insurance Company] WHERE ID = @ID";
			var parameters = new SqlParameterBuilder()
				.AddNInt("ID", this.id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			//MessageBox.Show("紀錄已新增");
			this.DialogResult = DialogResult.OK;
		}
	}
}
