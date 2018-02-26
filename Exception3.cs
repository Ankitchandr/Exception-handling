using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppException
{
    class Exception3
    {
        static void Main(string[] args)
        {

            checked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }

            //unchecked
            //{
            //    int val = int.MaxValue;
            //    Console.WriteLine(val + 2);
            //}
            Console.Read();
        }
    }
}
