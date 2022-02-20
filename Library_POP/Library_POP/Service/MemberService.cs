using Library_POP.Db;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_POP.Service
{
    internal interface MemberService
    {

        bool IsAccount(Account account, OracleCommand pgOraCmd);

        Account getMember(Account current, OracleCommand pgOraCmd);

    }
}
