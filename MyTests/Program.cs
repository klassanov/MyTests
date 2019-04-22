using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }


        static void Test()
        {
            try
            {
                Console.WriteLine("Try block");
                throw new Exception("Test");
            }
            catch (Exception)
            {
                Console.WriteLine("Catch block");
                //throw new Exception("My Exception");
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
            Console.ReadKey();
        }




    }
}
