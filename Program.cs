using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("EnterTwo Number");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("Quatient = " + c);


                int[] arr = new int[5];
                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine(arr[i]);
                }

               

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Finally block is executed");
            }
            Console.WriteLine("Rest of the code");
            Console.Read();
        }
    }
}
