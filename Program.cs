using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lowest_Expense_Identifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Monthly Expense for Transportation:");
            double tExp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Monthly Expense for Stationery:");
            double sExp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter monthly Expense for Entertainment:");
            double eExp = Convert.ToDouble(Console.ReadLine());
            if (tExp < sExp)
            {
                if (tExp < eExp)
                {
                    Console.WriteLine("Your Transportation Expense is the lowest of all expenses.");
                }
                else
                {
                    Console.WriteLine("Your Entertainment Expense is the lowest of all expenses.");
                }
            }
            else
            {
                if (sExp < eExp)
                {
                    Console.WriteLine("Your Stationery Expense is the lowest of all expenses.");
                }
                else
                {
                    Console.WriteLine("Your Entertainment Expense is the lowest of all expenses.");
                }
            }
        }
    }
}
