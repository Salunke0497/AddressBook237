using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressLogic addressLogic = new AddressLogic();
            int num;
            Console.WriteLine("PRESS\n1)AddContact\n2)EditContact\n3)Exit");
             num =Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    addressLogic.addcontact();
                    break;

                case 2:
                    addressLogic.editcontact();
                    break;
                case 3:
                    addressLogic.removecontact();
                    break;

                default:
                    break;
            }
                Console.ReadLine();
        }
    }
}
