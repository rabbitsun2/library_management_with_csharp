using Library_POP.Db;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_POP.Service
{
    internal class MemberServiceImpl : MemberService
    {
        public bool IsAccount(Account account, OracleCommand pgOraCmd)
        {
            string usr_id = "";
            string passwd = "";

            string query = @"select * from library_account" + 
                @" where usr_id = :usr_id and" + 
                @" passwd = :passwd";

            pgOraCmd.CommandText = query;
            // 단일 파라메터
            //pgOraCmd.Parameters.Add(new OracleParameter("usr_id", account.id));

            // 복합 파라메터
            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("usr_id", account.usr_id),
                new OracleParameter("passwd", account.passwd)
            };

            pgOraCmd.Parameters.AddRange(parameters);
            OracleDataReader dr = pgOraCmd.ExecuteReader();

            while(dr.Read())
            {
                usr_id = dr["usr_id"].ToString();
                passwd = dr["passwd"].ToString();
            }

            if ( usr_id.Length != 0 
                && passwd.Length != 0 )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public Account getMember(Account current, OracleCommand pgOraCmd)
        {

            Account account = null;

            string query = @"select * from library_account" +
                @" where usr_id = :usr_id and" +
                @" passwd = :passwd";

            pgOraCmd.CommandText = query;
            // 단일 파라메터
            //pgOraCmd.Parameters.Add(new OracleParameter("usr_id", account.id));

            // 복합 파라메터
            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("usr_id", current.usr_id),
                new OracleParameter("passwd", current.passwd)
            };

            pgOraCmd.Parameters.AddRange(parameters);
            OracleDataReader dr = pgOraCmd.ExecuteReader();

            while (dr.Read())
            {

                if (account == null)
                {
                    account = new Account();
                }

                account.id = Convert.ToInt32(dr["id"].ToString());
                account.usr_id = dr["usr_id"].ToString();
                account.passwd = dr["passwd"].ToString();
                account.member_id = Convert.ToInt32(dr["member_id"].ToString());
                account.regidate = Convert.ToDateTime(dr["regidate"].ToString());
                account.authorize = dr["authorize"].ToString();

            }

            return account;

        }

    }
}
