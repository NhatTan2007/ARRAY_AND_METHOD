using System;
using System.Text;

namespace SUM_1_COLUMN_XAC_DINH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding  = Encoding.UTF8;
            Console.OutputEncoding  = Encoding.UTF8;

            int sizeOfArray;
            bool checkInput = false;
            float[,] sampleArray;
            Random randomNumber = new Random();
            int indexColumnToSum;
            float sumColumn = 0;

            do
            {
                Console.Write("Nhập kích thước của mảng 2 chiều: ");
                checkInput = int.TryParse(Console.ReadLine(), out sizeOfArray);
            } while (!checkInput || sizeOfArray <= 0);

            do
            {
                Console.Write("Nhập cột bạn muốn tính tổng: ");
                checkInput = int.TryParse(Console.ReadLine(), out indexColumnToSum);
            } while (!checkInput || indexColumnToSum < 0);

            sampleArray = new float[sizeOfArray,sizeOfArray];

            Console.WriteLine("Mảng đã tạo là:");
            for (int i = 0; i < sizeOfArray; i++)
            {
                for (int j = 0; j < sizeOfArray; j++)
                {
                    sampleArray[i,j] = (float)(randomNumber.NextDouble()*301 + 1);
                    if (j == indexColumnToSum) sumColumn += sampleArray[i,j];
                    Console.Write($"{sampleArray[i,j]}, ");
                }
                Console.Write("\n");
            }

            Console.Write($"\nTổng cột {indexColumnToSum} là: {sumColumn}");




        }
    }
}
