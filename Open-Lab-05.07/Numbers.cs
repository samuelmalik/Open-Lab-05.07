using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Open_Lab_05._07
{
    public class Numbers
    {
        public int[] RemoveSmallest(int[] nums)
        {
            List<int> numbers = nums.ToList();
            numbers.Remove(numbers.Min());
            return numbers.ToArray();
        }
    }
}
