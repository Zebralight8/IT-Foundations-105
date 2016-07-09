using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Smith
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write your full name: ");
            String Str = Console.ReadLine();
            Str = Str.ToUpper();
            if (Str.EndsWith(" SMITH"))
            {
                Console.WriteLine("A Smith! Welcome to the Matrix!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("You will be assimulated");
                Console.WriteLine();
            }
            Console.ReadLine();
            }


        }
    }

