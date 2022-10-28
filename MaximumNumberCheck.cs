using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumberProject1
{
    
        public class MaximumNumberCheck
        {
            public static int MaximumIntegerNumber1(int firstValue, int secondValue, int thirdValue)
            {
                if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                {
                    return + firstValue;
                }
                else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                {
                    return + secondValue;
                }
                if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                {
                    return + thirdValue;
                }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");

        }

        }
    }
