using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            char vib;

            Console.WriteLine("Введите число А::");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число В::");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите наименование оператора:");
            vib = Convert.ToChar(Console.ReadLine());


            switch (vib)
            {
                case '+':

                    break;
                case '-':

                    break;
                case '*':

                    break;
                case '/':

                    break;
                default:
                    Console.WriteLine("Неизвестный оператор");
                    break;
            }
        }
    }
}