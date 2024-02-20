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
            this.ucThongTinGV = new QuanLyHocSinh.UCThongTin();
            this.SuspendLayout();
            // 
            // ucThongTinGV
            // 
            this.ucThongTinGV.LblPhone = null;
            this.ucThongTinGV.Location = new System.Drawing.Point(12, 12);
            this.ucThongTinGV.Name = "ucThongTinGV";
            this.ucThongTinGV.RdbMen = null;
            this.ucThongTinGV.RdbWoman = null;
            this.ucThongTinGV.Size = new System.Drawing.Size(883, 455);
            this.ucThongTinGV.TabIndex = 0;
            this.ucThongTinGV.TxtEmail = null;
            this.ucThongTinGV.TxtPhone = null;
            // 
            // frmGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 480);
            this.Controls.Add(this.ucThongTinGV);
            this.Name = "frmGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FGiaoVien";
            this.Load += new System.EventHandler(this.FGiaoVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCThongTin ucThongTinGV;
    }
}