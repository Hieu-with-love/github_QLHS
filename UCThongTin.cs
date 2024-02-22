using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLyHocSinh
{
    public partial class UCThongTin : UserControl
    {
        public UCThongTin()
        {
            InitializeComponent();
        }

        public bool CheckFielddNull()
        {
            string gt = RdbWoman1.Checked ? "1" : "0";
            return (RdbWoman1.Checked==false && RdbMen1.Checked==false)||string.IsNullOrEmpty(TxtName1.Text)||string.IsNullOrEmpty(TxtAddress1.Text)||DtpBirthday1.Value==DateTime.MinValue||string.IsNullOrEmpty(gt)||string.IsNullOrEmpty(TxtCmnd1.Text);
        }

        public bool CheckAge()
        {
            return (DateTime.Now.AddYears(-17) < DtpBirthday1.Value);
        }

        private bool IsValidEmail(string email)
        {
            string parent = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, parent);
        }
        public bool CheckEmail()
        {
            return !IsValidEmail(TxtEmail1.Text);
        }

        public bool CheckPhone()
        {
            return TxtPhone1.Text.Length!=10;
        }

        public DataGridView DgvInfo1 { get { return dgvInfo; } }
        public RadioButton RdbWoman1 { get { return rdbWoman; } }
        public TextBox TxtPhone1 { get { return txtPhone; } }
        public RadioButton RdbMen1 { get { return rdbMen; } }
        public TextBox TxtEmail1 { get { return txtEmail; } }
        public Label LblPhone1 { get { return lblPhone; } }
        public Label LblEmail1 { get { return lblEmail; } }
        public Label LblSex1 { get { return lblSex; } }
        public DateTimePicker DtpBirthday1 { get { return dtpBirthday; } }
        public TextBox TxtName1 { get { return txtName; } }
        public TextBox TxtAddress1 { get { return txtAddress; } }
        public TextBox TxtId1 { get { return txtId; } }
        public Label LblBirthday1 { get { return lblBirthday; } }
        public Label LblAddress1 { get { return lblAddress; } }
        public Label LblName1 { get { return lblName; } }
        public Label LblId1 { get { return lblId; } }
        public Button BtnAdd1 { get { return btnAdd; } }
        public Button BtnRemove1 { get { return btnRemove; } }
        public Button BtnEdit1 { get { return btnEdit; } }
        public TextBox TxtCmnd1 { get { return txtCMND; } }

        private void UCThongTin_Load(object sender, EventArgs e)
        {

        }
    }
}
