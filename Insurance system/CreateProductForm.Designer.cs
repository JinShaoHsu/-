namespace Insurance_system
{
	partial class CreateProductForm
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
			this.Savebutton = new System.Windows.Forms.Button();
			this.productVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.productnametextBox = new System.Windows.Forms.TextBox();
			this.pricetextBox = new System.Windows.Forms.TextBox();
			this.productCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.typecomboBox = new System.Windows.Forms.ComboBox();
			this.companycomboBox = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// Savebutton
			// 
			this.Savebutton.Location = new System.Drawing.Point(204, 236);
			this.Savebutton.Name = "Savebutton";
			this.Savebutton.Size = new System.Drawing.Size(75, 23);
			this.Savebutton.TabIndex = 10;
			this.Savebutton.Text = "Save";
			this.Savebutton.UseVisualStyleBackColor = true;
			this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
			// 
			// productVMBindingSource
			// 
			this.productVMBindingSource.DataSource = typeof(Insurance_system.Model.ViewModel.ProductVM);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 15;
			this.label1.Text = "保險種類:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(54, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 12);
			this.label2.TabIndex = 17;
			this.label2.Text = "商品名稱:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(54, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 12);
			this.label4.TabIndex = 15;
			this.label4.Text = "保險公司:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(54, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 19;
			this.label3.Text = "保費:";
			// 
			// productnametextBox
			// 
			this.productnametextBox.Location = new System.Drawing.Point(137, 117);
			this.productnametextBox.Name = "productnametextBox";
			this.productnametextBox.Size = new System.Drawing.Size(142, 22);
			this.productnametextBox.TabIndex = 16;
			// 
			// pricetextBox
			// 
			this.pricetextBox.Location = new System.Drawing.Point(137, 154);
			this.pricetextBox.Name = "pricetextBox";
			this.pricetextBox.Size = new System.Drawing.Size(142, 22);
			this.pricetextBox.TabIndex = 18;
			// 
			// productCategoryVMBindingSource
			// 
			this.productCategoryVMBindingSource.DataSource = typeof(Insurance_system.Model.ViewModel.ProductCategoryVM);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// typecomboBox
			// 
			this.typecomboBox.DataSource = this.productVMBindingSource;
			this.typecomboBox.DisplayMember = "Name";
			this.typecomboBox.FormattingEnabled = true;
			this.typecomboBox.Location = new System.Drawing.Point(137, 40);
			this.typecomboBox.Name = "typecomboBox";
			this.typecomboBox.Size = new System.Drawing.Size(142, 20);
			this.typecomboBox.TabIndex = 20;
			this.typecomboBox.ValueMember = "Id";
			// 
			// companycomboBox
			// 
			this.companycomboBox.DataSource = this.productVMBindingSource;
			this.companycomboBox.DisplayMember = "CompanyName";
			this.companycomboBox.FormattingEnabled = true;
			this.companycomboBox.Location = new System.Drawing.Point(137, 75);
			this.companycomboBox.Name = "companycomboBox";
			this.companycomboBox.Size = new System.Drawing.Size(142, 20);
			this.companycomboBox.TabIndex = 21;
			this.companycomboBox.ValueMember = "company_ID";
			// 
			// CreateProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 294);
			this.Controls.Add(this.companycomboBox);
			this.Controls.Add(this.typecomboBox);
			this.Controls.Add(this.Savebutton);
			this.Controls.Add(this.pricetextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.productnametextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MinimizeBox = false;
			this.Name = "CreateProductForm";
			this.Text = "新增保險商品";
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Savebutton;
		private System.Windows.Forms.BindingSource productVMBindingSource;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox productnametextBox;
		private System.Windows.Forms.TextBox pricetextBox;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ComboBox companycomboBox;
		private System.Windows.Forms.ComboBox typecomboBox;
	}
}