using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int[] numbers = new int[10];
            //int[] numbers = new int[10];
            //do{




            //   Console.WriteLine("Enter number :");
            //        numbers[i] = int.Parse(Console.ReadLine());

            //        if (numbers[i] <= 0 && numbers[i] > 255)
            //    {
            //        Console.WriteLine("The numbers are not in the diapasone 1-255");
            //    }
            //    else if (numbers[i] >= 1 && numbers[i] <= 255 && numbers[i] %2==0)
            //    {

            //    }

            //}while numbers

            int n;
            int sum = 0;
            int evencount = 0;
            do {
                Console.WriteLine("Enter number");
                n = int.Parse(Console.ReadLine());
                if (n < 1)
                    break;

                if (n > 255)
                    break;

                if (n % 2 == 0)
                { 
                    sum += n;
                    evencount++;
                }
                    
                
            }
            while (n != 0);

            Console.WriteLine("Average of even numbers :" + (sum/evencount));
        }
    }
}
