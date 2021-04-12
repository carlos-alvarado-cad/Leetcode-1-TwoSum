using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test1 = { 3,5,5,2,4};
            int[] result = TwoSum(test1, 10);
            foreach (int num in result)
            {
                Console.Write(num + ", ");
            }
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] sumNums = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        sumNums[0] = i;
                        sumNums[1] = j;
                        return sumNums;
                    }
                    else continue;
                }
            }
            return sumNums;
        }
    }
}
