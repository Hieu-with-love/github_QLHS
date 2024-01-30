using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyHocSinh
{
    public class HocSinhDAO : PersonDAO
    {
        string sql;
        
        public DataTable LoadDataTableForHS()
        {
            sql = "SELECT * FROM HocSinh";
            return base.LoadDataTable(sql);
        }

        public void Add(HocSinh hs)
        {
            SqlParameter[] lstParam =
                {
                    new SqlParameter("@ht", SqlDbType.NVarChar) {Value = hs.Name},
                    new SqlParameter("@dc", SqlDbType.NVarChar) {Value = hs.Address},
                    new SqlParameter("@ns", SqlDbType.Date) {Value = hs.Birthday},
                };
            sql = "INSERT INTO HocSinh(hoten,diachi,ngaysinh) VALUES(@ht,@dc,@ns)";
            base.Add(sql, lstParam);
        }

        public void Remove(HocSinh hs)
        {
            SqlParameter[] lstParam =
                {
                    new SqlParameter("@id", SqlDbType.NVarChar) {Value = hs.Id},
                };
            sql = "DELETE FROM HocSinh WHERE id = @id";
            base.Remove(sql, lstParam);
        }

        public void Edit(HocSinh hs)
        {
            SqlParameter[] lstParam =
                {
                    new SqlParameter("@id", SqlDbType.NVarChar) {Value = hs.Id},
                    new SqlParameter("@ht", SqlDbType.NVarChar) {Value = hs.Name},
                    new SqlParameter("@dc", SqlDbType.NVarChar) {Value = hs.Address},
                    new SqlParameter("@ns", SqlDbType.Date) {Value = hs.Birthday}
                };
            sql = "UPDATE HocSinh SET hoten=@ht,diachi=@dc,ngaysinh=@ns WHERE id=@id";
            base.Edit(sql, lstParam);
        }
    }
}
