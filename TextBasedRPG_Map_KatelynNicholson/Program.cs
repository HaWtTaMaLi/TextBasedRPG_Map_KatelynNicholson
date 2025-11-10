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
            //DisplayMap(2);
            //DisplayMap(3);
        }

        static void DisplayMap() //scale 1
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("X");
            for(int ex = 0; ex < map.GetLength(1); ex++)
            {
                Console.Write("-");


            }
            Console.WriteLine("X");

            for (int y = 0; y < map.GetLength(0); y++)
            {
                //border
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("X");

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

                    //reset background color
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                //makes new line for y && border
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("X");

            }
            //border
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("X");
            for (int ex = 0; ex < map.GetLength(1); ex++) //* scale 
            {
                Console.Write("-");


            }
            Console.WriteLine("X");
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