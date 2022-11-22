namespace Insurance_system
{
	partial class CompanyForm
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.companyCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Addnewbutton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.companyCategoryVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.companyCategoryVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(49, 73);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(260, 178);
			this.dataGridView1.TabIndex = 5;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// companyNameDataGridViewTextBoxColumn
			// 
			this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
			this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
			this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
			this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// companyCategoryVMBindingSource
			// 
			this.companyCategoryVMBindingSource.DataSource = typeof(Insurance_system.Model.ViewModel.CompanyCategoryVM);
			// 
			// Addnewbutton
			// 
			this.Addnewbutton.Location = new System.Drawing.Point(218, 31);
			this.Addnewbutton.Name = "Addnewbutton";
			this.Addnewbutton.Size = new System.Drawing.Size(75, 23);
			this.Addnewbutton.TabIndex = 4;
			this.Addnewbutton.Text = "Add New";
			this.Addnewbutton.UseVisualStyleBackColor = true;
			this.Addnewbutton.Click += new System.EventHandler(this.Addnewbutton_Click);
			// 
			// CompanyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 302);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Addnewbutton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MinimizeBox = false;
			this.Name = "CompanyForm";
			this.Text = "保險公司";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.companyCategoryVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Addnewbutton;
		private System.Windows.Forms.BindingSource companyCategoryVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
	}
}