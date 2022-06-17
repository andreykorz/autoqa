using System;

namespace MyFirstProject
{
    class Program
    {
        // kakouto koment
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = 2;
            array[1] = array[0] * array[0];
            array[2] = array[0] + array[1];
            
            Console.WriteLine("Result = {0}", array[0]);
            Console.WriteLine("Result = {0}", array[1]);
            Console.WriteLine("Result = {0}", array[2]);

            long[] square = new long[5];
            square[0] = 6;
            square[1] = square[0] * square[0];
            square[2] = square[0] + square[1];

            Console.WriteLine("Result = {0}", square[0]);
            Console.WriteLine("Result = {0}", square[1]);
            Console.WriteLine("Result = {0}", square[2]);

            float[] cube = new float[5];
            cube[0] = array[0] + square[0];
            cube[1] = array[1] + square[1];
            cube[2] = array[2] + square[2];

            Console.WriteLine("Result = {0}", cube[0]);
            Console.WriteLine("Result = {0}", cube[1]);
            Console.WriteLine("Result = {0}", cube[2]);
        }
    }
}
