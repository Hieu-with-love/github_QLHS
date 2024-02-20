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
            ucThongTinHS.BtnAdd1.Click += btnAdd_Click;
            ucThongTinHS.BtnRemove1.Click += btnRemove_Click;
            ucThongTinHS.BtnEdit1.Click += btnEdit_Click;
            ucThongTinHS.DgvInfo1.CellDoubleClick += dgvHS_CellContentDoubleClick;
        }
        // Nếu code như bình thường, chỉ có một xíu form về học sinh này.
        // Thì ta chỉ cần một DB về HocSinh

        private void FHocSinh_Load(object sender, EventArgs e)
        {
            ucThongTinHS.DgvInfo1.DataSource = hsDAO.LoadDataTableForHS();
            ucThongTinHS.DgvInfo1.Columns["Id"].HeaderText = "Identity";
            ucThongTinHS.DgvInfo1.Columns["hoten"].HeaderText = "Họ tên";
            ucThongTinHS.DgvInfo1.Columns["diachi"].HeaderText = "Địa chỉ";
            ucThongTinHS.DgvInfo1.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            ucThongTinHS.DgvInfo1.Columns["email"].HeaderText = "Email";
            ucThongTinHS.DgvInfo1.Columns["phone"].HeaderText = "Số điện thoại";
            ucThongTinHS.DgvInfo1.Columns["gioitinh"].HeaderText = "Giới tính";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string gt = ucThongTinHS.RdbWoman1.Checked ? "1" : "0";
            HocSinh hs = new HocSinh(ucThongTinHS.TxtId1.Text, ucThongTinHS.TxtName1.Text, ucThongTinHS.TxtAddress1.Text, ucThongTinHS.DtpBirthday1.Value, ucThongTinHS.TxtEmail1.Text, ucThongTinHS.TxtPhone1.Text, gt); 
            hsDAO.AddHs(hs);
            ucThongTinHS.DgvInfo1.DataSource = hsDAO.LoadDataTableForHS();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string gt = ucThongTinHS.RdbWoman1.Checked ? "1" : "0";
            HocSinh hs = new HocSinh(ucThongTinHS.TxtId1.Text, ucThongTinHS.TxtName1.Text, ucThongTinHS.TxtAddress1.Text, ucThongTinHS.DtpBirthday1.Value, ucThongTinHS.TxtEmail1.Text, ucThongTinHS.TxtPhone1.Text, gt);
            hsDAO.RemoveHs(hs);
            ucThongTinHS.DgvInfo1.DataSource = hsDAO.LoadDataTableForHS();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string gt = ucThongTinHS.RdbWoman.Checked ? "1" : "0";
            HocSinh hs = new HocSinh(ucThongTinHS.TxtId1.Text, ucThongTinHS.TxtName1.Text, ucThongTinHS.TxtAddress1.Text, ucThongTinHS.DtpBirthday1.Value, ucThongTinHS.TxtEmail1.Text, ucThongTinHS.TxtPhone1.Text, gt);
            hsDAO.EditHs(hs);
            ucThongTinHS.DgvInfo1.DataSource = hsDAO.LoadDataTableForHS();
        }

        private void dgvHS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ucThongTinHS.TxtId1.Text = ucThongTinHS.DgvInfo1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                ucThongTinHS.TxtName1.Text = ucThongTinHS.DgvInfo1.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
                ucThongTinHS.TxtAddress1.Text = ucThongTinHS.DgvInfo1.Rows[e.RowIndex].Cells["diachi"].Value.ToString();
                ucThongTinHS.DtpBirthday1.Text = ucThongTinHS.DgvInfo1.Rows[e.RowIndex].Cells["ngaysinh"].Value.ToString();
                ucThongTinHS.TxtEmail1.Text = ucThongTinHS.DgvInfo1.Rows[e.RowIndex].Cells["email"].Value.ToString();
                ucThongTinHS.TxtPhone1.Text = ucThongTinHS.DgvInfo1.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                if (ucThongTinHS.DgvInfo1.Rows[e.RowIndex].Cells["gioitinh"].Value.ToString()=="1")
                {
                    ucThongTinHS.RdbWoman1.Checked = true;
                    ucThongTinHS.RdbMen1.Checked = false;
                }
                else
                {
                    ucThongTinHS.RdbWoman1.Checked = false;
                    ucThongTinHS.RdbMen1.Checked = true;
                }
            }
        }

    }
}
