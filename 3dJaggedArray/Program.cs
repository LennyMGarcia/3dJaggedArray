using System;

namespace _3dJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][][] foos = new int[][][]
                {
            new int[][]
            {
                new int [] {14, 13, 12},
                new int [] {58, 17}

            },
            new int[][]
            {
                new int [] {4, 3, 2},
                new int [] {8, 7, 88, 888, 94}
            }
                };
            

            for (int x = 0; x < foos.Length; x++)
            {
                Console.WriteLine($"esta es la capa {x} ");
                for (int y = 0; y < foos[x].Length; y++)
                    
                {
                    Console.WriteLine($"esta es el jagged {y} ");
                    for (int z = 0; z < foos[x][y].Length; z++)
                    {
                        Console.WriteLine($"esta es el array {z} ");
                        Console.WriteLine(foos[x][y][z]+"  ");
                        
                    }
                }
            }
        }
    }
}
