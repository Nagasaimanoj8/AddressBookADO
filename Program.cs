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
            Console.WriteLine("Enter your city");
            model.city = Console.ReadLine();
            Console.WriteLine("Enter your state");
            model.State = Console.ReadLine();
            addressBookRepo.RetrivePerson(model);
            Console.WriteLine("Enter your city");
            model.city = Console.ReadLine();
            Console.WriteLine("Enter your state");
            model.State = Console.ReadLine();
            addressBookRepo.RetrivePersonCityState(model);
            Console.WriteLine("Enter your city name to get the persons alphabetically");
            model.city = Console.ReadLine();
            addressBookRepo.OrderByFirstName();
            addressBookRepo.CountByType();
        
            model.Firstname = "Rahul";
            model.Lastname = "Tripathi";
            model.Address = "Jabalpur";
            model.city = "Bhopal";
            model.State = "Madhya Pradesh";
            model.Zip = 42334;
            model.MobileNumber = "8887131570";
            model.EmailId = "rahul11@gmail.com";
            model.AddressBookName = "Friends book";
            model.AddressBookType = "Friend";

            model.Firstname = "Rahul";
            model.Lastname = "Tripathi";
            model.Address = "Jabalpur";
            model.city = "Bhopal";
            model.State = "Madhya Pradesh";
            model.Zip = 42334;
            model.MobileNumber = "8887131570";
            model.EmailId = "rahul11@gmail.com";
            model.AddressBookName = "Family book";
            model.AddressBookType = "Family";
            addressBookRepo.AddPersonAsFriendAndFamily(model);

            Console.ReadKey();
        }
    }
}
