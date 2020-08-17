using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameV = "Вячеслав";
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            if(name == nameV)
            {
                Console.WriteLine($"Привет,{name}");
            }
            else
            {
                Console.WriteLine("Нет такого имени");
            }
        }
    }
}
