using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppException
{

    //public class DivideByOddNoExcetion : ApplicationException
    //{

    //    public override string Message
    //    {
    //        get
    //        {
    //            return "Attemped to divide by odd no.";
    //        }
    //    }


    //}

 class Exception2
    {
        static void Main(string[] args)
        {
            try
            {
                //int a, b, c;
                //Console.WriteLine("Enter Two Number");
                //a = int.Parse(Console.ReadLine());
                //b = int.Parse(Console.ReadLine());
                //c = a / b;

                //if (b % 2 > 0)
                //{
                //    throw new DivideByOddNoExcetion();

                //}
                //Console.WriteLine("Qution = " + c);
                //Console.Read();

                string s = "hello";
                String s1 = null;
                Console.WriteLine(s1.Length); 


            }

            //catch (DivideByOddNoExcetion e)
            //{
            //    Console.WriteLine(e.Message);

            //}

            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);

            }

            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);

            //}

            finally
            {
                Console.WriteLine("finally will be executing");
            }
            Console.WriteLine("rest of the code");
            Console.Read();
        }
    }
}
