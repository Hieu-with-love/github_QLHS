using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyHocSinh
{
    public partial class frmHS : Form
    {
        HocSinhDAO hsDAO = new HocSinhDAO();
        public frmHS()
        {
            InitializeComponent();
        }
        // Nếu code như bình thường, chỉ có một xíu form về học sinh này.
        // Thì ta chỉ cần một DB về HocSinh

        private void FHocSinh_Load(object sender, EventArgs e)
        {
            ucThongTinHS.DgvInfo.DataSource = hsDAO.LoadDataTableForHS();
            ucThongTinHS.DgvInfo.Columns["Id"].HeaderText = "Identity";
            ucThongTinHS.DgvInfo.Columns["hoten"].HeaderText = "Họ tên";
            ucThongTinHS.DgvInfo.Columns["diachi"].HeaderText = "Địa chỉ";
            ucThongTinHS.DgvInfo.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            ucThongTinHS.DgvInfo.Columns["email"].HeaderText = "Email";
            ucThongTinHS.DgvInfo.Columns["phone"].HeaderText = "Số điện thoại";
            ucThongTinHS.DgvInfo.Columns["gioitinh"].HeaderText = "Giới tính";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string gt = ucThongTinHS.RdbWoman.Checked ? "1" : "0";
            HocSinh hs = new HocSinh(ucThongTinHS.TxtId.Text, ucThongTinHS.TxtName.Text, ucThongTinHS.TxtAddress.Text, ucThongTinHS.DtpBirthday.Value, ucThongTinHS.TxtEmail.Text, ucThongTinHS.TxtPhone.Text, gt); 
            hsDAO.AddHs(hs);
            ucThongTinHS.DgvInfo.DataSource = hsDAO.LoadDataTableForHS();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string gt = ucThongTinHS.RdbWoman.Checked ? "1" : "0";
            HocSinh hs = new HocSinh(ucThongTinHS.TxtId.Text, ucThongTinHS.TxtName.Text, ucThongTinHS.TxtAddress.Text, ucThongTinHS.DtpBirthday.Value, ucThongTinHS.TxtEmail.Text, ucThongTinHS.TxtPhone.Text, gt);
            hsDAO.AddHs(hs);
            ucThongTinHS.DgvInfo.DataSource = hsDAO.LoadDataTableForHS();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string gt = ucThongTinHS.RdbWoman.Checked ? "1" : "0";
            HocSinh hs = new HocSinh(ucThongTinHS.TxtId.Text, ucThongTinHS.TxtName.Text, ucThongTinHS.TxtAddress.Text, ucThongTinHS.DtpBirthday.Value, ucThongTinHS.TxtEmail.Text, ucThongTinHS.TxtPhone.Text, gt);
            hsDAO.AddHs(hs);
            ucThongTinHS.DgvInfo.DataSource = hsDAO.LoadDataTableForHS();
        }

        private void dgvHS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ucThongTinHS.TxtId.Text = ucThongTinHS.DgvInfo.Rows[e.RowIndex].Cells["id"].Value.ToString();
                ucThongTinHS.TxtName.Text = ucThongTinHS.DgvInfo.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
                ucThongTinHS.TxtAddress.Text = ucThongTinHS.DgvInfo.Rows[e.RowIndex].Cells["diachi"].Value.ToString();
                ucThongTinHS.DtpBirthday.Text = ucThongTinHS.DgvInfo.Rows[e.RowIndex].Cells["ngaysinh"].Value.ToString();
                ucThongTinHS.TxtEmail.Text = ucThongTinHS.DgvInfo.Rows[e.RowIndex].Cells["email"].Value.ToString();
                ucThongTinHS.TxtPhone.Text = ucThongTinHS.DgvInfo.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                if (ucThongTinHS.DgvInfo.Rows[e.RowIndex].Cells["gioitinh"].Value.ToString()=="1")
                {
                    ucThongTinHS.RdbWoman.Checked = true;
                    ucThongTinHS.RdbMen.Checked = false;
                }
                else
                {
                    ucThongTinHS.RdbWoman.Checked = false;
                    ucThongTinHS.RdbMen.Checked = true;
                }
            }
        }

    }
}
