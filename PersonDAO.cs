using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyHocSinh
{
    public class PersonDAO
    {
        DBConnection dbcn = new DBConnection();
        public virtual DataTable LoadDataTable(string sql)
        {
            return dbcn.LoadDataTable(sql);
        }

        public virtual void Add(string sql, SqlParameter[] lstParam)
        {
            if (dbcn.ExecuteQuery(sql, lstParam))
                MessageBox.Show("Thêm thành công");
        }

        public virtual void Remove(string sql, SqlParameter[] lstParam)
        {
            if (dbcn.ExecuteQuery(sql, lstParam))
                MessageBox.Show("Xóa thành công");
        }

        public virtual void Edit(string sql, SqlParameter[] lstParam)
        {
            if (dbcn.ExecuteQuery(sql, lstParam))
                MessageBox.Show("Sửa thành công");
        }
    }
}
