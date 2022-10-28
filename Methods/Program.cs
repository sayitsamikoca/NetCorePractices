using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DRY - Metotların Temel Esası Kendini Tekrar Etme Prensibine Dayanır.

            //Add();
            //var result = Add2(20, 30);
            //Console.WriteLine(result);


            int number1;
            int number2 = 100;

            var result2 = Add3(out number1, number2);

            // Console.WriteLine(result2);
            // Console.WriteLine(number1);


            Console.WriteLine(Multiply(9, 10));
            Console.WriteLine(Multiply(9, 10, 21));




            Console.ReadKey();
        }

        static void Add()
        {
            Console.WriteLine("Added!!!");
        }

        static int Add2(int number1 = 20, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        // Methot Overloading - Metot Aşırı Yüklemesi
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
