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
            AddressBookModel model = new AddressBookModel();
            addressBookRepo.DeletePerson(model);
            addressBookRepo.UpdateeData(model);
            addressBookRepo.GetAllData();
           addressBookRepo.RetrivePerson(model);
            model.city = "NLR";
            model.State = "AP";
        }
    }
}
