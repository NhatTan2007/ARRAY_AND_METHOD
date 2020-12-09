using System;
using System.Text;
namespace TIM_MAX_TRONG_ARRAY
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
            double maxOfProperty = 0;

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
            foreach (int value in propertyOfBillionaires)
            {
                if (maxOfProperty < value) maxOfProperty = value;
                Console.Write($"{value}, ");
            }

            Console.WriteLine($"\nGiá trị tài sản cao nhất là {maxOfProperty}");
        }
    }
}
