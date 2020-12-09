using System;
using System.Text;

namespace TONG_DUONG_CHEO_CHINH_MATRIX_VUONG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            bool checkInput = false;
            int sizeSquareMatrix;
            int[,] randomMatrix;
            Random randomNumber = new Random();
            int sumElementsInMainDiagonal = 0;

            do
            {
                Console.Write("Nhập vào kích cỡ của ma trận vuông: ");
                checkInput = int.TryParse(Console.ReadLine(), out sizeSquareMatrix);
            } while (!checkInput || sizeSquareMatrix <= 0);

            randomMatrix = new int[sizeSquareMatrix, sizeSquareMatrix];
            Console.WriteLine("Ma trận vuông đã tạo: ");
            for (int i = 0; i < randomMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < randomMatrix.GetLength(1); j++)
                {
                    randomMatrix[i, j] = randomNumber.Next(10, 201);
                    Console.Write($"{randomMatrix[i, j]}, ");
                    if (i == j) sumElementsInMainDiagonal += randomMatrix[i, j];
                }
                Console.Write("\n");
            }

            Console.WriteLine($"Tổng các số đường chéo chính ma trận vuông đã tạo: {sumElementsInMainDiagonal}");



        }
    }
}
