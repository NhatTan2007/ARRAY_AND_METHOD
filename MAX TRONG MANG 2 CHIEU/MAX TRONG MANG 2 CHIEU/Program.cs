using System;
using System.Text;

namespace MAX_TRONG_MANG_2_CHIEU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Random randomNumber = new Random();
            byte sizeOfArray;
            bool checkInput = false;
            int[][] sampleArray;
            int maxOfArray = 0;

            do
            {
                Console.Write("Nhập vào kích cỡ của mảng hai chiều: ");
                checkInput = byte.TryParse(Console.ReadLine(), out sizeOfArray);
            } while (!checkInput || sizeOfArray <= 0);

            sampleArray = new int[sizeOfArray][];
            for (int i = 0; i < sizeOfArray; i++)
            {
                sampleArray[i] = new int[sizeOfArray];
                for (int j = 0; j < sizeOfArray; j++)
                {
                    sampleArray[i][j] = randomNumber.Next(501);
                }
            }
            Console.WriteLine("Mảng 2 chiều đã tạo là: ");
            foreach (int[] value in sampleArray)
            {
                foreach (int item in value)
                {
                    if (maxOfArray < item) maxOfArray = item;
                    Console.Write($"{item}, ");
                }
                Console.Write("\n");
            }

            Console.Write($"Phần tử lớn nhất trong mảng 2 chiều đã tạo là: {maxOfArray}");
        }
    }
}
