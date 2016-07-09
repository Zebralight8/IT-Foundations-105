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
            var time = TimeSpan.FromSeconds(Seconds);
            int days = time.Days;
            int hours = time.Hours;
            int minutes = time.Minutes;
            int seconds = time.Seconds;
            Console.WriteLine("Days " + days + " Hours " + hours + " Minutes " + minutes + " Seconds " + seconds);
            Console.ReadLine();
        }
    }
}
