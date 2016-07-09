using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in  number for X:  ");
            String str;
            str = Console.ReadLine();
            int x = int.Parse(str);
            Console.WriteLine("X equals "+ (3 * (x * x * x) - 5 * (x * x) + 6));
            Console.ReadLine();


        }
    }
}
