using System;
class sumos {
    static bool jelmoguce3(int a, int b, int c, int L) {
        if (a + b + c <= L) return true;
        else return false;
    }
    static bool jelmoguce2(int a, int b, int L) {
        if (a + b <= L) return true;
        else return false;
    }
    static void Main() {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    int L = int.Parse(Console.ReadLine());

    if (a + b + c + d <= L) {
        Console.WriteLine("1");
    }
    else if (jelmoguce3(a, b, c, L) || jelmoguce3(d, b, c, L) || jelmoguce3(a, d, c, L) || jelmoguce3(a, b, d, L)) {
        Console.WriteLine("2");
    }
    else if (jelmoguce2(a, b, L) || jelmoguce2(a, c, L) || jelmoguce2(a, d, L) || jelmoguce2(b, c, L) || jelmoguce2(d, b, L) || jelmoguce2(d, c, L)) {
       Console.WriteLine("3");
    }
    else {
        Console.WriteLine("4");
    }
}}