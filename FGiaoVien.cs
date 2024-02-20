using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmGV : Form
    {
        GiaoVienDAO gvDAO = new GiaoVienDAO();
        public frmGV()
        {
            InitializeComponent();
        }

        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            ucThongTinGV.DgvInfo1.DataSource = gvDAO.LoadDataForGV();
            ucThongTinGV.DgvInfo1.Columns["id"].HeaderText = "Identity";
            ucThongTinGV.DgvInfo1.Columns["hoten"].HeaderText = "Họ tên";
            ucThongTinGV.DgvInfo1.Columns["diachi"].HeaderText = "Địa chỉ";
            ucThongTinGV.DgvInfo1.Columns["ngaysinh"].HeaderText = "Ngày sinh";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string gt = ucThongTinGV.RdbWoman.Checked ? "1" : "0";
            GiaoVien gv = new GiaoVien(ucThongTinGV.TxtId.Text, ucThongTinGV.TxtName.Text, ucThongTinGV.TxtAddress.Text, ucThongTinGV.DtpBirthday.Value, ucThongTinGV.TxtEmail.Text, ucThongTinGV.TxtPhone.Text, gt);
            gvDAO.AddGV(gv);
            ucThongTinGV.DgvInfo.DataSource = gvDAO.LoadDataForGV();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string gt = ucThongTinGV.RdbWoman.Checked ? "1" : "0";
            GiaoVien gv = new GiaoVien(ucThongTinGV.TxtId.Text, ucThongTinGV.TxtName.Text, ucThongTinGV.TxtAddress.Text, ucThongTinGV.DtpBirthday.Value, ucThongTinGV.TxtEmail.Text, ucThongTinGV.TxtPhone.Text, gt);
            gvDAO.AddGV(gv);
            ucThongTinGV.DgvInfo.DataSource = gvDAO.LoadDataForGV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string gt = ucThongTinGV.RdbWoman.Checked ? "1" : "0";
            GiaoVien gv = new GiaoVien(ucThongTinGV.TxtId.Text, ucThongTinGV.TxtName.Text, ucThongTinGV.TxtAddress.Text, ucThongTinGV.DtpBirthday.Value, ucThongTinGV.TxtEmail.Text, ucThongTinGV.TxtPhone.Text, gt);
            gvDAO.AddGV(gv);
            ucThongTinGV.DgvInfo.DataSource = gvDAO.LoadDataForGV();
        }

        private void dgvGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ucThongTinGV.TxtId.Text = ucThongTinGV.DgvInfo.Rows[e.RowIndex].Cells["id"].Value.ToString();
                ucThongTinGV.TxtName.Text = ucThongTinGV.DgvInfo.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
                ucThongTinGV.TxtAddress.Text = ucThongTinGV.DgvInfo.Rows[e.RowIndex].Cells["diachi"].Value.ToString();
                ucThongTinGV.DtpBirthday.Text = ucThongTinGV.DgvInfo.Rows[e.RowIndex].Cells["ngaysinh"].Value.ToString();
            }
        }
    }
}
