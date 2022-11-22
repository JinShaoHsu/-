namespace Insurance_system
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.客戶管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保險公司ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.保險分類ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.商品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客戶管理ToolStripMenuItem,
            this.保險公司ToolStripMenuItem,
            this.保險分類ToolStripMenuItem,
            this.商品管理ToolStripMenuItem,
            this.登出ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(809, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 客戶管理ToolStripMenuItem
			// 
			this.客戶管理ToolStripMenuItem.Name = "客戶管理ToolStripMenuItem";
			this.客戶管理ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.客戶管理ToolStripMenuItem.Text = "使用者管理";
			this.客戶管理ToolStripMenuItem.Click += new System.EventHandler(this.客戶管理ToolStripMenuItem_Click);
			// 
			// 保險公司ToolStripMenuItem
			// 
			this.保險公司ToolStripMenuItem.Name = "保險公司ToolStripMenuItem";
			this.保險公司ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.保險公司ToolStripMenuItem.Text = "保險公司";
			this.保險公司ToolStripMenuItem.Click += new System.EventHandler(this.保險公司ToolStripMenuItem_Click);
			// 
			// 保險分類ToolStripMenuItem
			// 
			this.保險分類ToolStripMenuItem.Name = "保險分類ToolStripMenuItem";
			this.保險分類ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.保險分類ToolStripMenuItem.Text = "保險分類";
			this.保險分類ToolStripMenuItem.Click += new System.EventHandler(this.保險分類ToolStripMenuItem_Click);
			// 
			// 商品管理ToolStripMenuItem
			// 
			this.商品管理ToolStripMenuItem.Name = "商品管理ToolStripMenuItem";
			this.商品管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.商品管理ToolStripMenuItem.Text = "商品管理";
			this.商品管理ToolStripMenuItem.Click += new System.EventHandler(this.商品管理ToolStripMenuItem_Click);
			// 
			// 登出ToolStripMenuItem
			// 
			this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
			this.登出ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.登出ToolStripMenuItem.Text = "登出";
			this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(809, 488);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.IsMdiContainer = true;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 客戶管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保險分類ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 保險公司ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 商品管理ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
	}
}