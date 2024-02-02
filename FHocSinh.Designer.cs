namespace QuanLyHocSinh
{
    partial class frmHS
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
            this.dgvHS = new System.Windows.Forms.DataGridView();
            this.grbHS = new System.Windows.Forms.GroupBox();
            this.rdbWoman = new System.Windows.Forms.RadioButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.rdbMen = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).BeginInit();
            this.grbHS.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(163, 460);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 46);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(269, 460);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 46);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(60, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 46);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvHS
            // 
            this.dgvHS.AllowUserToAddRows = false;
            this.dgvHS.AllowUserToDeleteRows = false;
            this.dgvHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHS.Location = new System.Drawing.Point(401, 40);
            this.dgvHS.Name = "dgvHS";
            this.dgvHS.ReadOnly = true;
            this.dgvHS.RowHeadersWidth = 51;
            this.dgvHS.RowTemplate.Height = 24;
            this.dgvHS.Size = new System.Drawing.Size(569, 480);
            this.dgvHS.TabIndex = 11;
            this.dgvHS.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHS_CellContentDoubleClick);
            // 
            // grbHS
            // 
            this.grbHS.Controls.Add(this.rdbWoman);
            this.grbHS.Controls.Add(this.txtPhone);
            this.grbHS.Controls.Add(this.rdbMen);
            this.grbHS.Controls.Add(this.txtEmail);
            this.grbHS.Controls.Add(this.lblPhone);
            this.grbHS.Controls.Add(this.lblEmail);
            this.grbHS.Controls.Add(this.lblSex);
            this.grbHS.Controls.Add(this.dtpBirthday);
            this.grbHS.Controls.Add(this.txtName);
            this.grbHS.Controls.Add(this.txtAddress);
            this.grbHS.Controls.Add(this.txtId);
            this.grbHS.Controls.Add(this.lblBirthday);
            this.grbHS.Controls.Add(this.lblAddress);
            this.grbHS.Controls.Add(this.lblName);
            this.grbHS.Controls.Add(this.lblId);
            this.grbHS.Location = new System.Drawing.Point(12, 33);
            this.grbHS.Name = "grbHS";
            this.grbHS.Size = new System.Drawing.Size(383, 403);
            this.grbHS.TabIndex = 10;
            this.grbHS.TabStop = false;
            this.grbHS.Text = "Thông tin học sinh";
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
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(121, 293);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(235, 22);
            this.txtPhone.TabIndex = 14;
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
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 245);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 22);
            this.txtEmail.TabIndex = 12;
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
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(12, 203);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(54, 16);
            this.lblSex.TabIndex = 10;
            this.lblSex.Text = "Giới tính";
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
            // frmHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvHS);
            this.Controls.Add(this.grbHS);
            this.Name = "frmHS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHocSinh";
            this.Load += new System.EventHandler(this.FHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHS)).EndInit();
            this.grbHS.ResumeLayout(false);
            this.grbHS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvHS;
        private System.Windows.Forms.GroupBox grbHS;
        private System.Windows.Forms.RadioButton rdbWoman;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.RadioButton rdbMen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
    }
}

