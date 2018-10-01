using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int[,,] array3D = int[10,10,10]
        //    {
        //         for (int i = 1; i <= 10; i++)
        //         {
        //             for (int j = 1; j <= 10; j++)
        //             {           
        //                     System.Console.WriteLine(i * (j+j));
        //             }
        //         }
        //     }
        // int[,] Multiplication_Table = new int[10,10];
        // for (int i = 1; i <= 10; i++)
        // {
        //     for (int j = 1; j <= 10; j++)
        //     {
        //         System.Console.Write(i * j + "\t");
        //     }
        //     System.Console.WriteLine();
        // }
        // }

        int[,] Multiplication_Table = new int[10,10];
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Multiplication_Table[i-1,j-1] = i * j;
                System.Console.Write(Multiplication_Table[i-1,j-1] + "\t");
            }
            System.Console.WriteLine();
            
        }
        }

    }
}
