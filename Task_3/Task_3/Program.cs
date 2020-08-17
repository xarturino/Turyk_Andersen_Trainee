using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[20] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
            for (int y = 0; y < array.Length; y++)
            {
                if (array[y] % 3 == 0)
                {
                    Console.Write("{0} - кратно ",array[y]);
                }
            }

        }
    }
}