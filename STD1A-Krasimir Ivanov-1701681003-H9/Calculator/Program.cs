using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            string otgovor;
            string opr;




            do
            {
                Console.WriteLine("Do you want to calculate some numbers (yes or no)");
                otgovor = Console.ReadLine();


                if (otgovor == "yes")
                {
                    Console.WriteLine("Enter the first number");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number ");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter an operator (+,-,*,/) ");
                    opr = Console.ReadLine();
                    if (opr == "+")
                    {
                        Console.WriteLine((a + b) * 0.1 + (a + b));
                    }
                    else if (opr == "-")
                    {
                        if (a > b)
                        {
                            Console.WriteLine((a * a) - b);
                        }
                        else
                        {
                            Console.WriteLine((b * b) - a);
                        }

                    }
                    else if (opr == "*")
                    {
                        Console.WriteLine(a * (b * b));
                    }
                    else if (opr == "/")
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("You cannot divide by 0 ");
                        }
                        else if (b != 0)
                        {
                            Console.WriteLine(a / b);
                        }
                    }
                }

            }
            while (otgovor == "yes");
            if (otgovor == "no")
            {
                Console.WriteLine("Okey bye .");
            }
            else if (otgovor !="yes" && otgovor !="no")
            {
                Console.WriteLine("That's not a valid respond");
            }
                
        }
    }
}
