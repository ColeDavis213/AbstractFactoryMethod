using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---Samsung Phones---");

            PhoneTypeChecker Checker1 = new PhoneTypeChecker(MANUFACTURERS.SAMSUNG);

            Checker1.CheckProducts();

            Console.WriteLine("---HTC Phones---");

            PhoneTypeChecker Checker2 = new PhoneTypeChecker(MANUFACTURERS.HTC);

            Checker2.CheckProducts();

            Console.WriteLine("---Nokia Phones---");

            PhoneTypeChecker Checker3 = new PhoneTypeChecker(MANUFACTURERS.NOKIA);

            Checker3.CheckProducts();

            Console.ReadKey();
        }

       
    }
}
