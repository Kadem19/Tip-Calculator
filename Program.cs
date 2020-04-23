using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.WriteLine("Welcome to the Tip Calculator!\n");
                    decimal billAmount;
                    Console.WriteLine("How much is your bill?");
                    billAmount = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("\nHow much would like to tip?\n(enter corresponding number)\n");
                    Console.WriteLine("1: 10 %");
                    Console.WriteLine("2: 15 %");
                    Console.WriteLine("3: 20 %");
                    Console.WriteLine("4: Even Tip");
                    Console.WriteLine("5: Custom");
                    string tipChoice;
                    tipChoice = Console.ReadLine();
                    Console.WriteLine();
                    decimal tipAmount;
                    decimal totalBill;
                    decimal evenAmount;

                    if (tipChoice == "1")
                    {
                        tipAmount = billAmount * 0.10m;
                        totalBill = tipAmount + billAmount;
                        string tip = tipAmount.ToString("C2");
                        string bill = totalBill.ToString("C2");
                        Console.WriteLine("A 10 % tip is {0}\n \nYour total bill with a tip is {1}", tip, bill);
                        break;
                    }

                    else if (tipChoice == "2")
                    {
                        tipAmount = billAmount * 0.15m;
                        totalBill = tipAmount + billAmount;
                        string tip = tipAmount.ToString("C2");
                        string bill = totalBill.ToString("C2");
                        Console.WriteLine("A 15 % tip is {0}\n \nYour total bill with a tip is {1}", tip, bill);
                        break;
                    }

                    else if (tipChoice == "3")
                    {
                        tipAmount = billAmount * 0.20m;
                        totalBill = tipAmount + billAmount;
                        string tip = tipAmount.ToString("C2");
                        string bill = totalBill.ToString("C2");
                        Console.WriteLine("A 20 % tip is {0}\n \nYour total bill with a tip is {1}", tip, bill);
                        break;
                    }

                    else if (tipChoice == "4")
                    {
                        Console.WriteLine("What amount would you like to leave?");
                        evenAmount = decimal.Parse(Console.ReadLine());
                        tipAmount = evenAmount - billAmount;
                        string tip = tipAmount.ToString("C2");
                        string billAmount1 = billAmount.ToString("C2");
                        string totBill = evenAmount.ToString("C2");
                        Console.WriteLine("If you leave {0} for a bill of {1}.\nYour tip will be {2}.", totBill, billAmount1, tip);
                        break;
                    }

                    else if (tipChoice == "5")
                    {
                        Console.WriteLine("\n Enter your custom tip percentage:\n(like 0.23 for 23 percent)");
                        decimal customTip = decimal.Parse(Console.ReadLine());
                        tipAmount = billAmount * customTip;
                        totalBill = tipAmount + billAmount;
                        string tip = tipAmount.ToString("C2");
                        string bill = totalBill.ToString("C2");
                        Console.WriteLine("Your tip is {0}\n \nYour total bill with a tip is {1}", tip, bill);
                        break;
                    }

                    else
                    {
                        Console.WriteLine("That is not a valid choice!! Try again");
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Oops please follow the directions\n");
                }

                catch (OverflowException oe)
                {
                    Console.WriteLine("Come on there is no way your bill was that much!!\n");
                }

                catch(Exception e)
                {
                    Console.WriteLine("Oops, something didn't work right!\n");
                }
                ;
            } while (true);
        }
    }
}
