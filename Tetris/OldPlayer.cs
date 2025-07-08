using System.Text;
namespace Tetris;
public class OldPlayer
{
    public OldPlayer()
    {
        PosX = 6;
        PosY = 6;
        OldX = PosX;
        OldY = PosY;
        Rot = 1;
        Seed = GenSeed();
    }
    public byte PosX { get; set; }
    public byte PosY { get; set; }
    public byte OldX { get; set; }
    public byte OldY { get; set; }
    public string Seed { get; private set; }
    public int Index { get; set; }
    public int Held { get; set; }
    public byte Rot { get; set; }
    private static string GenSeed()
    {
        StringBuilder sb = new StringBuilder();
        Dictionary<int, char> chars = new Dictionary<int, char>() { { 0, 'T' }, { 1, 'O' }, { 2, 'I' }, { 3, 'S' }, { 4, 'Z' }, { 5, 'J' }, { 6, 'L' } };
        Random gen = new Random();
        for (int i = 0; i < 76; i++)
        {
            List<int> used = new List<int>();
            for (int j = 0; j < 7; j++)
            {
                int piece = gen.Next(7);
                while (used.Contains(piece))
                {
                    piece = gen.Next(7);
                }
                used.Add(piece);
                sb.Append(chars[piece]);
            }
            used.Clear();
        }
        return sb.ToString();
    }
    public void NextPiece()
    {
        PosX = 6;
        PosY = 6;
        OldX = PosX;
        OldY = PosY;
        Index++;
        Print(1);
    }
    public void Print(int mode)
    {
        byte[] x = new byte[] { OldX, PosX };
        byte[] y = new byte[] { OldY, PosY };
        string[] block = new string[] { "  ", "[]" };
        if (Seed[Index] == 'T')
        {
            if (Rot == 1)
            {
                Console.SetCursorPosition(x[mode], y[mode] - 1);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode] - 2, y[mode]);
                Console.Write(block[mode] + block[mode] + block[mode]);
            }
            else if (Rot == 2)
            {
                Console.SetCursorPosition(x[mode], y[mode] - 1);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode], y[mode]);
                Console.Write(block[mode] + block[mode]);
                Console.SetCursorPosition(x[mode], y[mode] + 1);
                Console.Write(block[mode]);
            }
            else if (Rot == 3)
            {
                Console.SetCursorPosition(x[mode] - 2, y[mode]);
                Console.Write(block[mode] + block[mode] + block[mode]);
                Console.SetCursorPosition(x[mode], y[mode] + 1);
                Console.Write(block[mode]);
            }
            else if (Rot == 4)
            {
                Console.SetCursorPosition(x[mode], y[mode] - 1);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode] - 2, y[mode]);
                Console.Write(block[mode] + block[mode]);
                Console.SetCursorPosition(x[mode], y[mode] + 1);
                Console.Write(block[mode]);
            }
        }
        else if (Seed[Index] == 'O')
        {
            Console.SetCursorPosition(x[mode], y[mode] - 1);
            Console.Write(block[mode] + block[mode]);
            Console.SetCursorPosition(x[mode], y[mode]);
            Console.Write(block[mode] + block[mode]);

        }
        else if (Seed[Index] == 'I')
        {
            if (Rot == 1)
            {
                Console.SetCursorPosition(x[mode] - 2, y[mode] - 1);
                Console.Write(block[mode] + block[mode] + block[mode] + block[mode]);
            }
            else if (Rot == 2)
            {
                Console.SetCursorPosition(x[mode] + 2, y[mode] - 2);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode] + 2, y[mode] - 1);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode] + 2, y[mode]);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode] + 2, y[mode] + 1);
                Console.Write(block[mode]);
            }
            else if (Rot == 3)
            {
                Console.SetCursorPosition(x[mode] - 2, y[mode]);
                Console.Write(block[mode] + block[mode] + block[mode] + block[mode]);
            }
            else if (Rot == 4)
            {
                Console.SetCursorPosition(x[mode], y[mode] - 2);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode], y[mode] - 1);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode], y[mode]);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode], y[mode] + 1);
                Console.Write(block[mode]);
            }
        }
        else if (Seed[Index] == 'S')
        {
            if (Rot == 1)
            {
                Console.SetCursorPosition(x[mode], y[mode] - 1);
                Console.Write(block[mode] + block[mode]);
                Console.SetCursorPosition(x[mode] - 2, y[mode]);
                Console.Write(block[mode] + block[mode]);
            }
            else if (Rot == 2)
            {
                Console.SetCursorPosition(x[mode], y[mode] - 1);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode], y[mode]);
                Console.Write(block[mode] + block[mode]);
                Console.SetCursorPosition(x[mode] + 2, y[mode] + 1);
                Console.Write(block[mode]);
            }
            else if (Rot == 3)
            {
                Console.SetCursorPosition(x[mode], y[mode]);
                Console.Write(block[mode] + block[mode]);
                Console.SetCursorPosition(x[mode] - 2, y[mode] + 1);
                Console.Write(block[mode] + block[mode]);
            }
            else if (Rot == 4)
            {
                Console.SetCursorPosition(x[mode] - 2, y[mode] - 1);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode] - 2, y[mode]);
                Console.Write(block[mode] + block[mode]);
                Console.SetCursorPosition(x[mode], y[mode] + 1);
                Console.Write(block[mode]);
            }
        }
        else if (Seed[Index] == 'Z')
        {
            if (Rot == 1)
            {
                Console.SetCursorPosition(x[mode] - 2, y[mode] - 1);
                Console.Write(block[mode] + block[mode]);
                Console.SetCursorPosition(x[mode], y[mode]);
                Console.Write(block[mode] + block[mode]);
            }
            else if (Rot == 2)
            {
                Console.SetCursorPosition(x[mode] + 2, y[mode] - 1);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode], y[mode]);
                Console.Write(block[mode] + block[mode]);
                Console.SetCursorPosition(x[mode], y[mode] + 1);
                Console.Write(block[mode]);
            }
            else if (Rot == 3)
            {
                Console.SetCursorPosition(x[mode] - 2, y[mode]);
                Console.Write(block[mode] + block[mode]);
                Console.SetCursorPosition(x[mode], y[mode] + 1);
                Console.Write(block[mode] + block[mode]);
            }
            else if (Rot == 4)
            {
                Console.SetCursorPosition(x[mode], y[mode] - 1);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode] - 2, y[mode]);
                Console.Write(block[mode] + block[mode]);
                Console.SetCursorPosition(x[mode] - 2, y[mode] + 1);
                Console.Write(block[mode]);
            }
        }
        else if (Seed[Index] == 'J')
        {
            if (Rot == 1)
            {
                Console.SetCursorPosition(x[mode] - 2, y[mode] - 1);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode] - 2, y[mode]);
                Console.Write(block[mode] + block[mode] + block[mode]);
            }
            else if (Rot == 2)
            {
                Console.SetCursorPosition(x[mode], y[mode] - 1);
                Console.Write(block[mode] + block[mode]);
                Console.SetCursorPosition(x[mode], y[mode]);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode], y[mode] + 1);
                Console.Write(block[mode]);
            }
            else if (Rot == 3)
            {
                Console.SetCursorPosition(x[mode] - 2, y[mode]);
                Console.Write(block[mode] + block[mode] + block[mode]);
                Console.SetCursorPosition(x[mode] + 2, y[mode] + 1);
                Console.Write(block[mode]);
            }
            else if (Rot == 4)
            {
                Console.SetCursorPosition(x[mode], y[mode] - 1);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode], y[mode]);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode] - 2, y[mode] + 1);
                Console.Write(block[mode] + block[mode]);
            }
        }
        else if (Seed[Index] == 'L')
        {
            if (Rot == 1)
            {
                Console.SetCursorPosition(x[mode] + 2, y[mode] - 1);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode] - 2, y[mode]);
                Console.Write(block[mode] + block[mode] + block[mode]);
            }
            else if (Rot == 2)
            {
                Console.SetCursorPosition(x[mode], y[mode] - 1);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode], y[mode]);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode], y[mode] + 1);
                Console.Write(block[mode] + block[mode]);
            }
            else if (Rot == 3)
            {
                Console.SetCursorPosition(x[mode] - 2, y[mode]);
                Console.Write(block[mode] + block[mode] + block[mode]);
                Console.SetCursorPosition(x[mode] - 2, y[mode] + 1);
                Console.Write(block[mode]);
            }
            else if (Rot == 4)
            {
                Console.SetCursorPosition(x[mode] - 2, y[mode] - 1);
                Console.Write(block[mode] + block[mode]);
                Console.SetCursorPosition(x[mode], y[mode]);
                Console.Write(block[mode]);
                Console.SetCursorPosition(x[mode], y[mode] + 1);
                Console.Write(block[mode]);
            }
        }
    }
    public void RotateCW()
    {
        Rot++;
        if (Rot == 5)
        {
            Rot = 1;
        }
    }
    public void RotateCCW()
    {
        Rot--;
        if (Rot == 0)
        {
            Rot = 4;
        }
    }
    public void Vars()
    {
        OldX = PosX;
        OldY = PosY;
    }
}