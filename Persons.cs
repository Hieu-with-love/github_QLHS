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
        private string email;
        private string phone;
        private string sex;
        public Persons(string id, string name, string address, DateTime birthday, string email, string phone, string sex)
        {
            this.id=id;
            this.name=name;
            this.address=address;
            this.birthday=birthday;
            this.email=email;
            this.phone = phone;
            this.sex = sex;
        }
        public string Id { get => id; }
        public string Name { get => name; }
        public string Address { get => address; }
        public DateTime Birthday { get => birthday; }
        public string Email { get => email; }
        public string Phone { get => phone; }
        public string Sex { get => sex; }

    }
}
