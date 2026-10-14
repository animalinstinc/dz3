using System;
namespace n3_1
{
    class Program
    {
        static void Main()
        {
            int[] numbers = [1, 2, 3, 4, 7, 8, 10];
            int pos = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    pos = i + 1;
                    break;
                }
            }
            Console.WriteLine(pos);
        }
    } 
}