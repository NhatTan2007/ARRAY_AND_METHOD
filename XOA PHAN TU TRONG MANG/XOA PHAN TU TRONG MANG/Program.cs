using System;
using System.Text;

namespace XOA_PHAN_TU_TRONG_MANG
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
            int numberToDel;

            do
            {
                Console.Write("Nhập vào số lượng phần tử của mảng: ");
                checkInput = uint.TryParse(Console.ReadLine(), out sizeOfArray);
            } while (!checkInput | sizeOfArray <= 0);

            sampleArray = new int[sizeOfArray];
            for (uint i = 0; i < sizeOfArray; i++)
            {
                sampleArray[i] = randomNumber.Next(1, 10);
            }

            Console.Write("Dãy số đã tạo là: ");
            foreach (uint value in sampleArray)
            {
                Console.Write($"{value}, ");
            }

            do
            {
                Console.Write("\nNhập vào giá trị cần xóa: ");
                checkInput = int.TryParse(Console.ReadLine(), out numberToDel);
            } while (!checkInput);

            int countNumberErase = 0;
            bool isHaveNumberToDel;

            foreach (uint value in sampleArray)
            {
                if (value == numberToDel)
                {
                    countNumberErase++;
                }
            }
            
            do
            {
                isHaveNumberToDel = false;
                foreach (uint value in sampleArray)
                {
                    if (value == numberToDel)
                    {
                        isHaveNumberToDel = true;
                    }
                }

                for (uint i = 0; i < sampleArray.Length; i++)
                {
                    if (sampleArray[i] == numberToDel)
                    {
                        sampleArray[i] = 0;
                        for (uint j = i; j < sampleArray.Length - 1; j++)
                        {
                            sampleArray[j] = sampleArray[j + 1];
                        }
                    }
                }

            } while (isHaveNumberToDel);
            Array.Resize(ref sampleArray, sampleArray.Length - countNumberErase);

            Console.Write($"\nDãy số đã xóa {numberToDel} là: ");
            foreach (uint value in sampleArray)
            {
                Console.Write($"{value}, ");
            }





        }
    }
}
