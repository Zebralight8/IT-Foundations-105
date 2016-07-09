using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months
{
    class Program
    {
        static void Main()
        {
            while (true)
                Console.Write("Enter in your full name:");
            string x = Console.ReadLine();

            x = x.ToUpper();
            if (x.EndsWith(" Smith"))
            {
                Console.WriteLine("A Smith, welcome to the Matrix!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("You will be assimilated");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        }

            
        }
        
            

        } 
    
       

