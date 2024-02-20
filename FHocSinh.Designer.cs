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
            this.ucThongTinHS = new QuanLyHocSinh.UCThongTin();
            this.SuspendLayout();
            // 
            // ucThongTinHS
            // 
            this.ucThongTinHS.LblPhone = null;
            this.ucThongTinHS.Location = new System.Drawing.Point(12, 12);
            this.ucThongTinHS.Name = "ucThongTinHS";
            this.ucThongTinHS.RdbMen = null;
            this.ucThongTinHS.RdbWoman = null;
            this.ucThongTinHS.Size = new System.Drawing.Size(883, 455);
            this.ucThongTinHS.TabIndex = 0;
            this.ucThongTinHS.TxtEmail = null;
            this.ucThongTinHS.TxtPhone = null;
            // 
            // frmHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 479);
            this.Controls.Add(this.ucThongTinHS);
            this.Name = "frmHS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHocSinh";
            this.Load += new System.EventHandler(this.FHocSinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCThongTin ucThongTinHS;
    }
}

