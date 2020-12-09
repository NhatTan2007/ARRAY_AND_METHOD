using System;
using System.Text;

namespace THEM_PHAN_TU_VAO_MANG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            bool checkInput = false;
            uint sizeOfArray = 0;
            int[] sampleArray;
            Random randomNumber = new Random();
            int numberToAdd;
            uint indexToAdd;

            do
            {
                Console.Write("Nhập vào số lượng phần tử của mảng: ");
                checkInput = uint.TryParse(Console.ReadLine(), out sizeOfArray);
            } while (!checkInput | sizeOfArray <= 0);

            sampleArray = new int[sizeOfArray];
            for (uint i = 0; i < sizeOfArray; i++)
            {
                sampleArray[i] = randomNumber.Next(500);
            }

            do
            {
                Console.Write("Nhập vào giá trị cần chèn: ");
                checkInput = int.TryParse(Console.ReadLine(), out numberToAdd);
            } while (!checkInput);

            do
            {
                Console.Write("Nhập vào vị trí cần chèn: ");
                checkInput = uint.TryParse(Console.ReadLine(), out indexToAdd);
            } while (!checkInput);

            Console.Write("Dãy số đã tạo là: ");
            foreach (uint value in sampleArray)
            {
                Console.Write($"{value}, ");
            }

            if (indexToAdd <= 1 || indexToAdd >= sizeOfArray - 1)
            {
                Console.WriteLine("Không chèn được phần tử vào mảng");
            } else
            {
                Array.Resize(ref sampleArray, sampleArray.Length + 1);
                for (int i = sampleArray.Length - 1; i > indexToAdd; i--)
                {
                    sampleArray[i] = sampleArray[i - 1];
                }
                sampleArray[indexToAdd] = numberToAdd;
            }

            Console.Write($"\nDãy số đã chèn thêm {numberToAdd} tại vị trí {indexToAdd} là: ");
            foreach (uint value in sampleArray)
            {
                Console.Write($"{value}, ");
            }





        }
    }
}
