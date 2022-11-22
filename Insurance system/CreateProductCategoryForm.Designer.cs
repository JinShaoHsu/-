namespace Insurance_system
{
	partial class CreateProductCategoryForm
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
			this.Savebutton = new System.Windows.Forms.Button();
			this.nameTextbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Savebutton
			// 
			this.Savebutton.Location = new System.Drawing.Point(99, 109);
			this.Savebutton.Name = "Savebutton";
			this.Savebutton.Size = new System.Drawing.Size(75, 23);
			this.Savebutton.TabIndex = 7;
			this.Savebutton.Text = "Save";
			this.Savebutton.UseVisualStyleBackColor = true;
			this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
			// 
			// nameTextbox
			// 
			this.nameTextbox.Location = new System.Drawing.Point(126, 46);
			this.nameTextbox.Name = "nameTextbox";
			this.nameTextbox.Size = new System.Drawing.Size(100, 22);
			this.nameTextbox.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(59, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "分類名稱";
			// 
			// CreateProductCategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(291, 187);
			this.Controls.Add(this.Savebutton);
			this.Controls.Add(this.nameTextbox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MinimizeBox = false;
			this.Name = "CreateProductCategoryForm";
			this.Text = "新增保險種類";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Savebutton;
		private System.Windows.Forms.TextBox nameTextbox;
		private System.Windows.Forms.Label label1;
	}
}