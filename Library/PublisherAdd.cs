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
    public partial class PublisherAdd : Form
    {
        public PublisherAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var pName = PublisherName.Text;
            var pEmail = PublisherEmail.Text;
            var pPhone = PublisherPhone.Text;
            var pAdress = PublisherAdress.Text;

            Publisher publisher = new Publisher(pName,pEmail,pPhone,pAdress);

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BookAdd bookAdd = new BookAdd();
            this.Hide();
            bookAdd.Show();
        }
    }
}
