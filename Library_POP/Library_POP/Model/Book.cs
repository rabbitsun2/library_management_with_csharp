using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_POP.Model
{
    internal class Book
    {
        private int _id;
        private string _book_type;
        private string _book_name;
        private string _total_name;
        private string _author;
        private string _book_company;
        private int _book_year;
        private string _book_page;
        private string _isbn;
        private int _price;
        private int _book_cnt;
        private DateTime _regidate;

        public int id
        {
            get { return _id; } 
            set { _id = value; }    
        }

        public string book_type
        {
            get { return _book_type; }
            set { _book_type = value; }    
        }

        public string book_name
        {
            get { return _book_name; }  
            set { _book_name = value; } 
        }

        public string total_name
        {
            get { return _total_name; }
            set { _total_name = value; }
        }

        public string author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string book_company
        {
            get { return _book_company; }
            set { _book_company = value; }
        }

        public int book_year
        {
            get { return _book_year; }
            set { _book_year = value; }
        }

        public string book_page
        {
            get { return _book_page; }
            set { _book_page = value; } 
        }

        public string isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public int price
        {
            get { return _price; }
            set { _price = value; } 
        }

        public int book_cnt
        {
            get { return _book_cnt; }   
            set { _book_cnt = value; }
        }

        public DateTime regidate
        {
            get { return _regidate; }
            set { _regidate = value; }
        }

    }
}
