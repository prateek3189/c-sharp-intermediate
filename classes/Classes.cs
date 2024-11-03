using System;

namespace Constructors
{
    public class Calculator
    {
        // Method Overloading - Array Parameters
        public int Add(params int[] numbers)
        {
            var result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }
    }
}
