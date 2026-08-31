using System;
class are_all_digits_different
{
    static bool pretrazi(int a, int i)
    {
        int brojac = 0;
        int b = a;
        while (b != 0)
        {
           if (b % 10 == i) 
            {
                brojac++;
            } 
        b = b / 10;
        }
        if (brojac > 1)
        {
            return false;
        }
        else
        {
            return true;
        }}
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        if (pretrazi(n, 1) && pretrazi(n, 2) && pretrazi(n, 3) && pretrazi(n, 4) && pretrazi(n, 5) && pretrazi(n, 6) && pretrazi(n, 7) && pretrazi(n, 8) && pretrazi(n, 9) && pretrazi(n, 0))
        {
            Console.WriteLine("DA");
        }
        else
        {
            Console.WriteLine("NE");
        }
    }
    }