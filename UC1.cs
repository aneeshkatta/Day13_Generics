using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumberProject1
{
    class UC1
    {
        

            public static void Main(string[] args)
            {
                
                Console.WriteLine("Enter The First Number");
                int firstValue = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter The Second Number");
                int secondValue = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter The Third Number");
                int thirdValue = Convert.ToInt32(Console.ReadLine());

               MaximumNumberCheck.MaximumIntegerNumber1(firstValue, secondValue, thirdValue);

            }

        
    }
}


