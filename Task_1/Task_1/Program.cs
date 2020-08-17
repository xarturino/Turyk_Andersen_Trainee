using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number > 7)
            {
                Console.WriteLine("Привет");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
