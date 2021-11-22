using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_1
{
    class Program
    {
        //Смоделируйте работу простого калькулятора.Программа должна запрашивать 2 числа, а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное).
        //После этого на консоль выводится ответ.Используйте обработку исключений для защиты от ввода некорректных данных.
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Добро пожаловать в калькулятор!");
                int number1 = 0, number2 = 0;
                try
                {
                    Console.WriteLine("Введите первое целое число:");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    number2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                Console.WriteLine("Введите пожалуйста символ операции, которую вы хоте ли бы выполнить: '+', '-' , '*' , '/' ");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Addition(number1, number2);
                        break;
                    case "-":
                        Subtraction(number1, number2);
                        break;
                    case "*":
                        Multiplication(number1, number2);
                        break;
                    case "/":
                        Division(number1, number2);
                        break;
                    default:
                        Console.WriteLine("Вы ввели недопустимый символ операции");
                        break;
                }
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void Addition(int number1, int number2)
        {
            Console.WriteLine("Результат сложения: {0}", number1 + number2);
        }
        static void Subtraction(int number1, int number2)
        {
            Console.WriteLine("Результат вычитания: {0}", number1 - number2);
        }
        static void Multiplication(int number1, int number2)
        {
            Console.WriteLine("Результат умножения: {0}", number1 * number2);
        }
        static void Division(int number1, int number2)
        {            
            try
            {
                Console.WriteLine("Результат деления: {0}, остаток: {1} ", number1 / number2, number1 % number2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
