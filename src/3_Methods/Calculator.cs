using System;

namespace _3_Methods
{
    public class Calculator
    {
        //Added params to make easier for the user of the add menthod of the claculator class so he/she wouldnt need to do the full initialization of the int array, but rather just pass the values of the int arrays.
        public int Add(params int[] numbers)
        {
            
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}