using System;
using System.Text;
namespace TIM_MIN_TRONG_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            byte sizeOfArray = 0;
            int[] propertyOfBillionaires;
            Random randomProperty = new Random();
            bool checkInput = false;

            do
            {
                Console.Write("Nhập vào số lượng tỉ phú (tối đa 20 người): ");
                checkInput = byte.TryParse(Console.ReadLine(), out sizeOfArray);
            } while (!checkInput | sizeOfArray <= 0 | sizeOfArray > 20);

            propertyOfBillionaires = new int[sizeOfArray];
            for (byte i = 0; i < sizeOfArray; i++)
            {
                propertyOfBillionaires[i] = (int)randomProperty.Next(1, 501);
            }
            Console.Write("Giá trị tài sản các tỉ phú: ");

            Console.WriteLine($"\nGiá trị tài sản thấp nhất là {MinValue(propertyOfBillionaires)}");
        }

        static int MinValue(int[] array)
        {
            int minValue = array[0];
            foreach (int value in array)
            {
                if (minValue > value) minValue = value;
                Console.Write($"{value}, ");
            }
            return minValue;
        }
    }
}
