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
    public partial class FHocSinh : Form
    {
        HocSinhDAO hsDAO = new HocSinhDAO();
        public FHocSinh()
        {
            InitializeComponent();
        }
        // Nếu code như bình thường, chỉ có một xíu form về học sinh này.
        // Thì ta chỉ cần một DB về HocSinh

        private void FHocSinh_Load(object sender, EventArgs e)
        {
            dgvHS.DataSource = hsDAO.LoadDataTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtId.Text, txtName.Text, txtAddress.Text, dtpBirthday.Value);
            hsDAO.Add(hs);
            dgvHS.DataSource = hsDAO.LoadDataTable();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtId.Text, txtName.Text, txtAddress.Text, dtpBirthday.Value);
            hsDAO.Remove(hs);
            dgvHS.DataSource = hsDAO.LoadDataTable();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtId.Text, txtName.Text, txtAddress.Text, dtpBirthday.Value);
            hsDAO.Edit(hs);
            dgvHS.DataSource = hsDAO.LoadDataTable();
        }
    }
}
