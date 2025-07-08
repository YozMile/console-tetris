namespace Tetris;
public class Print
{
    public Print(Player p)
    {
        P = p;
    }
    private Player P;
    public void PrintBoard()
    {
        for (int i = 0; i < P.CollMap.GetLength(0); i++)
        {
            for (int j = 3; j < P.CollMap.GetLength(1); j++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (P.CollMap[i, j] == 1 && i == 0)
                {
                    Console.SetCursorPosition((i * 2) + 1 + (16 + 40 * P.Multiplier), j - 3);
                    Console.Write(">");
                    continue;
                }
                if (P.CollMap[i, j] == 1 && i == 11)
                {
                    Console.SetCursorPosition((i * 2) + (16 + 40 * P.Multiplier), j - 3);
                    Console.Write("<");
                    continue;
                }
                if (P.CollMap[i, j] == 1 && i < 11 && i > 0)
                {
                    Console.SetCursorPosition((i * 2) + (16 + 40 * P.Multiplier), j - 3);
                    Console.Write("/\\");
                    continue;
                }
                if (P.CollMap[i, j] > 1)
                {
                    switch (P.CollMap[i, j])
                    {
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                        case 7:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case 8:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                    }
                    Console.SetCursorPosition((i * 2) + (16 + 40 * P.Multiplier), j - 3);
                    Console.Write("[]");
                }
                else
                {
                    Console.SetCursorPosition((i * 2) + (16 + 40 * P.Multiplier), j - 3);
                    Console.Write("  ");
                }
            }
        }
        Console.SetCursorPosition((13 * 2) + (16 + 40 * P.Multiplier), 12);
        Console.Write("Points: {0}",P.Points);
        Console.SetCursorPosition((13 * 2) + (16 + 40 * P.Multiplier), 13);
        Console.Write("Lines: {0}",P.ClearedLines);
        Console.SetCursorPosition((13 * 2) + (16 + 40 * P.Multiplier), 14);
        Console.Write("Level: {0}",P.Level);
    }
    public void PrintNext()
    {
        int nextIndex = P.Index;
        nextIndex++;
        if (P.Index == 532)
        {
            nextIndex = 0;
        }
        Console.SetCursorPosition((13 * 2) + (16 + 40 * P.Multiplier), 2);
        Console.Write("____________");
        Console.SetCursorPosition((13 * 2) + (16 + 40 * P.Multiplier), 3);
        Console.Write("|          |");
        Console.SetCursorPosition((13 * 2) + (16 + 40 * P.Multiplier), 4);
        Console.Write("|          |");
        Console.SetCursorPosition((13 * 2) + (16 + 40 * P.Multiplier), 5);
        Console.Write("|          |");
        Console.SetCursorPosition((13 * 2) + (16 + 40 * P.Multiplier), 6);
        Console.Write("|          |");
        Console.SetCursorPosition((13 * 2) + (16 + 40 * P.Multiplier), 7);
        Console.Write("|          |");
        Console.SetCursorPosition((13 * 2) + (16 + 40 * P.Multiplier), 8);
        Console.Write("|__________|");
        if (P.Seed[nextIndex] == 'T')
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition((14 * 2) + (16 + 40 * P.Multiplier), 5);
            Console.Write("   []");
            Console.SetCursorPosition((14 * 2) + (16 + 40 * P.Multiplier), 6);
            Console.Write(" [][][]");
        }
        else if (P.Seed[nextIndex] == 'O')
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition((14 * 2) + (16 + 40 * P.Multiplier), 5);
            Console.Write("  [][]");
            Console.SetCursorPosition((14 * 2) + (16 + 40 * P.Multiplier), 6);
            Console.Write("  [][]");
        }
        else if (P.Seed[nextIndex] == 'I')
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition((14 * 2) + (16 + 40 * P.Multiplier), 6);
            Console.Write("[][][][]");
        }
        else if (P.Seed[nextIndex] == 'S')
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition((14 * 2) + (16 + 40 * P.Multiplier), 5);
            Console.Write("   [][]");
            Console.SetCursorPosition((14 * 2) + (16 + 40 * P.Multiplier), 6);
            Console.Write(" [][]");
        }
        else if (P.Seed[nextIndex] == 'Z')
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition((14 * 2) + (16 + 40 * P.Multiplier), 5);
            Console.Write(" [][]");
            Console.SetCursorPosition((14 * 2) + (16 + 40 * P.Multiplier), 6);
            Console.Write("   [][]");
        }
        else if (P.Seed[nextIndex] == 'J')
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition((14 * 2) + (16 + 40 * P.Multiplier), 5);
            Console.Write(" []");
            Console.SetCursorPosition((14 * 2) + (16 + 40 * P.Multiplier), 6);
            Console.Write(" [][][]");
        }
        else if (P.Seed[nextIndex] == 'L')
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition((14 * 2) + (16 + 40 * P.Multiplier), 5);
            Console.Write("     []");
            Console.SetCursorPosition((14 * 2) + (16 + 40 * P.Multiplier), 6);
            Console.Write(" [][][]");
        }
    }
    public void PrintHeld()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition((1 * 2) + (40 * P.Multiplier), 2);
        Console.Write("____________");
        Console.SetCursorPosition((1 * 2) + (40 * P.Multiplier), 3);
        Console.Write("|          |");
        Console.SetCursorPosition((1 * 2) + (40 * P.Multiplier), 4);
        Console.Write("|          |");
        Console.SetCursorPosition((1 * 2) + (40 * P.Multiplier), 5);
        Console.Write("|          |");
        Console.SetCursorPosition((1 * 2) + (40 * P.Multiplier), 6);
        Console.Write("|          |");
        Console.SetCursorPosition((1 * 2) + (40 * P.Multiplier), 7);
        Console.Write("|          |");
        Console.SetCursorPosition((1 * 2) + (40 * P.Multiplier), 8);
        Console.Write("|__________|");
        if (P.Held != 600)
        {
            if (P.Seed[P.Held] == 'T')
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition((2 * 2) + (40 * P.Multiplier), 5);
                Console.Write("   []");
                Console.SetCursorPosition((2 * 2) + (40 * P.Multiplier), 6);
                Console.Write(" [][][]");
            }
            else if (P.Seed[P.Held] == 'O')
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition((2 * 2) + (40 * P.Multiplier), 5);
                Console.Write("  [][]");
                Console.SetCursorPosition((2 * 2) + (40 * P.Multiplier), 6);
                Console.Write("  [][]");
            }
            else if (P.Seed[P.Held] == 'I')
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition((2 * 2) + (40 * P.Multiplier), 6);
                Console.Write("[][][][]");
            }
            else if (P.Seed[P.Held] == 'S')
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition((2 * 2) + (40 * P.Multiplier), 5);
                Console.Write("   [][]");
                Console.SetCursorPosition((2 * 2) + (40 * P.Multiplier), 6);
                Console.Write(" [][]");
            }
            else if (P.Seed[P.Held] == 'Z')
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition((2 * 2) + (40 * P.Multiplier), 5);
                Console.Write(" [][]");
                Console.SetCursorPosition((2 * 2) + (40 * P.Multiplier), 6);
                Console.Write("   [][]");
            }
            else if (P.Seed[P.Held] == 'J')
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition((2 * 2) + (40 * P.Multiplier), 5);
                Console.Write(" []");
                Console.SetCursorPosition((2 * 2) + (40 * P.Multiplier), 6);
                Console.Write(" [][][]");
            }
            else if (P.Seed[P.Held] == 'L')
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition((2 * 2) + (40 * P.Multiplier), 5);
                Console.Write("     []");
                Console.SetCursorPosition((2 * 2) + (40 * P.Multiplier), 6);
                Console.Write(" [][][]");
            }
        }
    }
    public static void PrintHelp()
    {
        if(Player.TotalPlayers == 1)
        {
            Console.SetCursorPosition(6, 26);
            Console.Write("Controls:\n  Player 1: Rotate Clockwise: E,  Rotate Counter Clockwise: Q,  Hold: C,  Soft Drop: Down Arrow,  Hard Drop: Space,  Move Left: Left Arrow,  Move Right: Right Arrow");
        }
        if(Player.TotalPlayers == 2)
        {
            Console.SetCursorPosition(6, 26);
            Console.Write("Player 1: Rotate Clockwise: E,  Rotate Counter Clockwise: Q,  Hold: C,  Soft Drop: S,  Hard Drop: X,  Move Left: A,  Move Right: D");
            Console.SetCursorPosition(6, 27);
            Console.Write("Player 2: Rotate Clockwise: O,  Rotate Counter Clockwise: U,  Hold: N,  Soft Drop: K,  Hard Drop: M,  Move Left: Left Arrow,  Move Right: L");
        }
    }
}