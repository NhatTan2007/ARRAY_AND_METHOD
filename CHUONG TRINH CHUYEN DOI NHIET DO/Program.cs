using System;
using System.Text;

namespace CHUONG_TRINH_CHUYEN_DOI_NHIET_DO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            double inputNumber = 0;
            bool checkInput = false;
            byte choiceOfGuest;

            Console.WriteLine("[Thực hành] Chương trình chuyển đổi nhiệt độ");
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("0. Exit");

            do
            {
                Console.Write("Please select one from above to continue: ");
                checkInput = byte.TryParse(Console.ReadLine(), out choiceOfGuest);
            } while (!checkInput || choiceOfGuest < 0 || choiceOfGuest > 2);

            switch (choiceOfGuest)
            {
                case 1:
                {
                    inputNumber = inputAndValidateNumber();
                    Console.WriteLine($"\nCelsius from Fahrenheit is: {fahrenheitToCelsius(inputNumber)}");
                    break;
                }

                case 2:
                {
                    inputNumber = inputAndValidateNumber();
                    Console.WriteLine($"\nFahrenheit from Celsius is: {celsiusToFahrenheit(inputNumber)}");
                    break;
                }
                case 0:
                {
                    Console.WriteLine("Thank you for using us");
                    break;
                }
                default:
                {
                    Console.WriteLine("Out of Program");
                    break;
                }
            }
        }

        static double celsiusToFahrenheit(double celsius)
        {
            double fahrenheit;
            fahrenheit = celsius * 1.8 + 32;
            return fahrenheit;
        }

        static double fahrenheitToCelsius(double fahrenheit)
        {
            double celsius;
            celsius = (double)(fahrenheit - 32)*5/9;
            return celsius;
        }

        static double inputAndValidateNumber()
        {
            bool checkInput = false;
            double inputNumber;
            Console.Write("Please input your number: ");
            do
            {
                checkInput = double.TryParse(Console.ReadLine(), out inputNumber);
            } while (!checkInput);
            return inputNumber;
        }
    }
}
