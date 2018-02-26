using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppException
{
    class Exception1:ApplicationException
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter Two Number");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Qution = " + c);
            }

            catch
            {

                throw new ApplicationException("This is my Exceptions catch");

            }

            finally
            {
                Console.WriteLine(" finally block is executing");

            }

            Console.WriteLine("rest of the code executing");
            Console.Read();
        }
    }
}
