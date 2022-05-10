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
        public static string connectionString = "@Data Source=DESKTOP-RKMTS0O;Initial Catalog=AddressBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection = null;
        public void EnsureDataBaseConnection()
        {          
            using (connection = new SqlConnection(connectionString))
            {
                    Console.WriteLine("Connection is created");
             }           
        }
    }
}
