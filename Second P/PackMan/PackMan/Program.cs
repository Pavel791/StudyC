using System;
using System.IO;

namespace PackMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] map = ReadMap("map.txt");

            int pacmanX = 1;
            int pacmanY = 1;

            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                DrawMap(map);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(pacmanX, pacmanY);
                Console.WriteLine("@");

                HandeleInput(Console.ReadKey(), ref pacmanX, ref pacmanY, map);
            }


        }

        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines("map.txt");

            char[,] map = new char[GetMaxLenghtOfLine(file[0]), file.Length];

            for (int x = 0; x < map.GetLength(0); x++)
                for (int y = 0; y < map.GetLength(1); y++)
                    map[x, y] = file[y][x];

            return map;
        }

        private static int GetMaxLenghtOfLine(string line)
        {
            int max = 0;

            foreach (char c in line)
            {
                if (c == '#')
                    max++;
                else
                    break;
            }

            return max;
        }

        private static void DrawMap(char[,] map)
        {

            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x, y]);
                }

                Console.WriteLine();
            }
        }

        private static void HandeleInput(ConsoleKeyInfo key, ref int pacmanX, ref int pacmanY, char[,] map)
        {
            if (key.Key == ConsoleKey.UpArrow && map[pacmanX, pacmanY - 1] != '#')
            {
                pacmanY--;
            }
            else if (key.Key == ConsoleKey.DownArrow && map[pacmanX, pacmanY + 1] != '#')
            {
                pacmanY++;
            }
            else if (key.Key == ConsoleKey.LeftArrow && map[pacmanX - 1, pacmanY] != '#')
            {
                pacmanX--;
            }
            else if (key.Key == ConsoleKey.RightArrow && map[pacmanX + 1, pacmanY] != '#')
            {
                pacmanX++;
            }
        }
    }
}
