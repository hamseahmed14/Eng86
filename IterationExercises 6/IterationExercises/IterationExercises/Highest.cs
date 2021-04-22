using System;
using System.Linq;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            // this method should use a while loop
            //var result = 0;
            //var i = 0;
            //while (i < nums.Length)
            //{
            //    if (result < nums[i])
            //    {
            //        result = nums[i];
            //    }
            //    i++;
            //}
            //return result;

            return nums.Max();
        }

        public static int HighestForLoop(int[] nums)
        {
            // this method should use a for loop
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (result < nums[i])
                {
                    result = nums[i];
                }
            }

            return result;
        }


        public static int HighestForEachLoop(int[] nums)
        {
            // this method should use a for-each loop
            var result = 0;
            foreach (var item in nums)
            {
                if(result < item)
                {
                    result = item;
                }
            }

            return result;
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            // this method should use a do-while loop
            var result = 0;
            int i = 0;
            do
            {
                if (result < nums[i])
                {
                    result = nums[i];
                }
                i++;
            } while (i < nums.Length);
            return result;
        }
    }
}