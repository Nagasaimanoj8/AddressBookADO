using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookAdo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to addressBook");
            AddressBookRepository addressBookRepo = new AddressBookRepository();
            addressBookRepo.GetAllData();
            Console.ReadKey();
        }
    }
}
