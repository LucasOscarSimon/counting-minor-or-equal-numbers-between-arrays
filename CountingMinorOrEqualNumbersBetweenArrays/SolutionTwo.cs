using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingMinorOrEqualNumbersBetweenArrays
{
    class SolutionTwo
    {
        static int[] CountNumbers(int[] nums, int[] maxes)
        {
            var result = new int[maxes.Count()];
            for (int max = 0; max < maxes.Count(); max++)
            {
                for (int num = 0; num < nums.Count(); num++)
                {
                    if (nums[num] <= maxes[max])
                        result[max] = result[max] + 1;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            string[] maxes = Console.ReadLine().Split(' ');

            int[] numsArr = nums.Select(int.Parse).ToArray();
            int[] maxesArr = maxes.Select(int.Parse).ToArray();

            var result = CountNumbers(numsArr, maxesArr);

            Console.WriteLine(String.Join(" ", result));
            Console.ReadLine();
        }
    }
}
