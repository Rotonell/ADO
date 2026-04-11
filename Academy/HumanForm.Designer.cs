namespace Academy
{
	partial class HumanForm
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
			this.labelLastName = new System.Windows.Forms.Label();
			this.labelFirstname = new System.Windows.Forms.Label();
			this.labelMiddleName = new System.Windows.Forms.Label();
			this.labelBirthDay = new System.Windows.Forms.Label();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.tbMiddleName = new System.Windows.Forms.TextBox();
			this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.pbPhoto = new System.Windows.Forms.PictureBox();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelPhone = new System.Windows.Forms.Label();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelID = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// labelLastName
			// 
			this.labelLastName.AutoSize = true;
			this.labelLastName.Location = new System.Drawing.Point(13, 16);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(69, 16);
			this.labelLastName.TabIndex = 0;
			this.labelLastName.Text = "Last name";
			// 
			// labelFirstname
			// 
			this.labelFirstname.AutoSize = true;
			this.labelFirstname.Location = new System.Drawing.Point(12, 58);
			this.labelFirstname.Name = "labelFirstname";
			this.labelFirstname.Size = new System.Drawing.Size(44, 16);
			this.labelFirstname.TabIndex = 1;
			this.labelFirstname.Text = "Name";
			// 
			// labelMiddleName
			// 
			this.labelMiddleName.AutoSize = true;
			this.labelMiddleName.Location = new System.Drawing.Point(12, 100);
			this.labelMiddleName.Name = "labelMiddleName";
			this.labelMiddleName.Size = new System.Drawing.Size(85, 16);
			this.labelMiddleName.TabIndex = 2;
			this.labelMiddleName.Text = "Middle name";
			// 
			// labelBirthDay
			// 
			this.labelBirthDay.AutoSize = true;
			this.labelBirthDay.Location = new System.Drawing.Point(12, 142);
			this.labelBirthDay.Name = "labelBirthDay";
			this.labelBirthDay.Size = new System.Drawing.Size(61, 16);
			this.labelBirthDay.TabIndex = 3;
			this.labelBirthDay.Text = "Birth Day";
			// 
			// tbLastName
			// 
			this.tbLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.tbLastName.Location = new System.Drawing.Point(134, 13);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(233, 22);
			this.tbLastName.TabIndex = 4;
			// 
			// tbFirstName
			// 
			this.tbFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.tbFirstName.Location = new System.Drawing.Point(134, 54);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(233, 22);
			this.tbFirstName.TabIndex = 5;
			// 
			// tbMiddleName
			// 
			this.tbMiddleName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbMiddleName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.tbMiddleName.Location = new System.Drawing.Point(134, 94);
			this.tbMiddleName.Name = "tbMiddleName";
			this.tbMiddleName.Size = new System.Drawing.Size(233, 22);
			this.tbMiddleName.TabIndex = 6;
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.Location = new System.Drawing.Point(134, 139);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.Size = new System.Drawing.Size(233, 22);
			this.dtpBirthDate.TabIndex = 8;
			// 
			// pbPhoto
			// 
			this.pbPhoto.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbPhoto.Location = new System.Drawing.Point(465, 16);
			this.pbPhoto.Name = "pbPhoto";
			this.pbPhoto.Size = new System.Drawing.Size(187, 215);
			this.pbPhoto.TabIndex = 9;
			this.pbPhoto.TabStop = false;
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Location = new System.Drawing.Point(525, 237);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
			this.buttonBrowse.TabIndex = 10;
			this.buttonBrowse.Text = "Browse";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click_1);
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(12, 180);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(45, 16);
			this.labelEmail.TabIndex = 11;
			this.labelEmail.Text = "E-mail";
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(13, 209);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(46, 16);
			this.labelPhone.TabIndex = 12;
			this.labelPhone.Text = "Phone";
			// 
			// tbEmail
			// 
			this.tbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.tbEmail.Location = new System.Drawing.Point(134, 180);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(233, 22);
			this.tbEmail.TabIndex = 13;
			// 
			// tbPhone
			// 
			this.tbPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.tbPhone.Location = new System.Drawing.Point(134, 209);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(233, 22);
			this.tbPhone.TabIndex = 14;
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(263, 295);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 15;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(361, 295);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 16;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Location = new System.Drawing.Point(13, 302);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(0, 16);
			this.labelID.TabIndex = 17;
			// 
			// HumanForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 330);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.tbEmail);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.buttonBrowse);
			this.Controls.Add(this.pbPhoto);
			this.Controls.Add(this.dtpBirthDate);
			this.Controls.Add(this.tbMiddleName);
			this.Controls.Add(this.tbFirstName);
			this.Controls.Add(this.tbLastName);
			this.Controls.Add(this.labelBirthDay);
			this.Controls.Add(this.labelMiddleName);
			this.Controls.Add(this.labelFirstname);
			this.Controls.Add(this.labelLastName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HumanForm";
			this.ShowInTaskbar = false;
			this.Text = "HumanForm";
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.Label labelFirstname;
		private System.Windows.Forms.Label labelMiddleName;
		private System.Windows.Forms.Label labelBirthDay;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		protected System.Windows.Forms.TextBox tbLastName;
		protected System.Windows.Forms.TextBox tbFirstName;
		protected System.Windows.Forms.TextBox tbMiddleName;
		protected System.Windows.Forms.DateTimePicker dtpBirthDate;
		protected System.Windows.Forms.PictureBox pbPhoto;
		protected System.Windows.Forms.TextBox tbEmail;
		protected System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.Label labelID;
	}
}