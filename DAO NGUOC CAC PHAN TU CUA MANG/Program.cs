using System;
using System.Text;

namespace DAO_NGUOC_CAC_PHAN_TU_CUA_MANG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            int[] randomArray;
            Random objrandom = new Random();
            uint sizeArray;
            bool checkInput = false;
            
            do
            {
                Console.Write("Nhập vào kích thước của mảng cần tạo: ");
                checkInput = uint.TryParse(Console.ReadLine(), out sizeArray);
            } while (!checkInput || sizeArray < 0);
            randomArray = new int[sizeArray];
            for (uint i = 0; i < sizeArray; i++)
            {
                randomArray[i] = objrandom.Next(200);
            }
            Console.Write("Mảng đã tạo là: ");
            foreach (uint value in randomArray)
            {
                Console.Write($"{value}, ");
            }

            ReservedArray(ref randomArray);

            Console.Write("\nMảng đã đảo ngược là: ");
            foreach (uint value in randomArray)
            {
                Console.Write($"{value}, ");
            }
        }

        static void ReservedArray(ref int[] array)
        {
            int[] tempArray = new int[array.Length];
            for (uint i = 0, j = (uint)(array.Length - 1); i < array.Length; i++, j--)
            {
                tempArray[i] = array[j];
            }
            array = tempArray;
        }
    }
}
