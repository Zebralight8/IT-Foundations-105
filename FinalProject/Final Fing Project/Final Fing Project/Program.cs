using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        struct ItemData
        {
            public int iIDNo;
            public string sDescription;
            public double dblPricePerItem;
            public int iQuantityOnHand;
            public double dblOurCostPerItem;
            public double dblValueOfItem;
        }

        static void Main(string[] args)
        {
            int iCount = 0;
            ItemData[] array = new ItemData[100];
            bool bExit = false;
            bool bExists;
            int iSelection;

            while (bExit == false)
            {
                Console.WriteLine("1. Add an item");
                Console.WriteLine("2. Change and item");
                Console.WriteLine("3. Delete an item");
                Console.WriteLine("4. List all items in the database");
                Console.WriteLine("5. Quit");
                Console.WriteLine();
                Console.Write("Please choose an option from the list (1, 2, 3, 4, or 5): ");

                iSelection = int.Parse(Console.ReadLine());

                switch (iSelection)
                {
                    case 1:
                        bExists = false;
                        if (iCount == 100)
                        {
                            Console.WriteLine("Sorry, inventory is full.");
                        }
                        else
                        {
                            Console.Write("Please enter a 3 digit ID: ");
                            int iNewID = int.Parse(Console.ReadLine());

                            for (int i = 0; i < iCount; i++)
                            {
                                if (array[i].iIDNo == iNewID)
                                {
                                    bExists = true;
                                    Console.WriteLine("Sorry, item already exists.");
                                    break;
                                }
                            }
                            if (bExists == false)
                            {
                                iCount++;
                                array[iCount - 1].iIDNo = iNewID;
                                Console.Write("Please enter the description: ");
                                array[iCount - 1].sDescription = Console.ReadLine();

                                Console.Write("Please enter the price in $: ");
                                array[iCount - 1].dblPricePerItem = double.Parse(Console.ReadLine());

                                Console.Write("Please enter the quantity: ");
                                array[iCount - 1].iQuantityOnHand = int.Parse(Console.ReadLine());

                                Console.Write("Please enter the cost in $: ");
                                array[iCount - 1].dblOurCostPerItem = double.Parse(Console.ReadLine());

                                array[iCount - 1].dblValueOfItem = array[iCount - 1].dblPricePerItem * array[iCount - 1].iQuantityOnHand;
                            }
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        bExists = false;
                        Console.Write("Please enter a 3 digit ID: ");
                        int iUpdateID = int.Parse(Console.ReadLine());

                        for (int i = 0; i < iCount; i++)
                        {
                            if (array[i].iIDNo == iUpdateID)
                            {
                                Console.Write("Please enter the description: ");
                                array[i].sDescription = Console.ReadLine();
                                Console.Write("Please enter the price in $: ");
                                array[i].dblPricePerItem = double.Parse(Console.ReadLine());
                                Console.Write("Please enter the quantity: ");
                                array[i].iQuantityOnHand = int.Parse(Console.ReadLine());
                                Console.Write("Please enter the cost in $: ");
                                array[i].dblOurCostPerItem = double.Parse(Console.ReadLine());

                                array[i].dblValueOfItem = array[i].dblPricePerItem * array[i].iQuantityOnHand;
                                Console.WriteLine();

                                bExists = true;
                                break;
                            }
                        }
                        if (bExists == false)
                        {
                            Console.WriteLine("Please enter an item that exists.");
                            Console.WriteLine();
                        }
                        break;

                    case 3:

                        bExists = false;                  
                        int iIndex = 0;

                        Console.Write("Please enter a 3 digit ID: ");
                        int iRemoveID = int.Parse(Console.ReadLine());

                        for (int i = 0; i < iCount; i++)
                        {
                            if (array[i].iIDNo == iRemoveID)
                            {
                                iIndex = i;
                                bExists = true;
                                break;
                            }
                        }

                        if (bExists == true)
                        {
                            for (int i = iIndex; i < iCount; i++)
                            {
                                Console.WriteLine("Item deleted");
                                array[i].iIDNo = array[i + 1].iIDNo;
                                array[i].sDescription = array[i + 1].sDescription;
                                array[i].dblPricePerItem = array[i + 1].dblPricePerItem;
                                array[i].iQuantityOnHand = array[i + 1].iQuantityOnHand;
                                array[i].dblOurCostPerItem = array[i + 1].dblOurCostPerItem;
                                array[i].dblValueOfItem = array[i + 1].dblValueOfItem;
                            }
                            iCount--;
                        }
                        else
                        {
                            Console.WriteLine("Item {0} not found", iRemoveID);
                        }
                        Console.WriteLine();

                        break;

                    case 4:

                        if (iCount > 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("\tItem\tDesc\t\tPrice\tCost\tQty\tValue");

                            for (int i = 0; i < iCount; i++)
                            {
                                string sOut = (i + 1).ToString() + ". \t";
                                sOut += array[i].iIDNo.ToString() + "\t";
                                sOut += array[i].sDescription + "\t\t";
                                sOut += array[i].dblPricePerItem.ToString("C") + "\t";
                                sOut += array[i].dblOurCostPerItem.ToString("C") + "\t";
                                sOut += array[i].iQuantityOnHand.ToString() + "\t";
                                sOut += array[i].dblValueOfItem.ToString("C") + "\t";

                                Console.WriteLine(sOut);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please add items first.");
                        }
                        Console.WriteLine();
                        break;

                    case 5:
                        bExit = true;
                        break;

                    default:

                        Console.WriteLine("Please type a number between 1 and 6, next time.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}