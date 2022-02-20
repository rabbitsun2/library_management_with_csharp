using Library_POP.Controller;
using Library_POP.Model;
using Library_POP.Service;
using Library_POP.Util;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_POP.View
{
    public partial class MainFrm : Form
    {
        private int account_id;

        private DBAccount dbAccount;

        public MainFrm()
        {
            InitializeComponent(); 
            loadDBAccount();
        }

        public MainFrm(int account_id)
        {
            InitializeComponent();
            loadDBAccount();
            this.account_id = account_id;
            lblAccountID.Text = account_id.ToString();
        }

        private void loadDBAccount()
        {
            this.dbAccount = new DBAccount();
            dbAccount.userid = "HR";
            dbAccount.passwd = "123456";
            dbAccount.dbname = "XE";
            dbAccount.hostname = "127.0.0.1";

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            loadData();
            loadReservationBookCnt();
        }

        private void loadData()
        {

            String usrHost = dbAccount.hostname;
            String usrDbName = dbAccount.dbname;
            String usrDbid = dbAccount.userid;
            String usrDbPasswd = dbAccount.passwd;

            OracleDBConnection oracleDB = new OracleDBConnection();
            
            // 도서 정보 불러오기
            oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
            OracleCommand pgOraCmd = oracleDB.pgOraCmd;
            LibraryService library = new LibraryServiceImpl();
            DataTable dt = library.allBook(pgOraCmd);
            oracleDB.close();

            // 데이터값 가져오기
            this.dataGridView1.DataSource = dt;

            // 상태 창
            this.toolStripStatusLblTitle.Text = "도서 정보를 불러왔습니다.";

        }

        private void loadReservation()
        {
            String usrHost = dbAccount.hostname;
            String usrDbName = dbAccount.dbname;
            String usrDbid = dbAccount.userid;
            String usrDbPasswd = dbAccount.passwd;

            OracleDBConnection oracleDB = new OracleDBConnection();

            // 도서 정보 불러오기
            int book_id = -1;

            if (lblBookID.Text.Length > 0)
            {
                book_id = Convert.ToInt32(lblBookID.Text.ToString());
            }

            oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
            OracleCommand pgOraCmd = oracleDB.pgOraCmd;
            LibraryService library = new LibraryServiceImpl();
            DataTable dt = library.selectReservation(book_id, pgOraCmd);
            oracleDB.close();

            // 데이터값 가져오기
            this.dataGridView2.DataSource = dt;

            // 상태 창
            this.toolStripStatusLblTitle.Text = "예약정보를 불러왔습니다.";
        }

        private void loadReservationBookCnt()
        {
            this.cmbResBookCnt.Items.Add("1");
            this.cmbResBookCnt.SelectedItem = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dataGridView1.SelectedRows[0]; //선택된 Row 값 가져옴.
            string data = "";

            if (row.Cells[0].Value != null)
            {
                data = row.Cells[0].Value.ToString(); // row의 컬럼(Cells[0]) = name
            }

            if ( data.Length > 0) { 
            
                int usrBook_id = Convert.ToInt32(data);
                //MessageBox.Show("선택된 행의 이름은 '" + data + "' 입니다.");

                String usrHost = dbAccount.hostname;
                String usrDbName = dbAccount.dbname;
                String usrDbid = dbAccount.userid;
                String usrDbPasswd = dbAccount.passwd;

                OracleDBConnection oracleDB = new OracleDBConnection();
                LibraryService library = new LibraryServiceImpl();

                // 소장 정보
                oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
                OracleCommand pgOraCmd = oracleDB.pgOraCmd;

                Collection_Info collection_Info = library.getCollectionInfo(usrBook_id, pgOraCmd);
                oracleDB.close(); // DB연결 종료
                
                // 소장 정보 가져오기
                txtCollectionID.Text = collection_Info.id.ToString();
                txtCollectionBillingNumber.Text = collection_Info.billing_number;
                txtCollection.Text = collection_Info.collection;
                txtCollectionRegiNumber.Text = collection_Info.register_number;
                lblBookID.Text = data;

                // 예약 현황
                oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
                pgOraCmd = oracleDB.pgOraCmd;

                DataTable reservation_dt = library.selectReservation(usrBook_id, pgOraCmd);

                dataGridView2.DataSource = reservation_dt;
                oracleDB.close();


            }
            else
            {
                txtCollectionID.Text = "";
                txtCollectionBillingNumber.Text = "";
                txtCollection.Text = "";
                txtCollectionRegiNumber.Text = "";
                lblBookID.Text = "";

                loadReservation();

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            String usrHost = dbAccount.hostname;
            String usrDbName = dbAccount.dbname;
            String usrDbid = dbAccount.userid;
            String usrDbPasswd = dbAccount.passwd;

            OracleDBConnection oracleDB = new OracleDBConnection();
            
            // 키워드 검색
            oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
            OracleCommand pgOraCmd = oracleDB.pgOraCmd;

            LibraryService library = new LibraryServiceImpl();
            String keyword = txtKeyword.Text;   // 키워드
            DataTable dt = library.searchKeyword(keyword, pgOraCmd);
            oracleDB.close();   // DB 접속 해제

            // 데이터 값 가져오기
            this.dataGridView1.DataSource = dt;

            // 상태 창
            this.toolStripStatusLblTitle.Text = "도서를 불러왔습니다.";

        }

        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            BookAddFrm bookAddFrm = new BookAddFrm();
            bookAddFrm.ShowDialog();
        }

        private void btnCollectionModify_Click(object sender, EventArgs e)
        {

            String usrHost = dbAccount.hostname;
            String usrDbName = dbAccount.dbname;
            String usrDbid = dbAccount.userid;
            String usrDbPasswd = dbAccount.passwd;

            OracleDBConnection oracleDB = new OracleDBConnection();

            LibraryService library = new LibraryServiceImpl();

            // 1단계 - 소장 정보
            Collection_Info collection_Info = new Collection_Info();
            collection_Info.id = Convert.ToInt32(txtCollectionID.Text.ToString());
            collection_Info.billing_number = txtCollectionBillingNumber.Text.ToString();
            collection_Info.collection = txtCollection.Text.ToString();
            collection_Info.register_number = txtCollectionRegiNumber.Text.ToString();

            // 2단계 - 수정
            oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
            OracleCommand pgOraCmd = oracleDB.pgOraCmd;
            library.updateCollectionInfo(collection_Info, pgOraCmd);
            oracleDB.close();

            // 3단계 - 메시지 출력
            MessageBox.Show("수정이 완료되었습니다.", "확인", 
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

        }

        private void btnBookModify_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView1.SelectedRows[0]; //선택된 Row 값 가져옴.
            string data = "";

            //Book book = new Book();

            if (row.Cells[0].Value != null)
            {
                data = row.Cells[0].Value.ToString(); // row의 컬럼(Cells[0]) = name
            }

            if (data.Length > 0)
            {
                int book_id = Convert.ToInt32(data);

                //book.id = book_id;
                BookModifyFrm bookModifyFrm = new BookModifyFrm(book_id);
                //bookModifyFrm.setBook(book);
                bookModifyFrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("선택 후 사용하세요.", "확인",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }

        }

        private void btnBookRemove_Click(object sender, EventArgs e)
        {

            bool retVal = false;
            DataGridViewRow row = dataGridView1.SelectedRows[0]; //선택된 Row 값 가져옴.
            string data = "";

            // 셀 0번값이 NULL이 아닐 때
            if (row.Cells[0].Value != null)
            {
                data = row.Cells[0].Value.ToString(); // row의 컬럼(Cells[0]) = name
            }

            // 도서를 선택했을 때
            if (data.Length > 0)
            {

                DialogResult dialogResult = MessageBox.Show("정말로 삭제하시겠습니까?",
                                          "질문",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Information);

                // "YES"를 선택할 때
                if (dialogResult == DialogResult.Yes)
                {
                    retVal = true;
                }
                else
                {
                    retVal = false;
                }

            }
            // 데이터 셀 선택하지 않았을 때
            else
            {
                MessageBox.Show("도서를 선택하세요.", "확인", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                retVal = false;
            }

            // 반환 값이 참일 때
            if (retVal)
            {

                String usrHost = dbAccount.hostname;
                String usrDbName = dbAccount.dbname;
                String usrDbid = dbAccount.userid;
                String usrDbPasswd = dbAccount.passwd;

                OracleDBConnection oracleDB = new OracleDBConnection();

                LibraryService library = new LibraryServiceImpl();

                // 1단계 - 도서 일련번호
                int book_id = Convert.ToInt32(data);
                Reservation reservation = new Reservation();
                reservation.book_id = book_id;

                // 2단계 - 소장 정보 삭제
                oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
                OracleCommand pgOraCmd = oracleDB.pgOraCmd;
                library.deleteCollectionInfo(book_id, pgOraCmd);
                oracleDB.close();

                // 3단계 - 예약정보 삭제
                oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
                pgOraCmd = oracleDB.pgOraCmd;
                library.deleteReservation(reservation, pgOraCmd);
                oracleDB.close();

                // 4단계 - 도서 삭제
                oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
                pgOraCmd = oracleDB.pgOraCmd;
                library.deleteBook(book_id, pgOraCmd);
                oracleDB.close();

                // 5단계 - 도서 불러오기
                loadData();

                // 6단계 - 메시지 출력
                MessageBox.Show("삭제가 완료되었습니다.", "확인",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            }

        }

        private void btnResRegister_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();

            // 예약 정보
            reservation.book_id = Convert.ToInt32(lblBookID.Text.ToString());
            reservation.account_id = Convert.ToInt32(lblAccountID.Text.ToString());
            reservation.book_cnt = Convert.ToInt32(cmbResBookCnt.SelectedItem.ToString());
            reservation.start_date = DateTime.Now;
            reservation.ip = Network.getAutomaticLocalIP();

            // 계정 환경설정
            String usrHost = dbAccount.hostname;
            String usrDbName = dbAccount.dbname;
            String usrDbid = dbAccount.userid;
            String usrDbPasswd = dbAccount.passwd;

            OracleDBConnection oracleDB = new OracleDBConnection();

            LibraryService library = new LibraryServiceImpl();

            // 1단계 - 예약 정보 추가
            oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
            OracleCommand pgOraCmd = oracleDB.pgOraCmd;
            library.addReservation(reservation, pgOraCmd);
            oracleDB.close();

            // 2단계 - 예약 정보 불러오기
            loadReservation();

            // 3단계 - 메시지 출력
            MessageBox.Show("예약이 완료되었습니다.", "확인",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

        }

        private void btnResReturn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0]; //선택된 Row 값 가져옴.
            string data = "";

            // 셀 0번값이 NULL이 아닐 때
            if (row.Cells[0].Value != null)
            {
                data = row.Cells[0].Value.ToString(); // row의 컬럼(Cells[0]) = name
            }

            // 예약정보를 선택했을 때
            if (data.Length > 0)
            {
                Reservation reservation = new Reservation();
                reservation.book_cnt = 0;
                reservation.end_date = DateTime.Now;
                reservation.id = Convert.ToInt32(data);

                // 계정 환경설정
                String usrHost = dbAccount.hostname;
                String usrDbName = dbAccount.dbname;
                String usrDbid = dbAccount.userid;
                String usrDbPasswd = dbAccount.passwd;

                OracleDBConnection oracleDB = new OracleDBConnection();

                LibraryService library = new LibraryServiceImpl();

                // 1단계 - 예약 정보 추가
                oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
                OracleCommand pgOraCmd = oracleDB.pgOraCmd;
                library.updateReservationReturn(reservation, pgOraCmd);
                oracleDB.close();

                // 2단계 - 예약 정보 불러오기
                loadReservation();

                // 3단계 - 메시지 출력
                MessageBox.Show("반납이 완료되었습니다.", "확인",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("예약 정보를 선택하세요.", "확인",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

        }

        private void btnResDelete_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dataGridView2.SelectedRows[0]; //선택된 Row 값 가져옴.
            string data = "";

            // 셀 0번값이 NULL이 아닐 때
            if (row.Cells[0].Value != null)
            {
                data = row.Cells[0].Value.ToString(); // row의 컬럼(Cells[0]) = name
            }

            // 예약정보를 선택했을 때
            if (data.Length > 0)
            {
                Reservation reservation = new Reservation();
                reservation.id = Convert.ToInt32(data);

                // 계정 환경설정
                String usrHost = dbAccount.hostname;
                String usrDbName = dbAccount.dbname;
                String usrDbid = dbAccount.userid;
                String usrDbPasswd = dbAccount.passwd;

                OracleDBConnection oracleDB = new OracleDBConnection();

                LibraryService library = new LibraryServiceImpl();

                // 1단계 - 예약 정보 추가
                oracleDB.openConnection(usrHost, usrDbName, usrDbid, usrDbPasswd);  // DB 연결
                OracleCommand pgOraCmd = oracleDB.pgOraCmd;
                library.deleteReservation(reservation, pgOraCmd);
                oracleDB.close();

                // 2단계 - 예약 정보 불러오기
                loadReservation();

                // 3단계 - 메시지 출력
                MessageBox.Show("예약이 취소되었습니다.", "확인",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("예약 정보를 선택하세요.", "확인",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

        }
    }
}
