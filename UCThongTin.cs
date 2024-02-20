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
    public partial class UCThongTin : UserControl
    {
        public UCThongTin()
        {
            InitializeComponent();
        }

        public DataGridView DgvInfo1
        {
            get { return dgvInfo; }
        }

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

    }
}
