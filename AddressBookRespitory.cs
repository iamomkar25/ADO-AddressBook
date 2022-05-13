using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ADO_Address_Book
{
    internal class AddressBookRespitory
    {
        //Give path for Database Connection
        public static string connection = @"Server=LAPTOP-ABMNAC9K\SQLEXPRESS;Database=Address_Book_Service_DB;Trusted_Connection=True;";
        //Represents a connection to Sql Server Database
        SqlConnection sqlConnection = new SqlConnection(connection);
    }
}
