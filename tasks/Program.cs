using System;
using MyLib;

namespace tasks;
class Program
{
    static void Main(string[] args)
    {
        // Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
        void Task41()
        {
            int size = MyLib.MyLibClass.Input("Введите числа: ");
            int[] numbers = new int[size];

            MyLib.MyLibClass.FillArray(numbers, -100, 100);
            MyLib.MyLibClass.PrintArray(numbers);

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0) count++;
            }
            Console.WriteLine($"Чисел больше 0 = {count}");
        }


        // Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
        // уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
        void Task43()
        {
            int b1 = MyLib.MyLibClass.Input("Введите значение b1 = ");
            int k1 = MyLib.MyLibClass.Input("Введите значение k1 = ");
            int b2 = MyLib.MyLibClass.Input("Введите значение b2 = ");
            int k2 = MyLib.MyLibClass.Input("Введите значение k2 = ");

            if (k1 == k2)
            {
                Console.WriteLine("Прямые параллельны");
            }
            else
            {
                double x = (b2 - b1) / (k1 - k2);
                x = Math.Round(x, 2);

                double y = k1 * x + b1;
                y = Math.Round(y, 2);

                Console.WriteLine($"Пересечение двух прямых в точке ({x}; {y})");
            }
        }


        // Проверка кода. 
        Console.Clear();
        int task = MyLib.MyLibClass.Input("Введите номер задачи: ");
        switch (task)
        {
            case 41:
                Task41();
                break;
            case 43:
                Task43();
                break;
            default:
                Console.WriteLine("Ошибка ввода");
                break;
        }
    }
}
