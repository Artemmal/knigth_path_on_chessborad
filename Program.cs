using System;

namespace horse
{
    class Program
    {
        static int[] xMove = { 2, 2, 1, 1, -1, -1, -2, -2 };
        static int[] yMove = { 1, -1, 2, -2, 2, -2, 1, -1 };


        static void showMove(int[,] array)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(array[i, j]+"   ");
                }
                Console.WriteLine();
            }
        }
        static void horse (int [,] array, int num, int i0, int j0)
        {
            array[i0, j0] = num++;
            for (int i = 0; i < 8; i++)
            {
                int inew = i0 + yMove[i];
                int jnew = j0 + xMove[i];

                if (num > 64)
                {
                    Console.WriteLine("Готово");
                    showMove(array);
                    Environment.Exit(0);
                }

                if (inew < 0 || inew > 7 || jnew < 0 || jnew > 7 || array[inew, jnew] != 0)
                {
                    continue;
                }

                horse(array, num, inew, jnew);
                array[inew, jnew] = 0;
            }
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int[,] Board = new int[8, 8];
            horse(Board, 1, a, b);
        }
    }
}
