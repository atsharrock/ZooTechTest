using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Random isnt truly random if you use it in a for loop at least, as it takes values from the CPU.
/// This mitigates that quite a bit.
/// </summary>
public static class RandomNumberGenerator
{

    private static readonly Random getrandom = new Random();

    public static int GetRandomNumber(int min, int max)
    {
        lock (getrandom) // synchronize
        {
            return getrandom.Next(min, max);
        }
    }
}

