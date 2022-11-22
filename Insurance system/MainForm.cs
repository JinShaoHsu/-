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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void 客戶管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new UserForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 保險分類ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new ProductCategoriesForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 保險公司ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new CompanyForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 商品管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new ProductForm();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}
	}
}
