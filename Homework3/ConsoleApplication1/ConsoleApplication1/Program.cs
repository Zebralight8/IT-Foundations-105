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
            Console.Write("Type in number of Seconds: ");
            String str;
            str = Console.ReadLine();
            int Seconds = int.Parse(str);
            int days = 0;
            int hours = 0;
            int minutes = 0;

            while (Seconds >= 86400)
            {
                days = days + 1; Seconds = Seconds - 86400;
                if (Seconds < 86400)
                    break;
            }
            while (Seconds >= 3600)
            {
                hours = hours + 1; Seconds = Seconds - 3600;
                if (Seconds < 3600)
                    break;
            }
            while (Seconds >= 60)
            {
                minutes = minutes + 1; Seconds = Seconds - 60;
                if (Seconds < 60)
                    break;
            }
            
            Console.WriteLine("Days " + days + " Hours " + hours + " Minutes " + minutes + " Seconds " + Seconds);
            Console.ReadLine();
        }
    }
}
