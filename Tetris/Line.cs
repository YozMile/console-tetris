namespace Tetris;
public class Line
{
    public Line(Player p)
    {
        P = p;
        FullLines = new Dictionary<byte, bool>();
    }
    private Player P;
    public Dictionary<byte, bool> FullLines;
    public void Check()
    {
        for (byte i = 2; i < P.CollMap.GetLength(1)-1; i++)
        {
            if (P.CollMap[1, i] > 0 && P.CollMap[2, i] > 0 && P.CollMap[3, i] > 0 && P.CollMap[4, i] > 0 && P.CollMap[5, i] > 0 && P.CollMap[6, i] > 0 && P.CollMap[7, i] > 0 && P.CollMap[8, i] > 0 && P.CollMap[9, i] > 0 && P.CollMap[10, i] > 0)
            {
                FullLines.Add(i, true);
            }
        }
    }
    public bool CheckLoss()
    {
        if (P.CollMap[1, 2] > 0 || P.CollMap[2, 2] > 0 || P.CollMap[3, 2] > 0 || P.CollMap[4, 2] > 0 || P.CollMap[5, 2] > 0 || P.CollMap[6, 2] > 0 || P.CollMap[7, 2] > 0 || P.CollMap[8, 2] > 0 || P.CollMap[9, 2] > 0 || P.CollMap[10, 2] > 0)
        {
            return true;
        }
        return false;
    }
    public void Clear()
    {
        foreach (var item in FullLines.Keys)
        {
            for (int i = 1; i < P.CollMap.GetLength(0)-1; i++)
            {
                P.CollMap[i, item] = 0;
            }
            Shift(item);
        }        
        switch(FullLines.Count)
        {
            case 0:
                break;
            case 1:
                P.Points += (40 * P.Level);
                break;
            case 2:
                P.Points += (100 * P.Level);
                break;
            case 3:
                P.Points += (300 * P.Level);
                break;
            case 4:
                P.Points += (1200 * P.Level);
                break;
        }
        P.ClearedLines += FullLines.Count;
        FullLines.Clear();
    }
    private void Shift(byte y)
    {
        for (int j = y; j >= 3 ; j--)
        {
            for (int i = 1; i < P.CollMap.GetLength(0)-1; i++)
            {
                P.CollMap[i, j] = P.CollMap[i, j - 1];
            }
        }
    }
}