using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_POP.Model
{
    internal class Collection_Info
    {
        private int _id;
        private string _billing_number;
        private string _collection;
        private string _register_number;
        private int _book_id;

        public int id
        {
            get { return _id; } 
            set { _id = value; }    
        }

        public string billing_number
        {
            get { return _billing_number;  }
            set { _billing_number = value; }
        }

        public string collection
        {
            get { return _collection; }
            set { _collection = value; }
        }

        public string register_number
        {
            get { return _register_number; }
            set { _register_number = value; }
        }

        public int book_id
        {
            get { return _book_id; }
            set { _book_id = value; }
        }

    }
}
