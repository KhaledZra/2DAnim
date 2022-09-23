using System;
using System.Drawing;
using System.Threading;

namespace _2DAnim // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int origRow;
        static int origCol;
        static void Main(string[] args)
        {
            ColorHandler.PrintBlue("Hello World!\n");
            Random random = new Random();

            //Console.SetWindowSize(1280, 720);

            Console.Clear();
            origRow = Console.CursorTop;
            origCol = Console.CursorLeft;

            int x = 1;
            int y = 1;
            string player = "@";
            int playerSize = 1;

            int xMonster = random.Next(2, 29);
            int yMonster = random.Next(2, 14);
            bool isAlive = true;
            string monster = "H";

            Console.CursorVisible = false;
            while (true)
            {
                Console.Clear();
                DrawMap();
                // Monster Render
                if (isAlive)
                {
                    Console.SetCursorPosition(xMonster, yMonster);
                    ColorHandler.PrintYellow(monster);
                }
                // Player Render
                DrawPlayer(player, playerSize, x, y);

                if ((x == xMonster) && (y == yMonster))
                {
                    xMonster = random.Next(2, 29);
                    yMonster = random.Next(2, 14);
                    Console.SetCursorPosition(xMonster, yMonster);
                    ColorHandler.PrintYellow(monster);
                    playerSize++;
                }
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                if (ConsoleKey.LeftArrow == key)
                {
                    x--;
                }
                else if (ConsoleKey.RightArrow == key)
                {
                    x++;
                }
                else if (ConsoleKey.UpArrow == key)
                {
                    y--;
                }
                else if (ConsoleKey.DownArrow == key)
                {
                    y++;
                }
            }
        }

        static void WriteAt(string text, int x, int y)
        {
            Console.SetCursorPosition(origCol+x, origRow+y);
            ColorHandler.PrintRed(text);
        }

        static void DrawPlayer(string player, int playerSize, int x, int y)
        {
            if (playerSize == 1)
            {
                Console.SetCursorPosition(x, y);
                ColorHandler.PrintGreen(player);
            }
            else
            {
                for (int i = playerSize; i < 1; i++)
                {
                    
                }
            }
        }

        static void MovePlayerParts(string player, int playerSize, int x, int y)
        {

        }

        static void DrawMap()
        {
            // Left Wall
            WriteAt("+", 0, 0);
            for (int i = 1; i < 15; i++)
            {
                WriteAt("|", 0, i);
            }
            WriteAt("+", 0, 15);

            // Top Wall
            for (int i = 1; i < 30; i++)
            {
                WriteAt("-", i, 0);
            }

            // Right wall
            WriteAt("+", 30, 0);
            for (int i = 1; i < 15; i++)
            {
                WriteAt("|", 30, i);
            }
            WriteAt("+", 30, 15);

            // Bottom wall
            for (int i = 1; i < 30; i++)
            {
                WriteAt("-", i, 15);
            }
        }
    }
}