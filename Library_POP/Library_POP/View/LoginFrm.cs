using Library_POP.Controller;
using Library_POP.Db;
using Library_POP.Service;
using Library_POP.View;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_POP
{
    public partial class LoginFrm : Form
    {
        private DBAccount dbAccount;

        public LoginFrm()
        {
            InitializeComponent();
            this.dbAccount = new DBAccount();
            dbAccount.userid = "HR";
            dbAccount.passwd = "123456";
            dbAccount.dbname = "XE";
            dbAccount.hostname = "127.0.0.1";
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            String usrHost = dbAccount.hostname;
            String usrDbName = dbAccount.dbname;
            String usrDbid = dbAccount.userid;
            String usrDbPasswd = dbAccount.passwd;
            
            bool findAccount = false;

            // 1. 계정 찾기
            OracleDBConnection oracleDB = new OracleDBConnection();
            oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
            MemberService memberService = new MemberServiceImpl();
            
            OracleCommand pgOraCmd = oracleDB.pgOraCmd;

            Account account = new Account();
            account.usr_id = txtID.Text;
            account.passwd = txtPasswd.Text;

            findAccount = memberService.IsAccount(account, pgOraCmd);

            oracleDB.close();   // DB 연결 끊기

            // 사용자 계정 찾았을 때
            if (findAccount == true)
            {
                // 2. 계정 가져오기
                oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
                pgOraCmd = oracleDB.pgOraCmd;
                account = memberService.getMember(account, pgOraCmd);

                oracleDB.close();   // DB 연결 끊기

                MainFrm mainFrm = new MainFrm(account.id);
                mainFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("계정을 찾을 수 없습니다.", "확인",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            oracleDB.close();   // 종료

        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            AboutFrm aboutFrm = new AboutFrm();
            aboutFrm.ShowDialog();
        }
    }
}
