using System;

namespace TIM_MIN_TRONG_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray;
            bool checkInput = false;
            int[] sampleArray;
            Random randomNumber = new Random();
            int minOfArray;

            do
            {
                Console.Write("Nhập vào kích thước của mảng: ");
                checkInput = int.TryParse(Console.ReadLine(), out sizeOfArray);
            } while (!checkInput || sizeOfArray <= 0);

            sampleArray = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                sampleArray[i] = randomNumber.Next(1,300);
            }

            minOfArray = sampleArray[0];
            Console.WriteLine("Mảng đã tạo là: ");
            foreach (int value in sampleArray)
            {
                if(minOfArray > value) minOfArray = value;
                Console.Write($"{value}, ");
            }

            
            Console.WriteLine($"\nGiá trị nhỏ nhất của mảng là {minOfArray}");
        }
    }
}
