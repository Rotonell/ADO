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
			this.labelGroup = new System.Windows.Forms.Label();
			this.cbGroup = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// labelGroup
			// 
			this.labelGroup.AutoSize = true;
			this.labelGroup.Location = new System.Drawing.Point(13, 237);
			this.labelGroup.Name = "labelGroup";
			this.labelGroup.Size = new System.Drawing.Size(44, 16);
			this.labelGroup.TabIndex = 16;
			this.labelGroup.Text = "Group";
			// 
			// cbGroup
			// 
			this.cbGroup.FormattingEnabled = true;
			this.cbGroup.Location = new System.Drawing.Point(134, 237);
			this.cbGroup.Name = "cbGroup";
			this.cbGroup.Size = new System.Drawing.Size(233, 24);
			this.cbGroup.TabIndex = 17;
			// 
			// StudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 333);
			this.Controls.Add(this.cbGroup);
			this.Controls.Add(this.labelGroup);
			this.Name = "StudentForm";
			this.Text = "StudentForm";
			this.Load += new System.EventHandler(this.StudentForm_Load);
			this.Controls.SetChildIndex(this.labelGroup, 0);
			this.Controls.SetChildIndex(this.cbGroup, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelGroup;
		private System.Windows.Forms.ComboBox cbGroup;
	}
}