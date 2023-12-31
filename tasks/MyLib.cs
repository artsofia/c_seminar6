using System;

namespace MyLib
{
    public static class MyLibClass
    {
        public static int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void FillArray(int[] array, int minVelue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(minVelue, maxValue);
            }
        }

        public static void FillArray(double[] array, int minVelue = -9, int maxValue = 9)
        {
            maxValue++;
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.NextDouble() * (maxValue - minVelue) + minVelue;
                array[i] = Math.Round(array[i], 2);
            }
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}