using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_POP.Db
{
    internal class Account
    {
        private int _id;
        private string _usr_id;
        private string _passwd;
        private int _member_id;
        private DateTime _regidate;
        private string _authorize;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string usr_id
        {
            get { return _usr_id; }
            set { _usr_id = value; }
        }

        public string passwd
        {
            get { return _passwd; }
            set { _passwd = value; }
        }

        public int member_id
        {
            get { return _member_id; }
            set { _member_id = value; }
        }

        public DateTime regidate
        {
            get { return _regidate; }   
            set { _regidate = value; }  
        }

        public string authorize
        {
            get { return _authorize; }
            set { _authorize = value; }
        }

    }
}
