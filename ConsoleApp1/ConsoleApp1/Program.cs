using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1. Вывести на экран в столбик первые 10 натуральных чисел (циклы с условием, цикл с параметром)
            //Цикл с предварительной проверкой условия
            //int i = 1;
            //while(i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Цикл с последующей проверкой условия
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i <= 10);
            //Цикл с параметром
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Задание 2. Вывести на экран целые числа из интервала от 1 до n (цикл с параметром)
            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Задание 3. Вывести в столбик 5 раз слово «Привет!» (циклы с условием)
            //Цикл с предварительной проверкой условия
            //int i = 1;
            //while(i <= 5){
            //    Console.WriteLine("Привет!");
            //    i++;
            //}
            //Цикл с последующей проверкой условия
            //int i = 1;
            //do
            //{
            //    Console.WriteLine("Привет!");
            //    i++;
            //}
            //while (i <= 5);

            //Задание 4. С использованием цветового оформления консоли:
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Black;
            //а) вывести на экран горизонтальную строку из 18 символов
            //Console.Write("Введите символ: ");
            //string symbol = Console.ReadLine();
            //for(int i =  0; i < 18; i++)
            //{
            //    Console.Write(symbol);
            //}
            //б) вывести на экран вертикальную строку из 25 символов
            //Console.Write("Введите символ: ");
            //string symbol = Console.ReadLine();
            //for (int i = 0; i < 18; i++)
            //{
            //    Console.WriteLine(symbol);
            //}

            Console.ReadKey();
        }
    }
}
