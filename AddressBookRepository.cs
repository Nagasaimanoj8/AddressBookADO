using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookAdo
{
    public class AddressBookRepository
    {
        public static string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=AddressBookService;Trusted_connection=True;MultipleActiveResultSets=True";
        static SqlConnection connection;
       
    }
}
