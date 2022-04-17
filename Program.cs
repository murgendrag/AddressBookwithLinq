using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookWithLINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome ");
            List<AddressReview> addressreview = new List<AddressReview>();

            new AddressReview() { FirstName = "Suresh", LastName = "Patil", Address = "xy Apartment", 
                City = "Mumbai", State = "Maharashtra", Zip = 400708, EmailID = "shdjfgs@gmail.com", PhoneNumber = 8694734856 };
            new AddressReview() { FirstName = "Peter", LastName = "Roderige", Address = "er Apartment", 
                City = "Bengalore", State = "Karnataka", Zip = 400458, EmailID = "ggufgs@gmail.com", PhoneNumber = 824578458 };
            new AddressReview() { FirstName = "Ramesh", LastName = "Patel", Address = "xy Apartment",
                City = "Mumbai", State = "Maharashtra", Zip = 400708, EmailID = "shdjfgs@gmail.com", PhoneNumber = 8694734856 };
            new AddressReview() { FirstName = "Farhan", LastName = "Quershi", Address = "y Apartment", 
                City = "Delhi", State = "Delhi", Zip = 500708, EmailID = "shdjfgs@gmail.com", PhoneNumber = 8694734856 };
            new AddressReview() { FirstName = "Geeta", LastName = "yadav", Address = "x Apartment", 
                City = "Noida", State = "Delhi", Zip = 400708, EmailID = "shdjfgs@gmail.com", PhoneNumber = 8694734856 };
            new AddressReview() { FirstName = "Sam", LastName = "kiran", Address = "xy Apartment",
                City = "Mumbai", State = "Maharashtra", Zip = 400708, EmailID = "shdjfgs@gmail.com", PhoneNumber = 8694734856 };
            new AddressReview() { FirstName = "Ram", LastName = "Patil", Address = "xy Apartment", 
                City = "Delhi", State = "Delhi", Zip = 400708, EmailID = "shdjfgs@gmail.com", PhoneNumber = 8694734856 };

            foreach (var list in addressreview)
            {
                Console.WriteLine("FirstName>" + list.FirstName, "LastName>" + list.LastName, "Address>" + list.Address, 
                    "City>" + list.City,"State>" +list.State,"Zip>" +list.Zip,"EmailId>" +list.EmailID,"PhoneNumber" +list.PhoneNumber);

            }

            AddressManagement mangement = new AddressManagement();
            mangement.RetrieveByCity(addressreview);
            mangement.RetrieveByState(addressreview);
        }
    }
}
