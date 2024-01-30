using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh
{
    public class Persons
    {
        private string id;
        private string name;
        private string address;
        private DateTime birthday;
        public Persons(string id, string name, string address, DateTime birthday)
        {
            this.id=id;
            this.name=name;
            this.address=address;
            this.birthday=birthday;
        }
        public string Id { get => id; }
        public string Name { get => name; }
        public string Address { get => address; }
        public DateTime Birthday { get => birthday; }
    }
}
