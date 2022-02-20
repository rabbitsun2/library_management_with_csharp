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
    public partial class BookModifyFrm : Form
    {
        private Book _book;
        private DBAccount dbAccount;

        public BookModifyFrm()
        {
            InitializeComponent();
            this.dbAccount = new DBAccount();
            initDbAcccount();
        }

        public BookModifyFrm(int book_id)
        {
            InitializeComponent();
            initDbAcccount();

            loadBookType();
            Book currentBook = loadBook(book_id);

            if (currentBook != null)
            {
                this.lblID.Text = currentBook.id.ToString();
                this.cmbBookType.Text = currentBook.book_type;
                this.txtBookName.Text = currentBook.book_name;
                this.txtTotalName.Text = currentBook.total_name;
                this.txtAuthor.Text = currentBook.author;
                this.txtBookCompany.Text = currentBook.book_company;
                this.txtBookYear.Text = currentBook.book_year.ToString();
                this.txtBookPage.Text = currentBook.book_page;
                this.txtISBN.Text = currentBook.isbn;
                this.txtPrice.Text = currentBook.price.ToString();
                this.txtBookCnt.Text = currentBook.book_cnt.ToString();
                this.usrRegidate.Value = currentBook.regidate;
            }

        }

        private void initDbAcccount()
        {
            this.dbAccount = new DBAccount();
            dbAccount.userid = "HR";
            dbAccount.passwd = "123456";
            dbAccount.dbname = "XE";
            dbAccount.hostname = "127.0.0.1";
        }

        private Book loadBook(int book_id)
        {

            String usrHost = dbAccount.hostname;
            String usrDbName = dbAccount.dbname;
            String usrDbid = dbAccount.userid;
            String usrDbPasswd = dbAccount.passwd;

            OracleDBConnection oracleDB = new OracleDBConnection();
            oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
            OracleCommand pgOraCmd = oracleDB.pgOraCmd;

            LibraryService library = new LibraryServiceImpl();

            Book currentBook = null;    // 현재 책 노드
            Book tmpBook = new Book();  // 임시 책 노드

            tmpBook.id = book_id;
            currentBook = library.selectOneBook(tmpBook, pgOraCmd);

            return currentBook;

        }

        private Book currentBook
        {
            get { return this._book; }
            set { this._book = value; }
        }

        private void loadBookType()
        {
            cmbBookType.Items.Clear();
            cmbBookType.Items.Add("단행본");
            cmbBookType.Text = "단행본";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            String usrHost = dbAccount.hostname;
            String usrDbName = dbAccount.dbname;
            String usrDbid = dbAccount.userid;
            String usrDbPasswd = dbAccount.passwd;

            OracleDBConnection oracleDB = new OracleDBConnection();

            LibraryService library = new LibraryServiceImpl();

            Book book = new Book();
            book.id = Convert.ToInt32(lblID.Text.ToString());
            book.book_type = cmbBookType.SelectedItem.ToString();
            book.book_name = txtBookName.Text.ToString();
            book.total_name = txtTotalName.Text.ToString();
            book.author = txtAuthor.Text.ToString();
            book.book_company = txtBookCompany.Text.ToString();
            book.book_year = Convert.ToInt32(txtBookYear.Text.ToString());
            book.book_page = txtBookPage.Text.ToString();
            book.isbn = txtISBN.Text.ToString();
            book.price = Convert.ToInt32(txtPrice.Text.ToString());
            book.book_cnt = Convert.ToInt32(txtBookCnt.Text.ToString());
            book.regidate = Convert.ToDateTime(usrRegidate.Value.ToString("yyyy-MM-dd"));

            // 1단계 - 도서 등록
            oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
            OracleCommand pgOraCmd = oracleDB.pgOraCmd;
            library.updateBook(book, pgOraCmd);    // 수정
            oracleDB.close();

            // 2단계 - 수정 완료
            MessageBox.Show("수정이 완료되었습니다.", "확인",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);


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
    }
}
