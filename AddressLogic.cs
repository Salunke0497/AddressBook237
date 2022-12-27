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
        Dictionary<string, List<DataOfPerson>> addressBook = new Dictionary<string, List<DataOfPerson>>();

        //UC1-UC2-AddContact details
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
        //UC3 EditContact
        public void editcontact()
        {
            DataOfPerson person = new DataOfPerson();
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            foreach (var contact in person1)
                if (person.FirstName == firstName && person.LastName == lastName)
                {
                    Console.WriteLine("edit phone number");
                    Console.WriteLine("enter new phone number");
                    person.PhoneNum = Console.ReadLine();
                    person1.Add(person);
                }
            Console.WriteLine("Contact sucessfully update");


        }
        //UC4 Remove contact
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
        // display the list
        public void Display()
        {
            foreach (var person in person1)
            {
                Console.WriteLine("Contact Details:" + "\n" + "FirstName: " + person.FirstName + "\n" + "LastName: " + person.LastName + "\n" + "Address: " + person.Address + "\n" + "City: " + person.City + "\n" + "PhoneNumber: " + person.PhoneNum + "\n" + "Email: " + person.Email);
            }

        }
        //uc5
        // add multiple data of person

        public void CreateDictionary()
        {
            Console.WriteLine("Enter with what name you want to add in dictionary");
            string name = Console.ReadLine();
            addressBook.Add(name, person1);
            person1 = new List<DataOfPerson>();
        }

        // UC6
        // display dictionary which is base on key value
        public void DisplayDictionary()
        {
            foreach (var data in addressBook)
            {
                Console.WriteLine(data.Key);         //printing dictionary keys
                foreach (var person in data.Value)   // checking values inside keys
                {
                    Console.WriteLine("Contact Details:" + "\n" + "FirstName: " + person.FirstName + "\n" + "LastName: " + person.LastName + "\n" + "Address: " + person.Address + "\n" + "City: " + person.City + "\n" + "PhoneNumber: " + person.PhoneNum + "\n" + "Email: " + person.Email);
                }


            }
        }
    }

}