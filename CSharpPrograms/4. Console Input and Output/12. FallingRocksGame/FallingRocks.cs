using System;
using System.Threading;

class FallingRocks
{   // Try to avoid moving symbols.
    static string draft = "(o)";
    static int rockDensity = 30;
    static int[] rocksX = new int[rockDensity];
    static int[] rocksY = new int[rockDensity];
    static char[] rocks = { '!', '@', '#', '$', '%', '^', '&', '+', '*', ';' };
    static char[] newRocks = new char[rockDensity];
    static ConsoleColor[] rocksColor = new ConsoleColor[rockDensity];
    static Random rockGenerator = new Random();
    static int playgroundHeight;
    static int playgroundWidth;
    static int draftCurrentPositionX;
    static int draftCurrentPositionY;
    static int games = 1;
    static int gameCounts = 1;
    static void Main()
    {
        GameSetup();
        InitialMenu();
        while (gameCounts <= 3)
        {

            Console.ReadKey();
            Console.Clear();
            Game();
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(Console.WindowWidth / 2 - 5, playgroundHeight / 2);
        Console.WriteLine("GAME OVER!");
        Console.SetCursorPosition(0, playgroundHeight);
    }

    private static void InitialMenu()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.SetCursorPosition(Console.WindowWidth / 2 - 9, playgroundHeight / 2);
        Console.WriteLine("FALLING ROCK GAME");
        Console.SetCursorPosition(Console.WindowWidth - 30, (playgroundHeight) + 2);
        Console.WriteLine("(PRESS UP ARROW KEY TO START)");
        Console.SetCursorPosition(Console.WindowWidth / 2 - 21, (playgroundHeight / 2) + 2);
        Console.WriteLine("<< USE LEFT OR RIGHT ARROW KEY TO MOVE >>");
    }

    private static void Game()
    {
        EmptyArrays();
        ulong score = 0;
        int colisions = 0;
        for (int i = 0; i < rockDensity; i++)
        {
            GenerateRocks(i); // Generate initial rocks.
        }
        draftCurrentPositionX = playgroundWidth / 2;
        draftCurrentPositionY = playgroundHeight - 1;
        for (; ; )
        {
            for (int i = 0; i < rockDensity; i++)
            {
                if (rocksY[i] != playgroundHeight)
                {
                    MoveRocks(i);
                }
                else
                {
                    GenerateRocks(i); // Generate new rocks.
                    score++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(1, playgroundHeight);
            Console.Write(new string('-', playgroundWidth));
            Console.SetCursorPosition(1, playgroundHeight + 1);
            Console.Write("SCORE: {0}", score);
            Console.SetCursorPosition(playgroundWidth - 11, playgroundHeight + 1);
            Console.Write("GAME: {0} of 3", gameCounts);
            DraftMovement();
            colisions = ColisionDetection();
            if (colisions > 0)
            {
                gameCounts++;
                return;
            }
            Thread.Sleep(150);
        }
    }

    private static int ColisionDetection()
    {
        int isHit = 0;
        for (int i = 0; i < rockDensity; i++)
        {
            if ((rocksX[i] == draftCurrentPositionX + 0 && rocksY[i] == draftCurrentPositionY) ||
              (rocksX[i] == draftCurrentPositionX + 1 && rocksY[i] == draftCurrentPositionY) ||
              (rocksX[i] == draftCurrentPositionX + 2 && rocksY[i] == draftCurrentPositionY))
            {
                Console.Clear();
                if (games < 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(playgroundWidth / 2 - 6, playgroundHeight / 2);
                    Console.WriteLine("GAME: {0} END", games);
                    Console.SetCursorPosition(playgroundWidth / 2 - 13, playgroundHeight / 2 + 2);
                    Console.WriteLine("Press Any key to continue...");
                }
                games++;
                isHit++;
                break;
            }
        }
        return isHit;
    }

    private static void DraftMovement()
    {
        while (Console.KeyAvailable)
        {
            ConsoleKeyInfo draftPosition = Console.ReadKey();
            if (draftPosition.Key == ConsoleKey.LeftArrow)
            {
                draftCurrentPositionX -= 2;
                Console.SetCursorPosition(draftCurrentPositionX + 2, draftCurrentPositionY);
                Console.Write("   ");
            }
            if (draftPosition.Key == ConsoleKey.RightArrow)
            {
                draftCurrentPositionX += 2;
                Console.SetCursorPosition(draftCurrentPositionX - 2, draftCurrentPositionY);
                Console.Write("  ");
            }
            if (draftCurrentPositionX < 1)
            {
                draftCurrentPositionX = 1;
            }
            if (draftCurrentPositionX > playgroundWidth - 1)
            {
                draftCurrentPositionX = playgroundWidth - 2;
            }
        }
        Console.SetCursorPosition(draftCurrentPositionX, draftCurrentPositionY);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(draft);
    }

    private static void MoveRocks(int index)
    {

        Console.SetCursorPosition(rocksX[index], rocksY[index]);
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("x"); // Remove residual blue pixels.
        Console.ForegroundColor = (ConsoleColor)rocksColor[index];
        Console.SetCursorPosition(rocksX[index], rocksY[index] + 1);
        Console.Write(newRocks[index]);
        rocksY[index]++;
    }

    private static void EmptyArrays()
    {
        for (int i = 0; i < rockDensity; i++)
        {
            rocksX[i] = 0;
            rocksY[i] = 0;
        }
    }

    private static void GenerateRocks(int index)
    {
        rocksX[index] = rockGenerator.Next(1, playgroundWidth);
        rocksY[index] = rockGenerator.Next((playgroundHeight - 10));
        newRocks[index] = rocks[rockGenerator.Next(10)];
        rocksColor[index] = (ConsoleColor)rockGenerator.Next(10, 16);
    }

    private static void GameSetup()
    {
        Console.BufferHeight = Console.WindowHeight;
        Console.CursorVisible = false;
        playgroundHeight = Console.WindowHeight - 3;
        playgroundWidth = Console.WindowWidth - 2;
        draftCurrentPositionX = playgroundWidth / 2;
        draftCurrentPositionY = playgroundHeight - 1;
    }
}



