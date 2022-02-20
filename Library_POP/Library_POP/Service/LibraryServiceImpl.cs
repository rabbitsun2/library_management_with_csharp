using Library_POP.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_POP.Service
{
    internal class LibraryServiceImpl : LibraryService
    {

        public DataTable allBook(OracleCommand pgOraCmd)
        {
            string query = @"select * " + 
                @"from library_book order by id";
            DataTable dt = new DataTable();

            pgOraCmd.CommandText = query;

            using (OracleDataAdapter da = new OracleDataAdapter(pgOraCmd))
            {
                da.Fill(dt);
            }

            dt.Columns["id"].ColumnName = "번호";
            dt.Columns["book_type"].ColumnName = "자료유형";
            dt.Columns["book_name"].ColumnName = "도서명";
            dt.Columns["total_name"].ColumnName = "총서명";
            dt.Columns["author"].ColumnName = "저자";
            dt.Columns["book_company"].ColumnName = "출판사";
            dt.Columns["book_year"].ColumnName = "출판년도";
            dt.Columns["book_page"].ColumnName = "판차/페이지";
            dt.Columns["isbn"].ColumnName = "ISBN";
            dt.Columns["price"].ColumnName = "가격";
            dt.Columns["book_cnt"].ColumnName = "수량";
            dt.Columns["regidate"].ColumnName = "등록일자";

            return dt;

        }

        public Collection_Info getCollectionInfo(int book_id, OracleCommand pgOraCmd)
        {
            Collection_Info collection_Info = new Collection_Info();
            string query = $@"select * from library_book_collection_info " +
                @" where book_id = :book_id order by id";
            
            pgOraCmd.CommandText = query;

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("book_id", book_id.ToString())
            };

            pgOraCmd.Parameters.AddRange(parameters);

            OracleDataReader dr = pgOraCmd.ExecuteReader();
            
            while (dr.Read())
            {
                collection_Info.id = int.Parse(dr["id"].ToString());
                collection_Info.billing_number = dr["billing_number"].ToString();
                collection_Info.collection = dr["collection"].ToString();
                collection_Info.register_number = dr["register_number"].ToString();
                collection_Info.book_id = int.Parse(dr["book_id"].ToString());
            }

            return collection_Info;

        }

        public DataTable searchKeyword(String keyword, OracleCommand pgOraCmd)
        {

            string query = @"select * " +
                @"from library_book where book_name like :book_name || '%' order by id";
            DataTable dt = new DataTable();

            pgOraCmd.CommandText = query;
            
            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("book_name", keyword)
            };

            pgOraCmd.Parameters.AddRange(parameters);

            using (OracleDataAdapter da = new OracleDataAdapter(pgOraCmd))
            {
                da.Fill(dt);
            }

            dt.Columns["id"].ColumnName = "번호";
            dt.Columns["book_type"].ColumnName = "자료유형";
            dt.Columns["book_name"].ColumnName = "도서명";
            dt.Columns["total_name"].ColumnName = "총서명";
            dt.Columns["author"].ColumnName = "저자";
            dt.Columns["book_company"].ColumnName = "출판사";
            dt.Columns["book_year"].ColumnName = "출판년도";
            dt.Columns["book_page"].ColumnName = "판차/페이지";
            dt.Columns["isbn"].ColumnName = "ISBN";
            dt.Columns["price"].ColumnName = "가격";
            dt.Columns["book_cnt"].ColumnName = "수량";
            dt.Columns["regidate"].ColumnName = "등록일자";

            return dt;
        }
        public int addBook(Book book, OracleCommand pgOraCmd)
        {
            string query = @"insert into library_book(" +
                @"book_type, book_name, total_name, author," +
                @"book_company, book_year, book_page, isbn, " +
                @"price, book_cnt, regidate" +
                @") values(" +
                @":book_type, :book_name, :total_name, :author, " +
                @":book_company, :book_year, :book_page, :isbn, " +
                @":price, :book_cnt, :regidate" +
                @")";

            pgOraCmd.CommandText = query;

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("book_type", book.book_type),
                new OracleParameter("book_name", book.book_name),
                new OracleParameter("total_name", book.total_name),
                new OracleParameter("author", book.author),

                new OracleParameter("book_company", book.book_company),
                new OracleParameter("book_year", book.book_year),
                new OracleParameter("book_page", book.book_page),
                new OracleParameter("isbn", book.isbn),

                new OracleParameter("price", book.price),
                new OracleParameter("book_cnt", book.book_cnt),
                new OracleParameter("regidate", book.regidate)
            };

            pgOraCmd.Parameters.AddRange(parameters);   

            return pgOraCmd.ExecuteNonQuery();

        }

        public int updateBook(Book book, OracleCommand pgOraCmd)
        {
            string query = @"update library_book set " +
                @"book_type = :book_type, " + 
                @"book_name = :book_name, " +
                @"total_name = :total_name, " +
                @"author = :author, " +
                @"book_company = :book_company, " +
                @"book_year = :book_year, " + 
                @"book_page = :book_page, " + 
                @"isbn = :isbn, " +
                @"price = :price, " +
                @"book_cnt = :book_cnt, " +
                @"regidate = :regidate" +
                @" where id = :id";

            pgOraCmd.CommandText = query;

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("book_type", book.book_type),
                new OracleParameter("book_name", book.book_name),
                new OracleParameter("total_name", book.total_name),
                new OracleParameter("author", book.author),

                new OracleParameter("book_company", book.book_company),
                new OracleParameter("book_year", book.book_year),
                new OracleParameter("book_page", book.book_page),
                new OracleParameter("isbn", book.isbn),

                new OracleParameter("price", book.price),
                new OracleParameter("book_cnt", book.book_cnt),
                new OracleParameter("regidate", book.regidate),
                new OracleParameter("id", book.id)
            };

            pgOraCmd.Parameters.AddRange(parameters);

            return pgOraCmd.ExecuteNonQuery();
        }

        public int addCollectionInfo(Collection_Info collection_Info,
                                     OracleCommand pgOraCmd)
        {
            string query = @"insert into library_book_collection_info(" +
                @"billing_number, collection, register_number, book_id" +
                @") values(" +
                @":billing_number, :collection, :register_number, :book_id" +
                @")";

            pgOraCmd.CommandText = query;

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("billing_number", collection_Info.billing_number),
                new OracleParameter("collection", collection_Info.collection),
                new OracleParameter("register_number", collection_Info.register_number),
                new OracleParameter("book_id", collection_Info.book_id)
            };

            pgOraCmd.Parameters.AddRange(parameters);

            return pgOraCmd.ExecuteNonQuery();
        }

        public Book selectOneBook(Book currentBook, OracleCommand pgOraCmd)
        {
            Book book = new Book();
            string query = $@"select * from library_book where " +
                $@"id = :id";


            pgOraCmd.CommandText = query;

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("id", currentBook.id)
            };

            pgOraCmd.Parameters.AddRange(parameters);

            OracleDataReader dr = pgOraCmd.ExecuteReader();

            while (dr.Read())
            {
                book.id = Convert.ToInt32(dr["id"].ToString());
                book.book_type = dr["book_type"].ToString();
                book.book_name = dr["book_name"].ToString();
                book.total_name = dr["total_name"].ToString();

                book.author = dr["author"].ToString();
                book.book_company = dr["book_company"].ToString();
                book.book_year = Convert.ToInt32(dr["book_year"].ToString());
                book.book_page = dr["book_page"].ToString();
                
                book.isbn = dr["isbn"].ToString();
                book.price = Convert.ToInt32(dr["price"].ToString());
                book.book_cnt = Convert.ToInt32(dr["book_cnt"].ToString());
                book.regidate = Convert.ToDateTime(dr["regidate"].ToString());
            }

            return book;
        }

        public Book selectQueriesBook(Book currentBook, OracleCommand pgOraCmd)
        {

            Book book = new Book();
            string query = $@"select * from library_book where " +
                $@"book_type = :book_type and " + 
                $@"book_name = :book_name and " + 
                $@"total_name = :total_name and " +
                $@"author = :author and " +
                $@"book_company = :book_company and " + 
                $@"book_year = :book_year and " + 
                $@"book_page = :book_page and " + 
                $@"isbn = :isbn and " + 
                $@"price = :price and " + 
                $@"book_cnt = :book_cnt and " + 
                $@"regidate = :regidate";
            

            pgOraCmd.CommandText = query;

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("book_type", currentBook.book_type),
                new OracleParameter("book_name", currentBook.book_name),
                new OracleParameter("total_name", currentBook.total_name),
                new OracleParameter("author", currentBook.author),

                new OracleParameter("book_company", currentBook.book_company),
                new OracleParameter("book_year", currentBook.book_year),
                new OracleParameter("book_page", currentBook.book_page),
                new OracleParameter("isbn", currentBook.isbn),

                new OracleParameter("price", currentBook.price),
                new OracleParameter("book_cnt", currentBook.book_cnt),
                new OracleParameter("regidate", currentBook.regidate)
            };

            pgOraCmd.Parameters.AddRange(parameters);

            OracleDataReader dr = pgOraCmd.ExecuteReader();

            while (dr.Read())
            {
                book.id = Convert.ToInt32(dr["id"].ToString());
                book.book_type = dr["book_type"].ToString();
                book.book_name = dr["book_name"].ToString();
                book.total_name = dr["total_name"].ToString();

                book.author = dr["author"].ToString();
                book.book_company = dr["book_company"].ToString();
                book.book_year = Convert.ToInt32(dr["book_year"].ToString());
                book.book_page = dr["book_page"].ToString();

                book.isbn = dr["isbn"].ToString();
                book.price = Convert.ToInt32(dr["price"].ToString());
                book.book_cnt = Convert.ToInt32(dr["book_cnt"].ToString());
                book.regidate = Convert.ToDateTime(dr["regidate"].ToString());
            }

            return book;

        }

        public int updateCollectionInfo(Collection_Info collection_Info, OracleCommand pgOraCmd)
        {
            string query = @"update library_book_collection_info set " +
                @"billing_number = :billing_number, " + 
                @"collection = :collection, " + 
                @"register_number = :register_number " + 
                @"where id = :id";

            pgOraCmd.CommandText = query;

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("billing_number", collection_Info.billing_number),
                new OracleParameter("collection", collection_Info.collection),
                new OracleParameter("register_number", collection_Info.register_number),
                new OracleParameter("id", collection_Info.id)
            };

            pgOraCmd.Parameters.AddRange(parameters);

            return pgOraCmd.ExecuteNonQuery();
        }

        public int deleteBook(int book_id, OracleCommand pgOraCmd)
        {
            string query = @"delete from library_book where " +
                           @"id = :id";

            pgOraCmd.CommandText = query;

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("id", book_id)
            };

            pgOraCmd.Parameters.AddRange(parameters);

            return pgOraCmd.ExecuteNonQuery();
        }

        public int deleteCollectionInfo(int book_id, OracleCommand pgOraCmd)
        {
            string query = @"delete from library_book_collection_info where " +
                @"book_id = :book_id";

            pgOraCmd.CommandText = query;

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("book_id", book_id)
            };

            pgOraCmd.Parameters.AddRange(parameters);

            return pgOraCmd.ExecuteNonQuery();

        }

        public DataTable selectReservation(int book_id, OracleCommand pgOraCmd)
        {

            string query = @"select * from library_book_reservation " +
                @"where " + 
                @"book_id = :book_id " + 
                @"order by id";
            DataTable dt = new DataTable();

            pgOraCmd.CommandText = query;

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("book_id", book_id)
            };

            pgOraCmd.Parameters.AddRange(parameters);

            using (OracleDataAdapter da = new OracleDataAdapter(pgOraCmd))
            {
                da.Fill(dt);
            }

            dt.Columns["id"].ColumnName = "번호";
            dt.Columns["book_id"].ColumnName = "도서번호";
            dt.Columns["account_id"].ColumnName = "사용자번호";
            dt.Columns["book_cnt"].ColumnName = "대여갯수";
            dt.Columns["start_date"].ColumnName = "대여시작일자";
            dt.Columns["end_date"].ColumnName = "대여종료일자";
            dt.Columns["ip"].ColumnName = "IP";

            return dt;

        }

        public int addReservation(Reservation reservation, OracleCommand pgOraCmd)
        {
            string query = @"insert into library_book_reservation(" +
                           @"book_id, account_id, book_cnt, " +
                           @"start_date, end_date, ip) values(" + 
                           @":book_id, :account_id, :book_cnt, " + 
                           @":start_date, :end_date, :ip)";

            pgOraCmd.CommandText = query;

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("book_id", reservation.book_id),
                new OracleParameter("account_id", reservation.account_id),
                new OracleParameter("book_cnt", reservation.book_cnt),
                new OracleParameter("start_date", reservation.start_date),
                new OracleParameter("end_date", reservation.end_date),
                new OracleParameter("ip", reservation.ip)
            };

            pgOraCmd.Parameters.AddRange(parameters);

            return pgOraCmd.ExecuteNonQuery();

        }

        public int updateReservation(Reservation reservation, OracleCommand pgOraCmd)
        {
            string query = @"update library_book_reservation set " +
                           @"book_id = :book_id, " +
                           @"account_id = :account_id, " +
                           @"book_cnt = :book_cnt, " +
                           @"start_date = :start_date, " +
                           @"end_date = :end_date, " +
                           @"ip = :ip " + 
                           @"where id = :id";

            pgOraCmd.CommandText = query;

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("book_id", reservation.book_id),
                new OracleParameter("account_id", reservation.account_id),
                new OracleParameter("book_cnt", reservation.book_cnt),
                new OracleParameter("start_date", reservation.start_date),
                new OracleParameter("end_date", reservation.end_date),
                new OracleParameter("ip", reservation.ip),
                new OracleParameter("id", reservation.id)
            };

            pgOraCmd.Parameters.AddRange(parameters);

            return pgOraCmd.ExecuteNonQuery();
        }

        public int deleteReservation(Reservation reservation, OracleCommand pgOraCmd)
        {

            string query = @"delete from library_book_reservation where " +
                           @"id = :id";

            pgOraCmd.CommandText = query;

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("id", reservation.id)
            };

            pgOraCmd.Parameters.AddRange(parameters);

            return pgOraCmd.ExecuteNonQuery();

        }

        public int updateReservationReturn(Reservation reservation, OracleCommand pgOraCmd)
        {
            string query = @"update library_book_reservation set " +
                              @"book_cnt = :book_cnt, " +
                              @"end_date = :end_date " +
                              @"where id = :id";

            pgOraCmd.CommandText = query;

            OracleParameter[] parameters = new OracleParameter[] {
                new OracleParameter("book_cnt", reservation.book_cnt),
                new OracleParameter("end_date", reservation.end_date),
                new OracleParameter("id", reservation.id)
            };

            pgOraCmd.Parameters.AddRange(parameters);

            return pgOraCmd.ExecuteNonQuery();
        }
    }

}
