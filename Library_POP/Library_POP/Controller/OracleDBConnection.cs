using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_POP
{
    internal class OracleDBConnection
    {
		private OracleConnection pgOraConn;
        private OracleCommand _pgOraCmd;

        public OracleCommand pgOraCmd
        {
            get { return _pgOraCmd; }  
            set { _pgOraCmd = value; }  
        }

		// DB 연결
		public bool openConnection(string dbIp, string dbName, string dbId, string dbPw)
		{
			bool retValue = false;
			try
			{
				String connStr = $"Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST ={ dbIp })(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME ={ dbName}))); User ID = { dbId }; Password ={ dbPw }; Connection Timeout = 30; ";

				pgOraConn = new OracleConnection(connStr);
				pgOraConn.Open();
				pgOraCmd = pgOraConn.CreateCommand();
				//MessageBox.Show("Success DB connection.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

				retValue = true;
			}
			catch (Exception e)
			{
				retValue = false;
				//MessageBox.Show($"DB connection fail.\n {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return retValue;
		}

        public DataTable executeDataTable(String sql)
        {
            string query = sql;
            DataTable dt = new DataTable();

            pgOraCmd.CommandText = query;

            using (OracleDataAdapter da = new OracleDataAdapter(pgOraCmd))
            {
                da.Fill(dt);
            }

            return dt;

        }


        public void executeDataReader()
        {
            string colA;
            string query = $@"select * from test";
            pgOraCmd.CommandText = query;

            OracleDataReader dr = pgOraCmd.ExecuteReader();
            while (dr.Read())
            {
                colA = dr[1].ToString();                
            }

        }

        public void close()
        {
            if ( pgOraConn != null)
            {
                pgOraConn.Close();
            }
            if ( pgOraCmd != null)
            {
                pgOraCmd.Dispose();
            }
        }

    }
}
