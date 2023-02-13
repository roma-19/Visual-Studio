using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1.

            //int[] mas = new int[5];
            //for(int i = 0; i < mas.Length; i++)
            //{
            //    Console.Write($"mas[{i}]=");
            //    mas[i] = int.Parse(Console.ReadLine());
            //}
            //Console.ReadKey();

            //Zadanie 2.

            //int[] mas = new int[] { 1, 2, 3 };
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    Console.WriteLine($"mas[{i}] = {mas[i]}");
            //}
            //Console.ReadKey();

            //Zadanie 3.

            //int[] mas = new int[9];
            //for(int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = (i + i) * 2;
            //    Console.WriteLine($"mas[{i}] = {mas[i]}");
            //}
            //Console.ReadKey();

            //Zadanie 4.

            Console.WriteLine("Заполнение массива случайными числами с помощью цикла foreach:\n");
            Random ran = new Random();
            int[] mas = new int[10];
            for(int i = 0; i < mas.Length; i++)
            {
                mas[i] = ran.Next(1,100);
            }
            foreach(int elem in mas)
            {
                Console.WriteLine(elem);

            }
            Console.ReadKey();
        }
    }
}