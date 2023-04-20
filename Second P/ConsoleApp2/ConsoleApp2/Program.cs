using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static void MainDrawBar()
        {
            int health = 10;
            int maxHealy = 25;

            DrawBar(health, maxHealy, ConsoleColor.Green);
            DrawBar(health, maxHealy - 5, ConsoleColor.Green, 1);

        }
       
        static void DrawBar(int value, int maxValue, ConsoleColor color, int position = 0)
        {
            ConsoleColor defaultleColor = Console.BackgroundColor;

            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += " ";
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultleColor;

            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += " ";
            }
            Console.Write(bar);
            Console.Write(']');

        }

        static void ArrayResize()
        {
            int[] array = new int[5];

            Console.WriteLine(array.Length);
            array = Resize(array, 8);
            Console.WriteLine(array.Length);
            array = Resize(array, 5);
            Console.WriteLine(array.Length);

            Console.WriteLine("==================");

            int[,] arrayDouble = new int[5, 5];

            Console.WriteLine(arrayDouble.Length);
            arrayDouble = Resize(arrayDouble, 8, 8);
            Console.WriteLine(arrayDouble.Length);
            arrayDouble = Resize(arrayDouble, 5, 5);
            Console.WriteLine(arrayDouble.Length);
        }

        static int[] Resize(int[] array, int size)
        {
            int[] newArray = new int[size];

            for (int i = 0; i < newArray.Length && i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            return newArray;
        }

        static int[,] Resize(int[,] array, int sizeX, int sizeY)
        {
            int[,] newArray = new int[sizeX, sizeY];

            for (int i = 0; i < newArray.GetLength(0) && i < array.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1) && j < array.GetLength(1); j++)
                {
                    newArray[i, j] = array[i, j];
                }
            }

            return newArray;
        }

        static void SumRef(ref int sum, int x, int y)
        {
            sum = x + y;
        }

        static void SumOut(out int sum, int x, int y)
        {
            sum = x + y;
        }

        static void ChekIf()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hi world and {name}");

            int lengntString = name.Length;

            switch (lengntString)
            {
                case 0:
                    Console.WriteLine(0);
                    break;
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                    Console.WriteLine(3);
                    break;
                case 4:
                    Console.WriteLine(4);
                    break;
                case 5:
                case 6:
                case 7:
                    Console.WriteLine("big string");
                    break;
                default:
                    Console.WriteLine("So long...");
                    break;
            }

            for (int i = 0; i < lengntString; ++i)
            {
                Console.WriteLine(i);
            }

            while (lengntString-- > 0)
            {
                Console.WriteLine(lengntString);
            }
        }

        static void WorkWithArray()
        {
            int[] array = { 1, 21, 22, 23, 24 };
            int sum = 0;

            foreach (var item in array)
            {
                sum += item;
            }

            Console.WriteLine(sum);


            int[,] arrays =
            {
                { 1, 21, 23},
                { 2, 23, 24 },
                { 3, 24, 25}
            };

            Console.WriteLine(arrays[1, 1]);

            for (int i = 0; i < arrays.GetLength(0); i++)
            {
                for (int j = 0; j < arrays.GetLength(1); j++)
                {
                    Console.Write(arrays[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void TopTop()
        {
            Console.CursorVisible = false;

            char[,] map =
            {
                {'#', '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
                {'#', ' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#', ' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#', ' ','#',' ','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#', ' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#', 'T','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#', ' ',' ',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#', '#','#','#','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#', ' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#', ' ','#','#','#','#','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#', ' ','#',' ',' ',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#', ' ','#',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#', ' ','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#', ' ','#',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#', ' ',' ',' ','#','T','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                {'#', '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' }
            };

            int userX = 1; int userY = 1;
            char[] bag = new char[1];

            while (true)
            {
                Console.SetCursorPosition(0, 20);
                Console.Write("Сумка: ");
                for (int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }

                Console.SetCursorPosition(0, 0);

                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                };

                Console.SetCursorPosition(userY, userX);
                Console.Write('@');
                ConsoleKeyInfo charKey = Console.ReadKey();

                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userX - 1, userY] != '#')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userX + 1, userY] != '#')
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userX, userY - 1] != '#')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userX, userY + 1] != '#')
                        {
                            userY++;
                        }
                        break;
                }

                if (map[userX, userY] == 'T')
                {
                    map[userX, userY] = ' ';
                    char[] tempBag = new char[bag.Length + 1];

                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }

                    tempBag[bag.Length - 1] = 'T';
                    bag = tempBag;
                }

                Console.Clear();
            };


        }

    }

}

