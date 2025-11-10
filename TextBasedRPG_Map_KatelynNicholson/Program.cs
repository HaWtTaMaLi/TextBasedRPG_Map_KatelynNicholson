using System;

namespace TextBaseRPGMap_KatelynNicholson_2025_10_27
{

    internal class Program
    {

        static char[,] map = new char[,] // dimensions defined by following data:
    {
        {'▒','▒','▒','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓'},
        {'▒','▒','▓','▓','▓','▓','⌠','⌠','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','░','░','░','▓','▓','▓'},
        {'▒','▒','▓','▓','▓','⌠','⌠','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','░','░','░','▓','▓','▓','▓','▓'},
        {'▒','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓'},
        {'▓','▓','▓','▓','░','░','░','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓'},
        {'▓','▓','▓','▓','░','░','░','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓'},
        {'▓','▓','▓','░','░','░','░','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▒','▒','▓','▓','▓','▓','▓','▓'},
        {'▓','▓','▓','▓','▓','░','░','░','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▒','▒','▒','▒','▓','▓','▓','▓','▓'},
        {'▓','▓','▓','▓','▓','░','░','░','░','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▒','▒','▒','▒','▓','▓','▓'},
        {'▓','▓','▓','▓','▓','▓','▓','░','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓'},
        {'▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓'},
        {'▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓'},
    };

        // map legend:
        // ▒ = mountain ▒▒▒▒▒▒▒▒▒▒ .ConsoleColor.Gray;
        // ▓ = grass ▓▓▓▓▓▓▓▓▓▓▓▓▓ .ConsoleColor.Green;
        // ░ = water ░░░░░░░░░░░░░ .ConsoleColor.Blue;
        // ⌠ = trees ⌠⌠⌠⌠⌠⌠⌠⌠⌠⌠⌠⌠ .ConsoleColor.Brown;

        static void Main()
        {
            DisplayMap();
            DisplayMap(2);
            DisplayMap(3);
        }

        static void DisplayMap() //scale 1
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    char tile = map[y, x];

                    switch (tile)
                    {
                        case '▒':
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        case '░':
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case '▓':
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case '⌠':
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;
                    }
                    Console.Write(tile);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                //makes new line for y
                Console.WriteLine();
            }
        }

        static void DisplayMap(int scale) // scale of 2 and scale of 3 
        {
            //conditionals for boarder
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int alerow = 0; alerow < scale; alerow++) 
                { 
                    for (int x = 0; x < map.GetLength(1); x++)
                    {
                        for(int alecol = 0; alecol < scale; alecol++)
                        {
                            char tile = map[y, x];

                            switch (tile)
                            {
                                case '▒':
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    break;
                                case '░':
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    break;
                                case '▓':
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    break;
                                case '⌠':
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    break;
                            }
                            Console.Write(tile);
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}