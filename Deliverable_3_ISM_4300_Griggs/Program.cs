using System;
using System.Globalization;

namespace Deliverable_3_ISM_4300_Griggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Enter a positive integer value between 1 and 100.");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Your number is " + x);

            Console.WriteLine("\n What series would you like to select? Even or Odd numbers? Enter below");
            
            string answer = Console.ReadLine();
            

            while (answer.Contains("Even"))
                { 
            Console.WriteLine("\n All even numbers between 1 and {0} are :", x);
            EvenAndOdd(2, x);
                break;
                }
            while (answer.Contains("Odd"))
            {
                Console.WriteLine("\n All odd numbers from 1 to {0} are : ", x);
                EvenAndOdd(1, x);
                break;
            }
            

            return;
        }
        static void EvenAndOdd(int stVal, int x)
        {
            while (stVal > x)
                return;
            Console.Write(" {0}  ", stVal);
            EvenAndOdd(stVal + 2, x);

        }
    }
}
