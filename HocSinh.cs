using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    public class HocSinh : Persons
    {
        public HocSinh(string id, string name, string address, DateTime birthday) : base(id,name,address,birthday){ }
    }
}
