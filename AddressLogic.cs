using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressLogic
    {
        List<DataOfPerson> person1 = new List<DataOfPerson>();
        public void addcontact()
        {
            DataOfPerson person = new DataOfPerson();
            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            person.PhoneNum = Console.ReadLine();
            Console.Write("Enter Address : ");
            person.Address = Console.ReadLine();
            Console.Write("Enter city : ");
            person.City = Console.ReadLine();
            Console.Write("Enter pinCode : ");
            person.ZipCode = Console.ReadLine();
            Console.Write("Enter EmailId : ");
            person.Email = Console.ReadLine();
            person1.Add(person);
        }
        public void editcontact()
        {
            DataOfPerson person = new DataOfPerson();

            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            foreach (var contact in person1)
                if (person. FirstName == firstName && person.LastName == lastName)
                {
                    
                    Console.WriteLine("PRESS1)" +
                        "");
                    Console.WriteLine("enter new phone number");
                    person.PhoneNum = Console.ReadLine();
                    person1.Add(person);
                }
            Console.WriteLine("Contact sucessfully update");

        }
        public void removecontact()

        {
            DataOfPerson person = new DataOfPerson();
            Console.WriteLine("Enter the first name.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the last name.");
            string lastName = Console.ReadLine();
            foreach (var contact in person1)
                if (person.FirstName == firstName && person.LastName == lastName)
                {
                    person1.Remove(person);
                }

            Console.WriteLine("Contact is succesfully Removed");

        }
    }
}