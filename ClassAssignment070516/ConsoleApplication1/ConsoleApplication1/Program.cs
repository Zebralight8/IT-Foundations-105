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
            int x = 0;
            int y = 1;

            // Equals checks if the two objects are equal
            if (x.Equals(y))
            {
                Console.WriteLine("x and y are equal");
            }

            // GetType is used to return what type
            // the object is.
            Type type = x.GetType();
            Console.WriteLine("The type's name is {0}", type.FullName);

            // ToString converts the type into a string
            Console.WriteLine("x is {0}", x.ToString());

            // But since all objects support ToString
            // the following works as well. WriteLine
            // simply calls ToString for you.
            Console.WriteLine("x is {0}", x);


        }
    }
}
