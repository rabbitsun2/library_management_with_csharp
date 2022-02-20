using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_POP.Controller
{
    internal class DBAccount
    {
        private string _userid;
        private string _passwd;
        private string _hostname;
        private int _port;
        private string _dbname;

        public string userid
        {
            get { return _userid; }
            set { _userid = value; }
        }

        public string passwd
        {
            get { return _passwd; }
            set { _passwd = value; }
        }

        public string hostname
        {
            get { return _hostname; }
            set { _hostname = value; }
        }

        public int port
        {
            get { return _port; }
            set { _port = value; }
        }

        public string dbname
        {
            get { return _dbname; }
            set { _dbname = value; }
        }

    }
}
