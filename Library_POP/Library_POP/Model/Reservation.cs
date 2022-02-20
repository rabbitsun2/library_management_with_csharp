using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_POP.Model
{
    internal class Reservation
    {
        private int _id;
        private int _book_id;
        private int _account_id;
        private int _book_cnt;
        private DateTime _start_date;
        private DateTime _end_date;
        private string _ip;

        public int id
        {
            get { return _id; }
            set { _id = value; }    
        }

        public int book_id
        {
            get { return _book_id; }
            set { _book_id = value; }
        }

        public int account_id
        {
            get { return _account_id; }
            set { _account_id = value; }
        }

        public int book_cnt
        {
            get { return _book_cnt; }
            set { _book_cnt = value; }
        }

        public DateTime start_date
        {
            get { return _start_date; }
            set { _start_date = value; }
        }

        public DateTime end_date
        {
            get { return _end_date; }
            set { _end_date = value; }
        }

        public string ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

    }
}
