using System;
using System.Text;

namespace GOP_MANG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            bool checkInput = false;
            uint sizeOfArray1 = 0;
            uint sizeOfArray2 = 0;
            int[] sampleArray1;
            int[] sampleArray2;
            int[] resultArray;
            Random randomNumber = new Random();

            do
            {
                Console.Write("Nhập vào kích thước mảng số 1: ");
                checkInput = uint.TryParse(Console.ReadLine(), out sizeOfArray1);
            } while (!checkInput || sizeOfArray1 <= 0);

            do
            {
                Console.Write("Nhập vào kích thước mảng số 2: ");
                checkInput = uint.TryParse(Console.ReadLine(), out sizeOfArray2);
            } while (!checkInput || sizeOfArray2 <= 0);

            sampleArray1 = new int[sizeOfArray1];
            sampleArray2 = new int[sizeOfArray2];
            resultArray = new int[sizeOfArray1 + sizeOfArray2];

            for (uint i = 0; i < sizeOfArray1; i++)
            {
                sampleArray1[i] = randomNumber.Next(301);
            }

            for (uint i = 0; i < sizeOfArray2; i++)
            {
                sampleArray2[i] = randomNumber.Next(301);
            }

            for (uint i = 0; i < sizeOfArray1; i++)
            {
                resultArray[i] = sampleArray1[i];
            }

            Console.Write(resultArray.Length);
            Console.Write(sizeOfArray1);
            for (uint i = (uint)sizeOfArray1, j = 0; i < resultArray.Length; i++, j++)
            {
                resultArray[i] = sampleArray2[j];
                
            }
            Console.WriteLine("\nMảng số 1 đã tạo là: ");
            foreach (int value in sampleArray1)
            {
                Console.Write($"{value}, ");
            }

            Console.WriteLine("\nMảng số 2 đã tạo là: ");
            foreach (int value in sampleArray2)
            {
                Console.Write($"{value}, ");
            }

            Console.WriteLine("\nMảng mới sau khi nối mảng 1 và 2 là: ");
            foreach (int value in resultArray)
            {
                Console.Write($"{value}, ");
            }
        }
    }
}
