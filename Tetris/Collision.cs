using System.Text;
namespace Tetris;
public class Collision
{
    public Collision(Player p)
    {
        P = p;
    }
    private Player P;
    public bool Right()
    {
        if (P.Seed[P.Index] == 'T')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX + 2, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX + 2, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX + 2, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'O')
        {
            if (P.CollMap[P.PosX + 2, P.PosY - 1] == 0 && P.CollMap[P.PosX + 2, P.PosY] == 0)
            {
                return true;
            }
        }
        else if (P.Seed[P.Index] == 'I')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX + 3, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX + 2, P.PosY - 1] == 0 && P.CollMap[P.PosX + 2, P.PosY] == 0 && P.CollMap[P.PosX + 2, P.PosY + 1] == 0 && P.CollMap[P.PosX + 2, P.PosY + 2] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX + 3, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 2] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'S')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX + 2, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX + 2, P.PosY] == 0 && P.CollMap[P.PosX + 2, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX + 2, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'Z')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX + 2, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX + 2, P.PosY - 1] == 0 && P.CollMap[P.PosX + 2, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX + 2, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'J')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX + 2, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX + 2, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX + 2, P.PosY] == 0 && P.CollMap[P.PosX + 2, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'L')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX + 2, P.PosY - 1] == 0 && P.CollMap[P.PosX + 2, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX + 2, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX + 2, P.PosY] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }



    public bool Left()
    {
        if (P.Seed[P.Index] == 'T')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 2, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX - 2, P.PosY] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 2, P.PosY] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'O')
        {
            if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0)
            {
                return true;
            }
        }
        else if (P.Seed[P.Index] == 'I')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX - 2, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 2] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX - 2, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX - 1, P.PosY + 2] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'S')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 2, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX - 2, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 2, P.PosY - 1] == 0 && P.CollMap[P.PosX - 2, P.PosY] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'Z')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX - 2, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX - 2, P.PosY] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 2, P.PosY] == 0 && P.CollMap[P.PosX - 2, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'J')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX - 2, P.PosY - 1] == 0 && P.CollMap[P.PosX - 2, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX - 2, P.PosY] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX - 2, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'L')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX - 2, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX - 2, P.PosY] == 0 && P.CollMap[P.PosX - 2, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 2, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX - 2, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }



    public bool Down()
    {
        if (P.Seed[P.Index] == 'T')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX+1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX, P.PosY + 2] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 2] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 2] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'O')
        {
            if (P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
            {
                return true;
            }
        }
        else if (P.Seed[P.Index] == 'I')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0 && P.CollMap[P.PosX + 2, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX + 1, P.PosY + 3] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 2] == 0 && P.CollMap[P.PosX, P.PosY + 2] == 0 && P.CollMap[P.PosX + 1, P.PosY + 2] == 0 && P.CollMap[P.PosX + 2, P.PosY + 2] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX, P.PosY + 3] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'S')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 2] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 2] == 0 && P.CollMap[P.PosX, P.PosY + 2] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 2] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'Z')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX, P.PosY + 2] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 2] == 0 && P.CollMap[P.PosX + 1, P.PosY + 2] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 2] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'J')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX, P.PosY + 2] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 2] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 2] == 0 && P.CollMap[P.PosX, P.PosY + 2] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'L')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX, P.PosY + 2] == 0 && P.CollMap[P.PosX + 1, P.PosY + 2] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 2] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX, P.PosY + 2] == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }



    public bool RotationCW()
    {
        if (P.Seed[P.Index] == 'T')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX - 1, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX + 1, P.PosY] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'I')
        {
            if (P.PosX == 1)
            {
                if (P.Rot == 1)
                {
                    if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 2] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 2)
                {
                    if (P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 2, P.PosY + 1] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 3)
                {
                    if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY] == 0 && P.CollMap[P.PosX, P.PosY + 2] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 4)
                {
                    if (P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX + 2, P.PosY] == 0)
                    {
                        return true;
                    }
                }
            }
            else if(P.PosX == 10)
            {
                if (P.Rot == 1)
                {
                    if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 2] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 2)
                {
                    if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 2, P.PosY + 1] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 3)
                {
                    if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY] == 0 && P.CollMap[P.PosX, P.PosY + 2] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 4)
                {
                    if (P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0)
                    {
                        return true;
                    }
                }
            }
            else
            {
                if (P.Rot == 1)
                {
                    if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 2] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 2)
                {
                    if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 2, P.PosY + 1] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 3)
                {
                    if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY] == 0 && P.CollMap[P.PosX, P.PosY + 2] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 4)
                {
                    if (P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX + 2, P.PosY] == 0)
                    {
                        return true;
                    }
                }
            }

        }
        else if (P.Seed[P.Index] == 'S')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY - 1] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'Z')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'J')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'L')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }



    public bool RotationCCW()
    {
        if (P.Seed[P.Index] == 'T')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX + 1, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 1, P.PosY] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'I')
        {
            if(P.PosX == 1)
            {
                if (P.Rot == 1)
                {
                    if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 2] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 2)
                {
                    if (P.CollMap[P.PosX, P.PosY] == 0 && P.CollMap[P.PosX + 2, P.PosY] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 3)
                {
                    if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 2] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 4)
                {
                    if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0 && P.CollMap[P.PosX + 2, P.PosY + 1] == 0)
                    {
                        return true;
                    }
                }
            }
            else if (P.PosX == 10)
            {
                if (P.Rot == 1)
                {
                    if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 2] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 2)
                {
                    if (P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX, P.PosY] == 0 && P.CollMap[P.PosX + 2, P.PosY] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 3)
                {
                    if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 2] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 4)
                {
                    if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                    {
                        return true;
                    }
                }
            }
            else
            {
                if (P.Rot == 1)
                {
                    if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 2] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 2)
                {
                    if (P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX, P.PosY] == 0 && P.CollMap[P.PosX + 2, P.PosY] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 3)
                {
                    if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 2] == 0)
                    {
                        return true;
                    }
                }
                else if (P.Rot == 4)
                {
                    if (P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0 && P.CollMap[P.PosX + 2, P.PosY + 1] == 0)
                    {
                        return true;
                    }
                }
            }
        }
        else if (P.Seed[P.Index] == 'S')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'Z')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY - 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'J')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
        }
        else if (P.Seed[P.Index] == 'L')
        {
            if (P.Rot == 1)
            {
                if (P.CollMap[P.PosX - 1, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 2)
            {
                if (P.CollMap[P.PosX + 1, P.PosY - 1] == 0 && P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 3)
            {
                if (P.CollMap[P.PosX, P.PosY - 1] == 0 && P.CollMap[P.PosX, P.PosY + 1] == 0 && P.CollMap[P.PosX + 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
            else if (P.Rot == 4)
            {
                if (P.CollMap[P.PosX - 1, P.PosY] == 0 && P.CollMap[P.PosX + 1, P.PosY] == 0 && P.CollMap[P.PosX - 1, P.PosY + 1] == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }
}