using Library_POP.Controller;
using Library_POP.Model;
using Library_POP.Service;
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

namespace Library_POP.View
{
    public partial class BookAddFrm : Form
    {
        private DBAccount dbAccount;

        public BookAddFrm()
        {
            InitializeComponent();
            this.dbAccount = new DBAccount();
            dbAccount.userid = "HR";
            dbAccount.passwd = "123456";
            dbAccount.dbname = "XE";
            dbAccount.hostname = "127.0.0.1";
        }

        private void txtBookYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void txtBookCnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(usrRegidate.Value.ToString("yyyy-MM-dd"));

            String usrHost = dbAccount.hostname;
            String usrDbName = dbAccount.dbname;
            String usrDbid = dbAccount.userid;
            String usrDbPasswd = dbAccount.passwd;

            OracleDBConnection oracleDB = new OracleDBConnection();
            
            LibraryService library = new LibraryServiceImpl();

            Book book = new Book();
            book.book_type = cmbBookType.SelectedItem.ToString();
            book.book_name = txtBookName.Text.ToString();
            book.total_name = txtTotalName.Text.ToString(); 
            book.author = txtAuthor.Text.ToString();
            book.book_company = txtBookCompany.Text.ToString();
            book.book_year = Convert.ToInt32( txtBookYear.Text.ToString() );
            book.book_page = txtBookPage.Text.ToString();   
            book.isbn = txtISBN.Text.ToString();    
            book.price = Convert.ToInt32( txtPrice.Text.ToString() );
            book.book_cnt = Convert.ToInt32( txtBookCnt.Text.ToString() );
            book.regidate = Convert.ToDateTime(usrRegidate.Value.ToString("yyyy-MM-dd"));
            
            // 1단계 - 도서 등록
            oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
            OracleCommand pgOraCmd = oracleDB.pgOraCmd;
            library.addBook(book, pgOraCmd);    // 추가
            oracleDB.close();

            // 2단계 - 도서 일련번호 조회
            oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
            pgOraCmd = oracleDB.pgOraCmd;
            book = library.selectQueriesBook(book, pgOraCmd); // 가져오기
            oracleDB.close();

            // 3단계 - 도서 소장 정보 등록
            Collection_Info collection_Info = new Collection_Info();
            collection_Info.book_id = book.id;

            oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
            pgOraCmd = oracleDB.pgOraCmd;                   
            library.addCollectionInfo(collection_Info, pgOraCmd);   // 위치 추가
            oracleDB.close();

            // 4단계 - 등록 완료
            MessageBox.Show("등록이 완료되었습니다.", "확인", 
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void BookAddFrm_Load(object sender, EventArgs e)
        {
            cmbBookType.Items.Clear();
            cmbBookType.Items.Add("단행본");
            cmbBookType.Text = "단행본";

        }
    }
}
