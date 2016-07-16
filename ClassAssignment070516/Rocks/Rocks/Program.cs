using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5, -2, 100, 12, 4, -5 };
            int temp;

            for (int i = numbers.Length - 1; i >= 1; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp; }
                }
                }
            for (int i = 0; i < numbers.Length; i++);
            { Console.WriteLine("Order " + numbers[]); }

            Console.ReadLine();


        }
    }
}
