using System.Runtime.CompilerServices;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace Testaus;

public static class Laskin
{
    public static void Main(string[] args)
    {
        
    }
    public static int MiinusLasku(int luku1, int luku2)
    {   
        int tulos = luku1 - luku2;
        return tulos;
    }
    public static int Potenssi(int luku)
    {
        int tulos = luku * luku;
        if (tulos > 100)
        {
            throw new ArgumentException("Luku ei saa olla suurempi kuin 100.");
            
        }
        return tulos;
    }
   public static double NelioJuuri(int luku)
   {
        double tulos = Math.Sqrt(luku);
        return tulos;
   }

}