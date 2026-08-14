using System;
class milje {
    static void Main() {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        double km = 0;
        double milja = 1609.33 / 1000

        for (int i = a; i <= b; i += 2) {
            km = i*milja
            Console.WriteLine("{0} mi = {1} km", i, km);
        }
    }
}