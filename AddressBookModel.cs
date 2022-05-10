using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookAdo
{
   
        /// <summary>
        /// Class to map the relational data base model to a entity.
        /// </summary>
        public class AddressBookModel
        {
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string MobileNumber { get; set; }
        public string EmailId { get; set; }
        }
}
