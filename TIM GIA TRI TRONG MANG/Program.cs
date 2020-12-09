using System;
using System.Text;

namespace TIM_GIA_TRI_TRONG_MANG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            string[] students = {"Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily"};
            string inputName = "";
            byte index = 0;
            bool foundOrNot = false;

            Console.Write("Nhập vào tên cần tìm kiếm: ");
            inputName = Console.ReadLine();

            for (byte i = 0; i < students.Length; i++) {
                if (students[i] == inputName) {
                    index = (byte)(i + 1);
                    foundOrNot = true;
                    break;
                }
            }
            if (foundOrNot) {
                Console.WriteLine($"Vị trí của {inputName} trong danh sách là {index}");
            } else {
                Console.WriteLine("Tên bạn nhập không tìm thấy trong danh sách.");
            }
        }
    }
}
