using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AuthorAdd : Form
    {
        public AuthorAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var aName = AuthorsName.Text;
            var aSurName = AuthorSurname.Text;
            var aEmail = AuthorEmail.Text;
            var aPhone = AuthorPhone.Text;
            var aAbout = AuthorAbout.Text;
            Author author = new Author(aName,aSurName,aEmail,aPhone,aAbout);



            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in Book.Authors)
            {
                textBox2.Text = item.Name + " " + item.Surname + " " + item.Email + " " + item.Phone + " " + item.About;
               
            }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            PublisherAdd publisherAdd = new PublisherAdd();
            this.Hide();
            publisherAdd.Show();
        }
    }
}
