using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingMinorOrEqualNumbersBetweenArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numsStr = Console.ReadLine().Split(',');
            string[] maxesStr = Console.ReadLine().Split(',');

            int[] nums = numsStr.Select(int.Parse).ToArray();
            int[] maxes = maxesStr.Select(int.Parse).ToArray();

            var result = maxes.Select(m => nums.Count(n => (n <= m))).ToArray();

            Console.WriteLine(String.Join(",", result));
            Console.ReadLine();
        }
    }
}
