using System;
using System.Text;

namespace DEM_SO_LAN_KY_TU_TRONG_CHUOI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string inputString;
            char inputChar;
            uint countTimesCharInString = 0;

            Console.Write("Nhập vào 1 chuỗi bất kỳ: ");
            inputString = Console.ReadLine();

            Console.Write("Nhập vào 1 ký tự bất kỳ: ");
            inputChar = Console.ReadLine()[0];

            foreach (char value in inputString)
            {
                if (inputChar == value) countTimesCharInString++;
            }
            Console.WriteLine($"Số lần xuất hiện ký tự '{inputChar}' trong chuỗi đã nhập là {countTimesCharInString}");
        }
    }
}
