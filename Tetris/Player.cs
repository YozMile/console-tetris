using System.Text;
namespace Tetris;
public class Player
{
    public byte[,] CollMap = new byte[12, 24];
    public Player(int multiplier)
    {
        for (int i = 0; i < CollMap.GetLength(0); i++)
        {
            CollMap[i, 23] = 1;
        }
        for (int i = 0; i < CollMap.GetLength(1); i++)
        {
            CollMap[0, i] = 1;
            CollMap[11, i] = 1;
        }
        PosX = 5;
        PosY = 2;
        OldX = PosX;
        OldY = PosY;
        Rot = 1;
        Index = 0;
        Multiplier = multiplier;
        FirstHold = true;
        Held = 600;
        Seed = GenSeed();
        Points = 0;
        Level = 1;
        ClearedLines = 0;
        Threashhold = 10;
        Coll = new Collision(this);
        Line = new Line(this);
        Prints = new Print(this);
        TotalPlayers++;
    }
    public static int TotalPlayers;
    public byte PosX { get; set; }
    public byte PosY { get; set; }
    public byte OldX { get; set; }
    public byte OldY { get; set; }
    public string Seed { get; private set; }
    public int Index { get; set; }
    public int Held { get; set; }
    private bool FirstHold { get; set; }
    private int RememberedIndex { get; set; }
    public byte Rot { get; set; }
    public int Multiplier { get; set; }
    public long Points { get; set; }
    public int ClearedLines { get; set; }
    public int Threashhold { get; set; }
    public int Level { get; set; }
    public int FallSpeed
    {
        get
        {
            switch (Level)
            {
                case 1: return OperatingSystem.IsLinux() ? 1500000 : 24000;
                case 2: return OperatingSystem.IsLinux() ? 1448276   : 20500;
                case 3: return OperatingSystem.IsLinux() ? 1396552   : 17000;
                case 4: return OperatingSystem.IsLinux() ? 1344828   : 13500;
                case 5: return OperatingSystem.IsLinux() ? 1293104   : 10000;
                case 6: return OperatingSystem.IsLinux() ? 1241380   : 8700;
                case 7: return OperatingSystem.IsLinux() ? 1189656   : 7400;
                case 8: return OperatingSystem.IsLinux() ? 1137932   : 6100;
                case 9: return OperatingSystem.IsLinux() ? 1086208   : 4800;
                case 10: return OperatingSystem.IsLinux() ? 1034484   : 4500;
                case 11: return OperatingSystem.IsLinux() ? 982760   : 4251;
                case 12: return OperatingSystem.IsLinux() ? 931036   : 4001;
                case 13: return OperatingSystem.IsLinux() ? 879312   : 3751;
                case 14: return OperatingSystem.IsLinux() ? 827588   : 3501;
                case 15: return OperatingSystem.IsLinux() ? 775864   : 3251;
                case 16: return OperatingSystem.IsLinux() ? 724140   : 3001;
                case 17: return OperatingSystem.IsLinux() ? 672416   : 2751;
                case 18: return OperatingSystem.IsLinux() ? 620692   : 2501;
                case 19: return OperatingSystem.IsLinux() ? 568968   : 2251;
                case 20: return OperatingSystem.IsLinux() ? 517244   : 2001;
                case 21: return OperatingSystem.IsLinux() ? 465520   : 1751;
                case 22: return OperatingSystem.IsLinux() ? 413796   : 1501;
                case 23: return OperatingSystem.IsLinux() ? 362072   : 1251;
                case 24: return OperatingSystem.IsLinux() ? 310348   : 1001;
                case 25: return OperatingSystem.IsLinux() ? 258624   : 751;
                case 26: return OperatingSystem.IsLinux() ? 206900   : 501;
                case 27: return OperatingSystem.IsLinux() ? 155176   : 501;
                case 28: return OperatingSystem.IsLinux() ? 103452   : 251;
                case 29: return OperatingSystem.IsLinux() ? 51728   : 1;

            }
            return 0;
        }
    }
    public Collision Coll;
    public Line Line;
    public Print Prints;
    public void Hold()
    {
        if (FirstHold)
        {
            Held = Index;
            Map(0);
            NextPiece();
        }
        else
        {
            RememberedIndex = Index;
            Map(0);
            Index = Held;
            Held = RememberedIndex;
            PosX = 5;
            PosY = 2;
            OldX = PosX;
            OldY = PosY;
            Rot = 1;
        }
        Prints.PrintHeld();
    }
    public void AfterHold()
    {
        if (!FirstHold)
        {
            Index = RememberedIndex + 1;
            PosX = 5;
            PosY = 2;
            OldX = PosX;
            OldY = PosY;
            Rot = 1;
            Line.Check();
            Line.Clear();
            Prints.PrintNext();
        }
        else
        {
            FirstHold = false;
        }
    }
    public void NextLevel()
    {
        if (Level != 29)
        {
            if (ClearedLines >= Threashhold)
            {
                Level++;
                Threashhold += 10;
            }
        }
    }
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
        PosX = 5;
        PosY = 2;
        OldX = PosX;
        OldY = PosY;
        Rot = 1;
        Index++;
        if (Index == 532)
        {
            Index = 0;
        }
        Line.Check();
        Line.Clear();
        Prints.PrintNext();
        Map(1);
    }
    public void Map(int mode)
    {
        byte[] x = new byte[] { OldX, PosX };
        byte[] y = new byte[] { OldY, PosY };
        if (Seed[Index] == 'T')
        {
            byte[] type = new byte[] { 0, 2 };
            if (Rot == 1)
            {
                CollMap[x[mode], y[mode] - 1] = type[mode];
                CollMap[x[mode] - 1, y[mode]] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode] + 1, y[mode]] = type[mode];
            }
            else if (Rot == 2)
            {
                CollMap[x[mode], y[mode] - 1] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode] + 1, y[mode]] = type[mode];
                CollMap[x[mode], y[mode] + 1] = type[mode];
            }
            else if (Rot == 3)
            {
                CollMap[x[mode] - 1, y[mode]] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode] + 1, y[mode]] = type[mode];
                CollMap[x[mode], y[mode] + 1] = type[mode];
            }
            else if (Rot == 4)
            {
                CollMap[x[mode], y[mode] - 1] = type[mode];
                CollMap[x[mode] - 1, y[mode]] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode], y[mode] + 1] = type[mode];
            }
        }
        else if (Seed[Index] == 'O')
        {
            byte[] type = new byte[] { 0, 3 };
            CollMap[x[mode], y[mode] - 1] = type[mode];
            CollMap[x[mode] + 1, y[mode] - 1] = type[mode];
            CollMap[x[mode], y[mode]] = type[mode];
            CollMap[x[mode] + 1, y[mode]] = type[mode];
        }
        else if (Seed[Index] == 'I')
        {
            byte[] type = new byte[] { 0, 4 };
            if (Rot == 1)
            {
                CollMap[x[mode] - 1, y[mode]] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode] + 1, y[mode]] = type[mode];
                CollMap[x[mode] + 2, y[mode]] = type[mode];
            }
            else if (Rot == 2)
            {
                CollMap[x[mode] + 1, y[mode] - 1] = type[mode];
                CollMap[x[mode] + 1, y[mode]] = type[mode];
                CollMap[x[mode] + 1, y[mode] + 1] = type[mode];
                CollMap[x[mode] + 1, y[mode] + 2] = type[mode];
            }
            else if (Rot == 3)
            {
                CollMap[x[mode] - 1, y[mode] + 1] = type[mode];
                CollMap[x[mode], y[mode] + 1] = type[mode];
                CollMap[x[mode] + 1, y[mode] + 1] = type[mode];
                CollMap[x[mode] + 2, y[mode] + 1] = type[mode];
            }
            else if (Rot == 4)
            {
                CollMap[x[mode], y[mode] - 1] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode], y[mode] + 1] = type[mode];
                CollMap[x[mode], y[mode] + 2] = type[mode];
            }
        }
        else if (Seed[Index] == 'S')
        {
            byte[] type = new byte[] { 0, 5 };
            if (Rot == 1)
            {
                CollMap[x[mode], y[mode] - 1] = type[mode];
                CollMap[x[mode] + 1, y[mode] - 1] = type[mode];
                CollMap[x[mode] - 1, y[mode]] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
            }
            else if (Rot == 2)
            {
                CollMap[x[mode], y[mode] - 1] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode] + 1, y[mode]] = type[mode];
                CollMap[x[mode] + 1, y[mode] + 1] = type[mode];
            }
            else if (Rot == 3)
            {
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode] + 1, y[mode]] = type[mode];
                CollMap[x[mode] - 1, y[mode] + 1] = type[mode];
                CollMap[x[mode], y[mode] + 1] = type[mode];
            }
            else if (Rot == 4)
            {
                CollMap[x[mode] - 1, y[mode] - 1] = type[mode];
                CollMap[x[mode] - 1, y[mode]] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode], y[mode] + 1] = type[mode];
            }
        }
        else if (Seed[Index] == 'Z')
        {
            byte[] type = new byte[] { 0, 6 };
            if (Rot == 1)
            {
                CollMap[x[mode] - 1, y[mode] - 1] = type[mode];
                CollMap[x[mode], y[mode] - 1] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode] + 1, y[mode]] = type[mode];
            }
            else if (Rot == 2)
            {
                CollMap[x[mode] + 1, y[mode] - 1] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode] + 1, y[mode]] = type[mode];
                CollMap[x[mode], y[mode] + 1] = type[mode];
            }
            else if (Rot == 3)
            {
                CollMap[x[mode] - 1, y[mode]] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode], y[mode] + 1] = type[mode];
                CollMap[x[mode] + 1, y[mode] + 1] = type[mode];
            }
            else if (Rot == 4)
            {
                CollMap[x[mode], y[mode] - 1] = type[mode];
                CollMap[x[mode] - 1, y[mode]] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode] - 1, y[mode] + 1] = type[mode];
            }
        }
        else if (Seed[Index] == 'J')
        {
            byte[] type = new byte[] { 0, 7 };
            if (Rot == 1)
            {
                CollMap[x[mode] - 1, y[mode] - 1] = type[mode];
                CollMap[x[mode] - 1, y[mode]] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode] + 1, y[mode]] = type[mode];
            }
            else if (Rot == 2)
            {
                CollMap[x[mode] + 1, y[mode] - 1] = type[mode];
                CollMap[x[mode], y[mode] - 1] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode], y[mode] + 1] = type[mode];
            }
            else if (Rot == 3)
            {
                CollMap[x[mode] - 1, y[mode]] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode] + 1, y[mode]] = type[mode];
                CollMap[x[mode] + 1, y[mode] + 1] = type[mode];
            }
            else if (Rot == 4)
            {
                CollMap[x[mode], y[mode] - 1] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode] - 1, y[mode] + 1] = type[mode];
                CollMap[x[mode], y[mode] + 1] = type[mode];
            }
        }
        else if (Seed[Index] == 'L')
        {
            byte[] type = new byte[] { 0, 8 };
            if (Rot == 1)
            {
                CollMap[x[mode] + 1, y[mode] - 1] = type[mode];
                CollMap[x[mode] - 1, y[mode]] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode] + 1, y[mode]] = type[mode];
            }
            else if (Rot == 2)
            {
                CollMap[x[mode], y[mode] - 1] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode], y[mode] + 1] = type[mode];
                CollMap[x[mode] + 1, y[mode] + 1] = type[mode];
            }
            else if (Rot == 3)
            {
                CollMap[x[mode] - 1, y[mode]] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode] + 1, y[mode]] = type[mode];
                CollMap[x[mode] - 1, y[mode] + 1] = type[mode];
            }
            else if (Rot == 4)
            {
                CollMap[x[mode] - 1, y[mode] - 1] = type[mode];
                CollMap[x[mode], y[mode] - 1] = type[mode];
                CollMap[x[mode], y[mode]] = type[mode];
                CollMap[x[mode], y[mode] + 1] = type[mode];
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
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < CollMap.GetLength(1); i++)
        {
            sb.Append("\n" + new string(' ', 16));
            for (int j = 0; j < CollMap.GetLength(0); j++)
            {
                sb.Append($"{CollMap[j, i]} ");
            }
        }
        return sb.ToString();
    }
}