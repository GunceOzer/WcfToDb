namespace WcfToDb
{
	partial class Form1
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
			this.btnInsert = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtAge = new System.Windows.Forms.TextBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSelect = new System.Windows.Forms.Button();
			this.dgvPerson = new System.Windows.Forms.DataGridView();
			this.btnSelectAll = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
			this.SuspendLayout();
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(142, 142);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(100, 23);
			this.btnInsert.TabIndex = 0;
			this.btnInsert.Text = " Insert";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(185, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Id";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(426, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(651, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Age";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(142, 89);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 20);
			this.txtId.TabIndex = 4;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(393, 89);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 5;
			// 
			// txtAge
			// 
			this.txtAge.Location = new System.Drawing.Point(612, 89);
			this.txtAge.Name = "txtAge";
			this.txtAge.Size = new System.Drawing.Size(100, 20);
			this.txtAge.TabIndex = 6;
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(393, 142);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(100, 23);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(612, 142);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(100, 23);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(12, 258);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(113, 23);
			this.btnSelect.TabIndex = 9;
			this.btnSelect.Text = "Select Person By Id";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// dgvPerson
			// 
			this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPerson.Location = new System.Drawing.Point(142, 215);
			this.dgvPerson.Name = "dgvPerson";
			this.dgvPerson.Size = new System.Drawing.Size(570, 208);
			this.dgvPerson.TabIndex = 10;
			// 
			// btnSelectAll
			// 
			this.btnSelectAll.Location = new System.Drawing.Point(12, 317);
			this.btnSelectAll.Name = "btnSelectAll";
			this.btnSelectAll.Size = new System.Drawing.Size(113, 23);
			this.btnSelectAll.TabIndex = 11;
			this.btnSelectAll.Text = "Select All";
			this.btnSelectAll.UseVisualStyleBackColor = true;
			this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnSelectAll);
			this.Controls.Add(this.dgvPerson);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.txtAge);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnInsert);
			this.Name = "Form1";
			this.Text = "Person";
			((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.DataGridView dgvPerson;
		private System.Windows.Forms.Button btnSelectAll;
	}
}

