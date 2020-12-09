using System;

namespace THAO_TAC_VOI_MANG
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sampleArray = new int[5]{93,2,7,3,8};
            int sumArrayElements = 0;
            foreach (int value in sampleArray)
            {
                sumArrayElements += value;
                Console.Write($"{value} - ");
            }
            Console.WriteLine($"\nSum is {sumArrayElements}");
        }

    }
}
