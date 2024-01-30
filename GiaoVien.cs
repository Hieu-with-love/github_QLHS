using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    public class GiaoVien : Persons
    {
        public GiaoVien(string id, string name, string address, DateTime birthday) : base(id, name, address, birthday) { }
    }
}
