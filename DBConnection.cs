using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocSinh
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=QLHS;Integrated Security=True");
        SqlCommand cmd;
        public DataTable LoadDataTable(string sql)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmd = new SqlCommand(sql, conn);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tải dữ liệu cho bảng thất bại\n"+ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        public bool ExecuteQuery(string sql, SqlParameter[] lstParam)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddRange(lstParam);
                cmd.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi thất bại\n"+ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }
    }
}
