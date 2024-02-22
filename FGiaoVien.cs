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
            ucThongTinGV.BtnAdd1.Click += btnAdd_Click;
            ucThongTinGV.BtnRemove1.Click += btnRemove_Click;    
            ucThongTinGV.BtnEdit1.Click += btnEdit_Click;
            ucThongTinGV.DgvInfo1.CellDoubleClick += dgvGV_CellContentDoubleClick;
        }

        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            ucThongTinGV.DgvInfo1.DataSource = gvDAO.LoadDataForGV();
            ucThongTinGV.DgvInfo1.Columns["id"].HeaderText = "Identity";
            ucThongTinGV.DgvInfo1.Columns["hoten"].HeaderText = "Họ tên";
            ucThongTinGV.DgvInfo1.Columns["diachi"].HeaderText = "Địa chỉ";
            ucThongTinGV.DgvInfo1.Columns["gioitinh"].HeaderText = "Giới tính";
            ucThongTinGV.DgvInfo1.Columns["cmnd"].HeaderText = "CMND";
            ucThongTinGV.DgvInfo1.Columns["email"].HeaderText = "Email";
            ucThongTinGV.DgvInfo1.Columns["phone"].HeaderText = "Điện thoại";
            ucThongTinGV.DgvInfo1.Columns["ngaysinh"].HeaderText = "Ngày sinh";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string gt = ucThongTinGV.RdbWoman1.Checked ? "1" : "0";
            if (ucThongTinGV.CheckFielddNull())
            {
                MessageBox.Show("Có field rỗng. Kiểm tra lại");
            }
            else
            {
                if (ucThongTinGV.CheckEmail())
                {
                    MessageBox.Show("Chưa đúng định dạng [...@gmail.com]");
                }else if (ucThongTinGV.CheckPhone())
                {
                    MessageBox.Show("Số điện thoại sai ! Định dạng đúng: xxxx-xxx-xxx");
                }else if (ucThongTinGV.CheckAge())
                {
                    MessageBox.Show("Tuổi phải lớn hơn hoặc bằng 17");
                }
                else
                {
                    GiaoVien gv = new GiaoVien(ucThongTinGV.TxtId1.Text, ucThongTinGV.TxtName1.Text, ucThongTinGV.TxtAddress1.Text, ucThongTinGV.DtpBirthday1.Value, ucThongTinGV.TxtEmail1.Text, ucThongTinGV.TxtPhone1.Text, gt, ucThongTinGV.TxtCmnd1.Text);
                    gvDAO.AddGV(gv);
                    ucThongTinGV.DgvInfo1.DataSource = gvDAO.LoadDataForGV();
                }
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string gt = ucThongTinGV.RdbWoman1.Checked ? "1" : "0";
            GiaoVien gv = new GiaoVien(ucThongTinGV.TxtId1.Text, ucThongTinGV.TxtName1.Text, ucThongTinGV.TxtAddress1.Text, ucThongTinGV.DtpBirthday1.Value, ucThongTinGV.TxtEmail1.Text, ucThongTinGV.TxtPhone1.Text, gt, ucThongTinGV.TxtCmnd1.Text);
            gvDAO.RemoveGV(gv);
            ucThongTinGV.DgvInfo1.DataSource = gvDAO.LoadDataForGV();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string gt = ucThongTinGV.RdbWoman1.Checked ? "1" : "0";
            if (ucThongTinGV.CheckFielddNull())
            {
                MessageBox.Show("Có field rỗng. Kiểm tra lại");
            }
            else
            {
                if (ucThongTinGV.CheckEmail())
                {
                    MessageBox.Show("Chưa đúng định dạng [...@gmail.com]");
                }
                else if (ucThongTinGV.CheckPhone())
                {
                    MessageBox.Show("Số điện thoại sai ! Định dạng đúng: xxxx-xxx-xxx");
                }
                else if (ucThongTinGV.CheckAge())
                {
                    MessageBox.Show("Tuổi phải lớn hơn hoặc bằng 17");
                }
                else
                {
                    GiaoVien gv = new GiaoVien(ucThongTinGV.TxtId1.Text, ucThongTinGV.TxtName1.Text, ucThongTinGV.TxtAddress1.Text, ucThongTinGV.DtpBirthday1.Value, ucThongTinGV.TxtEmail1.Text, ucThongTinGV.TxtPhone1.Text, gt, ucThongTinGV.TxtCmnd1.Text);
                    gvDAO.EditGV(gv);
                    ucThongTinGV.DgvInfo1.DataSource = gvDAO.LoadDataForGV();
                }
            }
        }

        private void dgvGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ucThongTinGV.TxtId1.Text = ucThongTinGV.DgvInfo1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                ucThongTinGV.TxtName1.Text = ucThongTinGV.DgvInfo1.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
                ucThongTinGV.TxtEmail1.Text = ucThongTinGV.DgvInfo1.Rows[e.RowIndex].Cells["email"].Value.ToString();
                ucThongTinGV.TxtPhone1.Text = ucThongTinGV.DgvInfo1.Rows[e.RowIndex].Cells["phone"].Value.ToString();
                ucThongTinGV.TxtAddress1.Text = ucThongTinGV.DgvInfo1.Rows[e.RowIndex].Cells["diachi"].Value.ToString();
                ucThongTinGV.DtpBirthday1.Text = ucThongTinGV.DgvInfo1.Rows[e.RowIndex].Cells["ngaysinh"].Value.ToString();
                if (ucThongTinGV.DgvInfo1.Rows[e.RowIndex].Cells["gioitinh"].Value.ToString()=="1")
                {
                    ucThongTinGV.RdbWoman1.Checked = true;
                    ucThongTinGV.RdbMen1.Checked = false;
                }
                else
                {
                    ucThongTinGV.RdbWoman1.Checked = false;
                    ucThongTinGV.RdbMen1.Checked = true;
                }
                ucThongTinGV.TxtCmnd1.Text = ucThongTinGV.DgvInfo1.Rows[e.RowIndex].Cells["cmnd"].Value.ToString();
            }
        }
    }
}
