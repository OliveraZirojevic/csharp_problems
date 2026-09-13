using System;
class secondtobest {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int max = -1;
        int sec = max;
        for (int i = 0; i < n; i++) {
            int u = int.Parse(Console.ReadLine());
            if (u > max) {
                sec = max;
                max = u;
            }
            else if (u > sec) {
                sec = u;
            }
        }
        Console.WriteLine(sec);
    }
}