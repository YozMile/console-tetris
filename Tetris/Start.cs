using System.IO;
using System.Text;
namespace Tetris;
public class Start
{
    public static bool Debug;
    public static int Level = 1;
    static void Main(string[] args)
    {
        if(args != null && args.Length != 0)
        {
            if(args.Contains("-d"))
            {
                Debug = true;
            }
            if(args.Contains("-l"))
            {
                int.TryParse(args[Array.IndexOf(args, "-l") + 1], out Level);
            }
        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.CursorVisible = false;
        Player p1 = new Player(0);
        Movement move = new Movement(p1);
        move.Move();
        // FileStream fs = new FileStream(@".\Scores\Tetris.dat", FileMode.Open, FileAccess.Write, FileShare.None);
        // StreamWriter sw = new StreamWriter(fs);
        // sw.WriteLine($"{p1.Points};{p1.Level};{p1.ClearedLines}\n");
        // sw.Close();
        // fs.Close();
        Console.ResetColor();
        Console.Clear();
        Console.CursorVisible = true;
    }
}
