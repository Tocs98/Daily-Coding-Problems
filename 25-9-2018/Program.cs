using System;

namespace ConsoleApp1
{
    class Program
    {

        static int checkNums(int[] nums, int res)
        {
            for(int i=0; i < nums.Length; i++)
            {
                if (i != nums.Length - 1)
                {
                    for(int z = i + 1; z < nums.Length; z++)
                    {
                        if(nums[i]+nums[z] == res)
                        {
                            Console.Write(nums[i]+"+"+nums[z] + " " + res);
                            return 1;
                        }
                    }
                }
                else
                {
                    Console.Write("No possible combination");
                }
            }
            return 0;
        }

        static void Main(string[] args)
        {
            int[] numbers = new int[4];
            numbers.SetValue(-10, 0);
            numbers.SetValue(15, 1);
            numbers.SetValue(3, 2);
            numbers.SetValue(2, 3);

            int k = 17;

            checkNums(numbers, k);
            Console.ReadLine();
        }
    }
}
