using System;

namespace MyFirstProject
{
    class Program
    {
        static void GetReverseValue(int[] array)
        {
            int[] ReverseValue = array[0];

            for (int index = array.Length - 1; index >= 0; index--)
                
            {
                ReverseValue = array[index];                                   
            }
            // koment 2

        }Console.WriteLine(ReverseValue);
    }
}
