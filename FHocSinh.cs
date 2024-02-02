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
            dgvHS.DataSource = hsDAO.LoadDataTableForHS();
            dgvHS.Columns["Id"].HeaderText = "Identity";
            dgvHS.Columns["hoten"].HeaderText = "Họ tên";
            dgvHS.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvHS.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvHS.Columns["email"].HeaderText = "Email";
            dgvHS.Columns["phone"].HeaderText = "Số điện thoại";
            dgvHS.Columns["gioitinh"].HeaderText = "Giới tính";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string gt = rdbWoman.Checked ? "1" : "0";
            HocSinh hs = new HocSinh(txtId.Text, txtName.Text, txtAddress.Text, dtpBirthday.Value, txtEmail.Text, txtPhone.Text, gt); 
            hsDAO.AddHs(hs);
            dgvHS.DataSource = hsDAO.LoadDataTableForHS();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string gt = rdbWoman.Checked ? "1" : "0";
            HocSinh hs = new HocSinh(txtId.Text, txtName.Text, txtAddress.Text, dtpBirthday.Value, txtEmail.Text, txtPhone.Text, gt); 
            hsDAO.RemoveHs(hs);
            dgvHS.DataSource = hsDAO.LoadDataTableForHS();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string gt = rdbWoman.Checked ? "1" : "0";
            HocSinh hs = new HocSinh(txtId.Text, txtName.Text, txtAddress.Text, dtpBirthday.Value, txtEmail.Text, txtPhone.Text, gt); 
            hsDAO.EditHs(hs);
            dgvHS.DataSource = hsDAO.LoadDataTableForHS();
        }

        private void dgvHS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtId.Text = dgvHS.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtName.Text = dgvHS.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
                txtAddress.Text = dgvHS.Rows[e.RowIndex].Cells["diachi"].Value.ToString();
                dtpBirthday.Text = dgvHS.Rows[e.RowIndex].Cells["ngaysinh"].Value.ToString();
                txtEmail.Text = dgvHS.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtPhone.Text = dgvHS.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                if (dgvHS.Rows[e.RowIndex].Cells["gioitinh"].Value.ToString()=="1")
                {
                    rdbWoman.Checked = true;
                    rdbMen.Checked = false;
                }
                else
                {
                    rdbWoman.Checked = false;
                    rdbMen.Checked = true;
                }
            }
        }

    }
}
