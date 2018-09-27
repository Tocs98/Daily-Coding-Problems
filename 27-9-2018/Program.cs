using System;

namespace ConsoleApp1
{
    class Program
    {
        static int firstMissingPositive(int[] numbers)
        {
            int lowerNumber = 0;

            for(int i = 0; i < numbers.Length; i++) //Looking for the lowest number posible in the array
            {
                if(numbers[i] >= 0 && lowerNumber > numbers[i]) //Positive number
                {
                    lowerNumber = numbers[i]; 
                }
            }

            for(int x = 0; x < numbers.Length; x++)
            {
                if(numbers[x] >= 0 && lowerNumber +1 == numbers[x]) // Lowest positive integer that does not exist in the array
                {
                    lowerNumber = numbers[x];
                    x = 0;
                }
            }
            return lowerNumber+1;
        }

        static void Main(string[] args)
        {
            int[] numbersToCalculate = new int[] { 1, 2, 0, -5, 10 };
            Console.Write(firstMissingPositive(numbersToCalculate));
            Console.ReadLine();
        }
    }
}
