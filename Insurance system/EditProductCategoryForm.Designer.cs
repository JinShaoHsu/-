namespace Insurance_system
{
	partial class EditProductCategoryForm
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
			this.Updatebutton = new System.Windows.Forms.Button();
			this.Deletebutton = new System.Windows.Forms.Button();
			this.nameTextbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Updatebutton
			// 
			this.Updatebutton.Location = new System.Drawing.Point(68, 122);
			this.Updatebutton.Name = "Updatebutton";
			this.Updatebutton.Size = new System.Drawing.Size(75, 23);
			this.Updatebutton.TabIndex = 7;
			this.Updatebutton.Text = "Update";
			this.Updatebutton.UseVisualStyleBackColor = true;
			this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
			// 
			// Deletebutton
			// 
			this.Deletebutton.Location = new System.Drawing.Point(149, 122);
			this.Deletebutton.Name = "Deletebutton";
			this.Deletebutton.Size = new System.Drawing.Size(75, 23);
			this.Deletebutton.TabIndex = 8;
			this.Deletebutton.Text = "Delete";
			this.Deletebutton.UseVisualStyleBackColor = true;
			this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
			// 
			// nameTextbox
			// 
			this.nameTextbox.Location = new System.Drawing.Point(125, 71);
			this.nameTextbox.Name = "nameTextbox";
			this.nameTextbox.Size = new System.Drawing.Size(100, 22);
			this.nameTextbox.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(66, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 10;
			this.label1.Text = "分類名稱";
			// 
			// EditProductCategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 205);
			this.Controls.Add(this.Updatebutton);
			this.Controls.Add(this.Deletebutton);
			this.Controls.Add(this.nameTextbox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MinimizeBox = false;
			this.Name = "EditProductCategoryForm";
			this.Text = "編輯保險種類";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Updatebutton;
		private System.Windows.Forms.Button Deletebutton;
		private System.Windows.Forms.TextBox nameTextbox;
		private System.Windows.Forms.Label label1;
	}
}