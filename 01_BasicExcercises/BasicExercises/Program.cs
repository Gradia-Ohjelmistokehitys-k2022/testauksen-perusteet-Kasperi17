using System.Runtime.CompilerServices;
using System;
public class laskin
{

    public static int miinuslasku(int luku1, int luku2)
    {
        return luku1 - luku2;

    }
    




}
public class laskintestit
{
    public bool miinuslaskutesti(int a, int b,int tulos) 
    {
        if (laskin.miinuslasku(a, b) != tulos)
        {
            return false;
        }
        else 
        { return true; }

    }
    


}