using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_and_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong ip;
            ulong number;
            ulong factorial;

            Console.WriteLine("Enter the Number");

           number = ulong.Parse(Console.ReadLine());

            factorial = number;

                        for (ip = number - 1; ip >= 1; ip--)

                            {

                factorial = factorial * ip;

                            }

            Console.WriteLine("Factorial of Your Number is: " + factorial);

           Console.ReadLine();


        }
    }
}
