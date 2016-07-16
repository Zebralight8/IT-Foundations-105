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
            Console.WriteLine("Provide the month in number form (1-12): ");
            String strMonth;
            strMonth = Console.ReadLine();

            string Month;
            int MonthDays;

            switch (strMonth)
            {
                case "1":
                    Month = "January";
                    MonthDays = 31;
                    break;

                case "2":
                    Month = "February";
                    MonthDays = 29;
                    break;

                case "3":
                    Month = "March";
                    MonthDays = 30;
                    break;

                default:
                    Month = "What the F?";
                    MonthDays = 8;
                    break;
            }
            Console.WriteLine("The month {0} has {1} days.", Month, MonthDays);
            Console.ReadLine();       
            }

        }
        }

            
        
        
            

         
    
       

