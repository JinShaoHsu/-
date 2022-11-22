namespace Insurance_system
{
	partial class EditProductForm
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
			this.pricetextBox = new System.Windows.Forms.TextBox();
			this.productnametextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Updatebutton = new System.Windows.Forms.Button();
			this.Deletebutton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.companycomboBox = new System.Windows.Forms.ComboBox();
			this.companyVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.typecomboBox = new System.Windows.Forms.ComboBox();
			this.productCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.companyVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// pricetextBox
			// 
			this.pricetextBox.Location = new System.Drawing.Point(160, 160);
			this.pricetextBox.Name = "pricetextBox";
			this.pricetextBox.Size = new System.Drawing.Size(142, 22);
			this.pricetextBox.TabIndex = 18;
			// 
			// productnametextBox
			// 
			this.productnametextBox.Location = new System.Drawing.Point(160, 123);
			this.productnametextBox.Name = "productnametextBox";
			this.productnametextBox.Size = new System.Drawing.Size(142, 22);
			this.productnametextBox.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(77, 170);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 19;
			this.label3.Text = "保費:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(77, 133);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 12);
			this.label2.TabIndex = 17;
			this.label2.Text = "商品名稱:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(77, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 15;
			this.label1.Text = "保險種類:";
			// 
			// Updatebutton
			// 
			this.Updatebutton.Location = new System.Drawing.Point(102, 216);
			this.Updatebutton.Name = "Updatebutton";
			this.Updatebutton.Size = new System.Drawing.Size(75, 23);
			this.Updatebutton.TabIndex = 12;
			this.Updatebutton.Text = "Update";
			this.Updatebutton.UseVisualStyleBackColor = true;
			this.Updatebutton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// Deletebutton
			// 
			this.Deletebutton.Location = new System.Drawing.Point(183, 216);
			this.Deletebutton.Name = "Deletebutton";
			this.Deletebutton.Size = new System.Drawing.Size(75, 23);
			this.Deletebutton.TabIndex = 13;
			this.Deletebutton.Text = "Delete";
			this.Deletebutton.UseVisualStyleBackColor = true;
			this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(77, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 12);
			this.label4.TabIndex = 15;
			this.label4.Text = "保險公司:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// companycomboBox
			// 
			this.companycomboBox.DataSource = this.companyVMBindingSource;
			this.companycomboBox.DisplayMember = "CompanyName";
			this.companycomboBox.FormattingEnabled = true;
			this.companycomboBox.Location = new System.Drawing.Point(160, 81);
			this.companycomboBox.Name = "companycomboBox";
			this.companycomboBox.Size = new System.Drawing.Size(142, 20);
			this.companycomboBox.TabIndex = 23;
			this.companycomboBox.ValueMember = "ID";
			// 
			// companyVMBindingSource
			// 
			this.companyVMBindingSource.DataSource = typeof(Insurance_system.Model.ViewModel.CompanyVM);
			// 
			// typecomboBox
			// 
			this.typecomboBox.DataSource = this.productCategoryVMBindingSource;
			this.typecomboBox.DisplayMember = "Name";
			this.typecomboBox.FormattingEnabled = true;
			this.typecomboBox.Location = new System.Drawing.Point(160, 46);
			this.typecomboBox.Name = "typecomboBox";
			this.typecomboBox.Size = new System.Drawing.Size(142, 20);
			this.typecomboBox.TabIndex = 22;
			this.typecomboBox.ValueMember = "Id";
			// 
			// productCategoryVMBindingSource
			// 
			this.productCategoryVMBindingSource.DataSource = typeof(Insurance_system.Model.ViewModel.ProductCategoryVM);
			// 
			// productVMBindingSource
			// 
			this.productVMBindingSource.DataSource = typeof(Insurance_system.Model.ViewModel.ProductVM);
			// 
			// EditProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(376, 305);
			this.Controls.Add(this.companycomboBox);
			this.Controls.Add(this.typecomboBox);
			this.Controls.Add(this.pricetextBox);
			this.Controls.Add(this.productnametextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Updatebutton);
			this.Controls.Add(this.Deletebutton);
			this.Name = "EditProductForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "編輯保險商品";
			this.Load += new System.EventHandler(this.EditProductForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.companyVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox pricetextBox;
		private System.Windows.Forms.TextBox productnametextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Updatebutton;
		private System.Windows.Forms.Button Deletebutton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ComboBox companycomboBox;
		private System.Windows.Forms.ComboBox typecomboBox;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource;
		private System.Windows.Forms.BindingSource companyVMBindingSource;
		private System.Windows.Forms.BindingSource productVMBindingSource;
	}
}