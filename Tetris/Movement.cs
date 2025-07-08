namespace Tetris;
public class Movement
{
    public Movement(Player p)
    {
        P = p;
        P.Level = Start.Level;
    }
    public Player P;
    public void Move()
    {
        P.Prints.PrintBoard();
        P.Prints.PrintNext();
        P.Prints.PrintHeld();
        int countDown = 0;
        bool changed = false;
        bool next = false;
        bool held = false;
        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Escape)
                {
                    return;
                }
                else if (cki.Key == ConsoleKey.E && P.Coll.RotationCW())
                {
                    P.Map(0);
                    P.RotateCW();
                    changed = !changed;
                }
                else if (cki.Key == ConsoleKey.Q && P.Coll.RotationCCW())
                {
                    P.Map(0);
                    P.RotateCCW();
                    changed = !changed;
                }
                else if (cki.Key == ConsoleKey.C && !held)
                {
                    P.Hold();
                    held = true;
                    changed = !changed;
                }
                else if (cki.Key == ConsoleKey.RightArrow && P.Coll.Right())
                {
                    P.PosX++;
                    changed = !changed;
                }
                else if (cki.Key == ConsoleKey.LeftArrow && P.Coll.Left())
                {
                    P.PosX--;
                    changed = !changed;
                }
                else if (cki.Key == ConsoleKey.DownArrow && P.Coll.Down())
                {
                    P.PosY++;
                    countDown = 0;
                    P.Points++;
                    changed = !changed;
                }
                else if (cki.Key == ConsoleKey.Spacebar)
                {   
                    if(!P.Coll.Down())
                    {
                        next = true;
                    }
                    while(P.Coll.Down())
                    {
                        P.PosY++;
                        P.Points += 2;
                    }
                    countDown = 0;
                    changed = !changed;
                }
            }
            if(countDown == P.FallSpeed)
            {
                if(P.Coll.Down())
                {
                    P.PosY++;
                    P.Map(0);
                    P.Vars();
                    P.Map(1);
                    if(Start.Debug)
                    {
                        Console.SetCursorPosition(0, 0); 
                        Console.Write(P);
                        P.Prints.PrintHeld();
                        P.Prints.PrintNext();
                    }
                    else
                    {
                        P.Prints.PrintBoard();
                    }
                    countDown = 0;
                    next = false;
                }
                else
                {
                    next = true;
                }
            }

            if (changed)
            {
                P.Map(0);
                P.Vars();
                P.Map(1);
                if(Start.Debug)
                {
                    Console.SetCursorPosition(0, 0); 
                    Console.Write(P);
                    P.Prints.PrintHeld();
                    P.Prints.PrintNext();
                }
                else
                {
                    P.Prints.PrintBoard();
                }
                changed = false;
            }
            countDown++;
            if(next && !P.Coll.Down())
            {
                if(P.Line.CheckLoss())
                {
                    return; 
                }
                if(held)
                {
                    P.AfterHold();
                    held = false;
                    next = false;
                    countDown = 0;
                }
                else
                {
                    held = false;
                    next = false;
                    countDown = 0;
                    P.NextPiece();
                }
                P.NextLevel();
            }
        }
    }
}

