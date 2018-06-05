using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

    class Publisher
    {
        public string Name;
        public string Email;
        public string Phone;
        public string Address;
        public Publisher(string _name, string _email, string _phone, string _adress)
        {
            Name = _name;
            Email = _email;
            Phone = _phone;
            Address = _adress;
            Book.Publishers.Add(this);
        }

    }
}
