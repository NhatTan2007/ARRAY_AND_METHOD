using System;
using System.Text;

namespace BAI_TAP_THEM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            bool checkInput = false;
            int yourChoice = 0;
            int[,] randomMatrix = new int[0,0];

            while (true)
            {
                Menu();
                do
                {
                    Console.Write("Nhập lựa chọn của bạn: ");
                    checkInput = int.TryParse(Console.ReadLine(), out yourChoice);
                } while (!checkInput || yourChoice < 0 || yourChoice > 8);

                switch (yourChoice)
                {
                    case 1:
                        int width = InputNumber("dài");
                        int height = InputNumber("cao");
                        randomMatrix = GenerateMatrix(height,width);
                        break;
                    case 2:
                        if (randomMatrix.GetLength(0) != 0) {
                            DisplayMatrix(randomMatrix);
                        } else
                        {
                            Console.WriteLine("\nBạn phải khởi tạo ma trận trước khi hiển thị");
                        }
                        break;
                    case 3:
                        if (randomMatrix.GetLength(0) != 0) {
                            Console.WriteLine($"Tổng các phần tử của ma trận đã tạo là: {SumAllElementsMatrix(randomMatrix)}");
                        } else
                        {
                            Console.WriteLine("\nBạn phải khởi tạo ma trận trước khi chọn chức năng này");
                        }
                        break;
                    case 4:
                        if (randomMatrix.GetLength(0) != 0) {
                            Console.WriteLine($"Số lượng các số nguyên tố trong ma trận đã tạo là: {TotalPrimesInArray(randomMatrix)}");
                        } else
                        {
                            Console.WriteLine("\nBạn phải khởi tạo ma trận trước khi chọn chức năng này");
                        }
                        break;
                    case 5:
                        if (randomMatrix.GetLength(0) != 0) {
                            Console.WriteLine($"Số lượng số lẻ có trong ma trận đã tạo là: {TotalOddInArray(randomMatrix)}");
                        } else
                        {
                            Console.WriteLine("\nBạn phải khởi tạo ma trận trước khi chọn chức năng này");
                        }
                        break;
                    case 6:
                        if (randomMatrix.GetLength(0) != 0)
                        {
                            Console.WriteLine($"Tổng các cạnh biên là: {SumOfElementsInSidesOfArray(randomMatrix)}");
                        }
                        else
                        {
                            Console.WriteLine("\nBạn phải khởi tạo ma trận trước khi chọn chức năng này");
                        }
                        break;
                    case 7:
                        if (randomMatrix.GetLength(0) != 0)
                        {
                            int rowInput;
                            do
                            {
                                Console.Write("Chọn hàng bạn muốn tính tích trong ma trận: ");
                                checkInput = int.TryParse(Console.ReadLine(), out rowInput);
                            } while (!checkInput || rowInput < 0 || rowInput >= randomMatrix.GetLength(0));
                            Console.WriteLine($"Tích của hàng {rowInput} là: {MultiplyInRowOfArray(randomMatrix, rowInput)}");
                        }
                        else
                        {
                            Console.WriteLine("\nBạn phải khởi tạo ma trận trước khi chọn chức năng này");
                        }
                        break;
                    case 8:
                        if (randomMatrix.GetLength(0) != 0)
                        {
                            int columnInput;
                            do
                            {
                                Console.Write("Chọn cột bạn muốn tính tích trong ma trận: ");
                                checkInput = int.TryParse(Console.ReadLine(), out columnInput);
                            } while (!checkInput || columnInput < 0 || columnInput >= randomMatrix.GetLength(1));
                            Console.WriteLine($"Tích của cột {columnInput} là: {MultiplyInColumnOfArray(randomMatrix, columnInput)}");
                        }
                        else
                        {
                            Console.WriteLine("\nBạn phải khởi tạo ma trận trước khi chọn chức năng này");
                        }
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
                
            }
            
        }

        static void Menu() {
            Console.WriteLine("-----------Menu-----------");
            Console.WriteLine("\n1. Sinh ma trận trong khoảng [10, 100]");
            Console.WriteLine("2. Hiển thị ma trận trên");
            Console.WriteLine("3. Tính tổng giá trị trong ma trận");
            Console.WriteLine("4. Số lượng số nguyên tố có trong ma trận");
            Console.WriteLine("5. Số lượng số lẻ có trong ma trận");
            Console.WriteLine("6. Tổng giá trị trên đường biên");
            Console.WriteLine("7. Tính tích các giá trị trên 1 hàng");
            Console.WriteLine("8. Tính tích các giá trị trên 1 cột");
            Console.WriteLine("0. Thoát");
        }

        static int InputNumber(string size) {
            bool checkInput = false;
            int number;
            do
            {
                Console.Write($"Nhập chiều {size} của ma trận muốn tạo: ");
                checkInput = int.TryParse(Console.ReadLine(), out number);
            } while (!checkInput);
            return number;
        }

        static int[,] GenerateMatrix(int height, int width, int minNum = 10, int maxNum = 100)
        {
            Random randomNumber = new Random();
            int[,] randomArray = new int[height, width];
            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                for (int j = 0; j < randomArray.GetLength(1); j++)
                {
                    randomArray[i,j] = randomNumber.Next(minNum,maxNum + 1);
                }
            }
            return randomArray;
        }

        static void DisplayMatrix(int[,] array){
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i,j]}, ");
                }
                Console.Write("\n");
            }
        }

        static int SumAllElementsMatrix(int[,] array){
            int sumTotal = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sumTotal += array[i,j];
                }
            }
            return sumTotal;
        }

        static int TotalPrimesInArray(int[,] array){
            int countPrimes = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (IsPrime(array[i,j])) countPrimes++;
                }
            }
            return countPrimes;
        }

        static bool IsPrime(int number) 
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0) return false;
            }
            return true;
        }

        static int TotalOddInArray(int[,] array){
            int countOdd = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] % 2 != 0) countOdd++;
                }
            }
            return countOdd;
        }
        static int SumOfElementsInSidesOfArray(int[,] array)
        {
            int totalSumSide = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i == 0 || i == array.GetLength(0) - 1) || (i != 0 && i != array.GetLength(0) - 1) && (j == 0 || j == array.GetLength(1) - 1))
                    {
                        totalSumSide += array[i, j];
                    }
                }
            }
            return totalSumSide;
        }

        static ulong MultiplyInRowOfArray(int[,] array, int row)
        {
            ulong multiplyRow = 1;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                multiplyRow *= (ulong)array[row,i];
            }
            return multiplyRow;
        }

        static ulong MultiplyInColumnOfArray(int[,] array, int column)
        {
            ulong multiplyColumn = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                multiplyColumn *= (ulong)array[i, column];
            }
            return multiplyColumn;
        }
    }
}
