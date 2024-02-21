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
    public class GiaoVienDAO : PersonDAO
    {
        string sql;
        public DataTable LoadDataForGV()
        {
            sql = "SELECT * FROM GiaoVien";
            return base.LoadDataTable(sql);
        }

        public void AddGV(GiaoVien gv)
        {
            SqlParameter[] lstParam =
                {
                    new SqlParameter("@ht", SqlDbType.NVarChar) {Value = gv.Name},
                    new SqlParameter("@dc", SqlDbType.NVarChar) {Value = gv.Address},
                    new SqlParameter("@ns", SqlDbType.Date) {Value = gv.Birthday},
                    new SqlParameter("@email", SqlDbType.VarChar) {Value = gv.Email},
                    new SqlParameter("@phone", SqlDbType.VarChar) {Value = gv.Phone},
                    new SqlParameter("@gt", SqlDbType.Int) {Value = gv.Sex},
                    new SqlParameter("@cmnd", SqlDbType.VarChar) {Value = gv.Cmnd}
                };
            sql = "INSERT INTO GiaoVien(hoten,diachi,ngaysinh,email,phone,gioitinh,cmnd) VALUES(@ht,@dc,@ns,@email,@phone,@gt,@cmnd)";
            base.Add(sql, lstParam);
        }

        public void RemoveGV(GiaoVien gv)
        {
            SqlParameter[] lstParam =
                {
                    new SqlParameter("@id", SqlDbType.NVarChar) {Value = gv.Id},
                };
            sql = "DELETE FROM GiaoVien WHERE id = @id";
            base.Remove(sql, lstParam);
        }

        public void EditGV(GiaoVien gv)
        {
            SqlParameter[] lstParam =
                {
                    new SqlParameter("@id", SqlDbType.NVarChar) {Value = gv.Id},
                    new SqlParameter("@ht", SqlDbType.NVarChar) {Value = gv.Name},
                    new SqlParameter("@dc", SqlDbType.NVarChar) {Value = gv.Address},
                    new SqlParameter("@ns", SqlDbType.Date) {Value = gv.Birthday},
                    new SqlParameter("@email", SqlDbType.VarChar) {Value = gv.Email},
                    new SqlParameter("@phone", SqlDbType.VarChar) {Value = gv.Phone},
                    new SqlParameter("@gt", SqlDbType.Int) {Value = gv.Sex},
                    new SqlParameter("@cmnd", SqlDbType.VarChar) {Value = gv.Cmnd}
                };
            sql = "UPDATE GiaoVien SET hoten=@ht,diachi=@dc,ngaysinh=@ns,email=@email,phone=@phone,gioitinh=@gt,cmnd=@cmnd WHERE id=@id";
            base.Edit(sql, lstParam);
        }
    }
}
