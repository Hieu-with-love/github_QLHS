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
            dgvGV.DataSource = gvDAO.LoadDataForGV();
            dgvGV.Columns["id"].HeaderText = "Identity";
            dgvGV.Columns["hoten"].HeaderText = "Họ tên";
            dgvGV.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvGV.Columns["ngaysinh"].HeaderText = "Ngày sinh";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtId.Text, txtName.Text, txtAddress.Text, dtpBirthday.Value);
            gvDAO.AddGV(gv);
            dgvGV.DataSource = gvDAO.LoadDataForGV();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtId.Text, txtName.Text, txtAddress.Text, dtpBirthday.Value);
            gvDAO.RemoveGV(gv);
            dgvGV.DataSource = gvDAO.LoadDataForGV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(txtId.Text, txtName.Text, txtAddress.Text, dtpBirthday.Value);
            gvDAO.EditGV(gv);
            dgvGV.DataSource = gvDAO.LoadDataForGV();
        }

        private void dgvGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvGV.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtName.Text = dgvGV.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
                txtAddress.Text = dgvGV.Rows[e.RowIndex].Cells["diachi"].Value.ToString();
                dtpBirthday.Text = dgvGV.Rows[e.RowIndex].Cells["ngaysinh"].Value.ToString();

            }
        }
    }
}
