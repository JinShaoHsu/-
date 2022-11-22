namespace Insurance_system
{
	partial class CreateUserForm
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
			this.NametextBox = new System.Windows.Forms.TextBox();
			this.AccounttextBox = new System.Windows.Forms.TextBox();
			this.PasswordtextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// Savebutton
			// 
			this.Savebutton.Location = new System.Drawing.Point(199, 177);
			this.Savebutton.Name = "Savebutton";
			this.Savebutton.Size = new System.Drawing.Size(75, 23);
			this.Savebutton.TabIndex = 13;
			this.Savebutton.Text = "Save";
			this.Savebutton.UseVisualStyleBackColor = true;
			this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
			// 
			// NametextBox
			// 
			this.NametextBox.Location = new System.Drawing.Point(132, 130);
			this.NametextBox.Name = "NametextBox";
			this.NametextBox.Size = new System.Drawing.Size(142, 22);
			this.NametextBox.TabIndex = 12;
			// 
			// AccounttextBox
			// 
			this.AccounttextBox.Location = new System.Drawing.Point(132, 40);
			this.AccounttextBox.Name = "AccounttextBox";
			this.AccounttextBox.Size = new System.Drawing.Size(142, 22);
			this.AccounttextBox.TabIndex = 10;
			// 
			// PasswordtextBox
			// 
			this.PasswordtextBox.Location = new System.Drawing.Point(132, 84);
			this.PasswordtextBox.Name = "PasswordtextBox";
			this.PasswordtextBox.Size = new System.Drawing.Size(142, 22);
			this.PasswordtextBox.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(49, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 16;
			this.label3.Text = "姓名:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 15;
			this.label2.Text = "密碼:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 14;
			this.label1.Text = "帳號:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 238);
			this.Controls.Add(this.Savebutton);
			this.Controls.Add(this.NametextBox);
			this.Controls.Add(this.AccounttextBox);
			this.Controls.Add(this.PasswordtextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MinimizeBox = false;
			this.Name = "CreateUserForm";
			this.Text = "編輯使用者";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Savebutton;
		private System.Windows.Forms.TextBox NametextBox;
		private System.Windows.Forms.TextBox AccounttextBox;
		private System.Windows.Forms.TextBox PasswordtextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}