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
    internal interface LibraryService
    {
        DataTable allBook(OracleCommand pgOraCmd);
        Collection_Info getCollectionInfo(int book_id, OracleCommand pgOraCmd);
        DataTable searchKeyword(String keyword, OracleCommand pgOraCmd);
        int addBook(Book book, OracleCommand pgOraCmd);
        int updateBook(Book book, OracleCommand pgOraCmd);
        int addCollectionInfo(Collection_Info collection_Info, OracleCommand pgOraCmd);
        Book selectOneBook(Book currentBook, OracleCommand pgOraCmd);
        Book selectQueriesBook(Book currentBook, OracleCommand pgOraCmd);

        int updateCollectionInfo(Collection_Info collection_Info, OracleCommand pgOraCmd);

        int deleteBook(int book_id, OracleCommand pgOraCmd);

        int deleteCollectionInfo(int book_id, OracleCommand pgOraCmd);

        DataTable selectReservation(int book_id, OracleCommand pgOraCmd);

        int addReservation(Reservation reservation, OracleCommand pgOraCmd);

        int updateReservation(Reservation reservation, OracleCommand pgOraCmd);

        int updateReservationReturn(Reservation reservation, OracleCommand pgOraCmd);

        int deleteReservation(Reservation reservation, OracleCommand pgOraCmd);

    }
}
