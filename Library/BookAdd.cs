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
    public partial class BookAdd : Form
    {

        
        public BookAdd()
        {
            InitializeComponent();

            AuthorSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            

            foreach (var item in Book.Authors)
            {
                AuthorSelect.Items.Add(item.Name + " " + item.Surname);
            }

            foreach (var item2 in Book.Publishers)
            {
                PublisherSelect.Items.Add(item2.Name + " " + item2.Address);
            }

        }



        private void BookAdder_Click(object sender, EventArgs e)
        {

            //var b = AuthorSelect.SelectedItem.ToString();

            //foreach (var checkedItems in Book.Authors)
            //{
            //    if (AuthorSelect.SelectedItem.ToString().Equals(checkedItems.Name.ToString()))
            //    {
            //        MessageBox.Show("e");
            //    }
            //}


            var bkName = bookName.Text;
            var bkAuthors = AuthorSelect.SelectedItem;
            var bkPublisher = PublisherSelect.SelectedItem;
            //var bkPublishDate = Convert.ToDateTime(bookPDate.Text);
            var bkCategory = CategorySelect.SelectedItem;
            var bkLanguage = LangSelect.SelectedItem;
            var bkPrice = float.Parse(bookPrice.Text);
            var bkPaperCount = int.Parse(bookPaperCount.Text);
            var bkStock = uint.Parse(bookStock.Text);
            var bkEdition = byte.Parse(bookEdition.Text);

            Book newBook = new Book(bkName,/*bkPublishDate*/bkPrice,bkPaperCount,bkStock,bkEdition);

            ShowBookToMe();
        }

        private void BookAdd_Load(object sender, EventArgs e)
        {
            enums();
            catEnums();
            ConditionEnums();
        }


        public void ShowBookToMe()
        {
            foreach (var item in Book.BookDetails)
            {
                resultBox.Text += item.Name + " " + AuthorSelect.SelectedItem + " "  + PublisherSelect.SelectedItem + " " + CategorySelect.SelectedItem +  " " + LangSelect.SelectedItem +  " " +  bookPrice.Text + " " + bookPaperCount.Text + " " + bookStock.Text + " " + " " + ConditionSelect.SelectedItem + " " +  bookEdition.Text + "\r\n";

            }
        }

        public void enums() {

            foreach (Language lang in Enum.GetValues(typeof(Language)))
            {
                LangSelect.Items.Add(lang.ToString());
            }
        }


        public void catEnums()
        {
            foreach (Book.Category category in Enum.GetValues(typeof(Book.Category)))
            {
                CategorySelect.Items.Add(category.ToString());
            }
        }

        public void ConditionEnums()
        {
            foreach (Book.Condition condition in Enum.GetValues(typeof(Book.Condition)))
            {
                ConditionSelect.Items.Add(condition.ToString());
            }
        }


       
    }
}

