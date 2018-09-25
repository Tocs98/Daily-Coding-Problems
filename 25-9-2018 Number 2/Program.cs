using System;

namespace ConsoleApp1
{
    class Program
    {
        static int[] calculateProduct(int[] numbers)
        {
            int[] finalArray = new int[numbers.Length];
            int result = 1;

            for(int i=0; i<numbers.Length; i++)
            {
                for(int x = 0; x < numbers.Length; x++)
                {
                    if (i != x)
                    {
                        result = result * numbers[x];
                    }
                }
                finalArray[i] = result;
                result = 1;
            }
            return finalArray;
        }

        static void Main(string[] args)
        {
            int[] numbersToCalculate = new int[] { 3, 2, 1 };
            Console.Write(string.Join(" ",calculateProduct(numbersToCalculate)));
            Console.ReadLine();
        }
    }
}
