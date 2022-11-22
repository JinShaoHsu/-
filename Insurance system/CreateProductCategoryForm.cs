using Insurance_system.Infra.Extensions;
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
	public partial class CreateProductCategoryForm : Form
	{
		public CreateProductCategoryForm()
		{
			InitializeComponent();
		}
		private void Savebutton_Click(object sender, EventArgs e)
		{
			string categoryName = nameTextbox.Text;

			string sql = @"INSERT INTO  [Type of insurance](Name)VALUES(@Name)";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Name", 50, categoryName)
				.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
			this.DialogResult = DialogResult.OK;

		}
	}
}
