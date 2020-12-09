using System;
using System.Text;

namespace DEM_SO_LUONG_SV_THI_DO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            byte sizeOfArray;
            byte[] markOfStudents;
            bool checkInput = false;
            Random randomMark = new Random();
            byte countStudentsPass = 0;

            do
            {
                Console.Write("Nhập số lượng học sinh (không vượt quá 40 người/lớp): ");
                checkInput = byte.TryParse(Console.ReadLine(), out sizeOfArray);
            } while (!checkInput || sizeOfArray <= 0 || sizeOfArray > 40);

            markOfStudents = new byte[sizeOfArray];
            for (byte i = 0; i < sizeOfArray; i++)
            {
                markOfStudents[i] = (byte)randomMark.Next(0, 11);
            }

            Console.Write("Bảng điểm của sinh viên là: ");
            foreach (byte value in markOfStudents)
            {
                if (value >= 5) countStudentsPass++;
                Console.Write($"{value}, ");
            }

            
            Console.WriteLine($"\nSố sinh viên thi đỗ là {countStudentsPass}");

        }
    }
}
