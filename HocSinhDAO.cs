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

        public void AddHs(HocSinh hs)
        {
            SqlParameter[] lstParam =
                {
                    new SqlParameter("@ht", SqlDbType.NVarChar) {Value = hs.Name},
                    new SqlParameter("@dc", SqlDbType.NVarChar) {Value = hs.Address},
                    new SqlParameter("@ns", SqlDbType.Date) {Value = hs.Birthday},
                    new SqlParameter("@email", SqlDbType.VarChar) {Value = hs.Email},
                    new SqlParameter("@phone", SqlDbType.VarChar) {Value = hs.Phone},
                    new SqlParameter("@gt", SqlDbType.Int) {Value = hs.Sex}
                };
            sql = "INSERT INTO HocSinh(hoten,diachi,ngaysinh,email,phone,gioitinh) VALUES(@ht,@dc,@ns,@email,@phone,@gt)";
            base.Add(sql, lstParam);
        }

        public void RemoveHs(HocSinh hs)
        {
            SqlParameter[] lstParam =
                {
                    new SqlParameter("@id", SqlDbType.NVarChar) {Value = hs.Id},
                };
            sql = "DELETE FROM HocSinh WHERE id = @id";
            base.Remove(sql, lstParam);
        }

        public void EditHs(HocSinh hs)
        {
            SqlParameter[] lstParam =
                {
                    new SqlParameter("@id", SqlDbType.NVarChar) {Value = hs.Id},
                    new SqlParameter("@ht", SqlDbType.NVarChar) {Value = hs.Name},
                    new SqlParameter("@dc", SqlDbType.NVarChar) {Value = hs.Address},
                    new SqlParameter("@ns", SqlDbType.Date) {Value = hs.Birthday},
                    new SqlParameter("@email", SqlDbType.VarChar) {Value = hs.Email},
                    new SqlParameter("@phone", SqlDbType.VarChar) {Value = hs.Phone},
                    new SqlParameter("@gt", SqlDbType.Int) {Value = hs.Sex}
                };
            sql = "UPDATE HocSinh SET hoten=@ht,diachi=@dc,ngaysinh=@ns,email=@email,phone=@phone,gioitinh=@gt WHERE id=@id";
            base.Edit(sql, lstParam);
        }
    }
}
