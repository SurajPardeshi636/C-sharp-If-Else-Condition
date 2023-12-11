using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int Marks = 35;

            if (Marks < 36)
            {
                Console.WriteLine("CONGRATULATION Your PASSED ");
            }
            else
            {
                Console.WriteLine("SORRY Your Failed.....");
            }

       
            if (Marks < 30)
            {
                Console.WriteLine("it is passed");
            }
            else
            {
                Console.WriteLine("Failed.....");
            }




            Console.ReadLine();

        }
    }
}
