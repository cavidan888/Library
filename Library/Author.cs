using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Author
    {
        public string Name;
        public string Surname;
        public string Email;
        public string Phone;
        public static List<Book> books = new List<Book>();
        public string About;


        public Author(string _name , string _surname , string _email , string _phone , string _about)
        {
            this.Name = _name;
            this.Surname = _surname;
            this.Email = _email;
            this.Phone = _phone;
            this.About = _about;
            Book.Authors.Add(this);
        }

    }
}
