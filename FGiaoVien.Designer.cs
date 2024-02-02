namespace QuanLyHocSinh
{
    partial class frmGV
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvGV = new System.Windows.Forms.DataGridView();
            this.grbGV = new System.Windows.Forms.GroupBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.rdbMen = new System.Windows.Forms.RadioButton();
            this.rdbWoman = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).BeginInit();
            this.grbGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(163, 481);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 46);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(269, 481);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 46);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(60, 481);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 46);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvGV
            // 
            this.dgvGV.AllowUserToAddRows = false;
            this.dgvGV.AllowUserToDeleteRows = false;
            this.dgvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGV.Location = new System.Drawing.Point(401, 61);
            this.dgvGV.Name = "dgvGV";
            this.dgvGV.ReadOnly = true;
            this.dgvGV.RowHeadersWidth = 51;
            this.dgvGV.RowTemplate.Height = 24;
            this.dgvGV.Size = new System.Drawing.Size(569, 480);
            this.dgvGV.TabIndex = 6;
            this.dgvGV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGV_CellContentDoubleClick);
            // 
            // grbGV
            // 
            this.grbGV.Controls.Add(this.rdbWoman);
            this.grbGV.Controls.Add(this.txtPhone);
            this.grbGV.Controls.Add(this.rdbMen);
            this.grbGV.Controls.Add(this.txtEmail);
            this.grbGV.Controls.Add(this.lblPhone);
            this.grbGV.Controls.Add(this.lblEmail);
            this.grbGV.Controls.Add(this.lblSex);
            this.grbGV.Controls.Add(this.dtpBirthday);
            this.grbGV.Controls.Add(this.txtName);
            this.grbGV.Controls.Add(this.txtAddress);
            this.grbGV.Controls.Add(this.txtId);
            this.grbGV.Controls.Add(this.lblBirthday);
            this.grbGV.Controls.Add(this.lblAddress);
            this.grbGV.Controls.Add(this.lblName);
            this.grbGV.Controls.Add(this.lblId);
            this.grbGV.Location = new System.Drawing.Point(12, 54);
            this.grbGV.Name = "grbGV";
            this.grbGV.Size = new System.Drawing.Size(383, 403);
            this.grbGV.TabIndex = 5;
            this.grbGV.TabStop = false;
            this.grbGV.Text = "Thông tin giáo viên";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(121, 344);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(235, 22);
            this.dtpBirthday.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(121, 150);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(235, 22);
            this.txtAddress.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(121, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(235, 22);
            this.txtId.TabIndex = 4;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(12, 349);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(67, 16);
            this.lblBirthday.TabIndex = 3;
            this.lblBirthday.Text = "Ngày sinh";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 153);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(47, 16);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Họ tên";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 56);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(121, 293);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(235, 22);
            this.txtPhone.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 245);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(12, 203);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(54, 16);
            this.lblSex.TabIndex = 10;
            this.lblSex.Text = "Giới tính";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 296);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(66, 16);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Điện thoại";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 248);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // rdbMen
            // 
            this.rdbMen.AutoSize = true;
            this.rdbMen.Location = new System.Drawing.Point(121, 198);
            this.rdbMen.Name = "rdbMen";
            this.rdbMen.Size = new System.Drawing.Size(57, 20);
            this.rdbMen.TabIndex = 15;
            this.rdbMen.TabStop = true;
            this.rdbMen.Text = "Nam";
            this.rdbMen.UseVisualStyleBackColor = true;
            // 
            // rdbWoman
            // 
            this.rdbWoman.AutoSize = true;
            this.rdbWoman.Location = new System.Drawing.Point(211, 198);
            this.rdbWoman.Name = "rdbWoman";
            this.rdbWoman.Size = new System.Drawing.Size(45, 20);
            this.rdbWoman.TabIndex = 16;
            this.rdbWoman.TabStop = true;
            this.rdbWoman.Text = "Nữ";
            this.rdbWoman.UseVisualStyleBackColor = true;
            // 
            // frmGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvGV);
            this.Controls.Add(this.grbGV);
            this.Name = "frmGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FGiaoVien";
            this.Load += new System.EventHandler(this.FGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).EndInit();
            this.grbGV.ResumeLayout(false);
            this.grbGV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvGV;
        private System.Windows.Forms.GroupBox grbGV;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.RadioButton rdbWoman;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.RadioButton rdbMen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSex;
    }
}