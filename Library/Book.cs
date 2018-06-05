using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

  public  enum Language
    {
        En,
        Az,
        Ru,
        Tr,
        Fr
    }

    

   
    class Book
    {
        public string Name;
        public static List<Author> Authors = new List<Author>();
        public static List<Publisher> Publishers = new List<Publisher>();
        public DateTime PublishDate;
        //public string[] Category = new string[] { "Nesr", "Nezm" };
        public enum  Category { Nezm, Nesr };
        public Language Lang;
        public float Price;
        public int PaperCount;
        public Discount Discount;
        public uint Stock;
        public enum Condition { New, Used };
        public byte Edition;
        public static List<Book> BookDetails = new List<Book>();

        
        
        public Book(string _name ,  /*DateTime _publishdate ,*/ float _price , int _pcount , uint _stock , byte _ed)
        {
            this.Name = _name;
            
            //this.PublishDate = _publishdate;
            this.Price = _price;
            this.PaperCount = _pcount;
            this.Stock = _stock;
            this.Edition = _ed;

            BookDetails.Add(this);   
        }


    }
}
