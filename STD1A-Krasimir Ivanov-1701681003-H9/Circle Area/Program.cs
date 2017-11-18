using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
          Random random=new Random();
            int r=random.Next(33,187);
            double pi=3.14;

            Console.WriteLine("The circle random hight is "+ r);
            Console.WriteLine("The area of  e circle is " + pi*(r*2));


            }
        
    }
}
