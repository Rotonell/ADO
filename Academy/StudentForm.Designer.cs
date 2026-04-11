namespace Academy
{
	partial class StudentForm
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
			this.cbGroup = new System.Windows.Forms.ComboBox();
			this.labelGroup = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// tbLastName
			// 
			this.tbLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			// 
			// tbFirstName
			// 
			this.tbFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			// 
			// tbMiddleName
			// 
			this.tbMiddleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			// 
			// tbEmail
			// 
			this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			// 
			// tbPhone
			// 
			this.tbPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			// 
			// cbGroup
			// 
			this.cbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbGroup.FormattingEnabled = true;
			this.cbGroup.Location = new System.Drawing.Point(134, 239);
			this.cbGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbGroup.Name = "cbGroup";
			this.cbGroup.Size = new System.Drawing.Size(233, 38);
			this.cbGroup.TabIndex = 14;
			this.cbGroup.SelectedIndexChanged += new System.EventHandler(this.cbGroup_SelectedIndexChanged);
			// 
			// labelGroup
			// 
			this.labelGroup.AutoSize = true;
			this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelGroup.Location = new System.Drawing.Point(9, 237);
			this.labelGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelGroup.Name = "labelGroup";
			this.labelGroup.Size = new System.Drawing.Size(111, 31);
			this.labelGroup.TabIndex = 15;
			this.labelGroup.Text = "Группа:";
			this.labelGroup.Click += new System.EventHandler(this.labelGroup_Click);
			// 
			// StudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(876, 427);
			this.Controls.Add(this.labelGroup);
			this.Controls.Add(this.cbGroup);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "StudentForm";
			this.Text = "StudentForm";
			this.Load += new System.EventHandler(this.StudentForm_Load);
			this.Controls.SetChildIndex(this.tbLastName, 0);
			this.Controls.SetChildIndex(this.tbFirstName, 0);
			this.Controls.SetChildIndex(this.tbMiddleName, 0);
			this.Controls.SetChildIndex(this.dtpBirthDate, 0);
			this.Controls.SetChildIndex(this.pbPhoto, 0);
			this.Controls.SetChildIndex(this.tbEmail, 0);
			this.Controls.SetChildIndex(this.tbPhone, 0);
			this.Controls.SetChildIndex(this.cbGroup, 0);
			this.Controls.SetChildIndex(this.labelGroup, 0);
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbGroup;
		private System.Windows.Forms.Label labelGroup;
	}
}