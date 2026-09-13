using System;
class firstandsecondtobest {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int max = -1;
        int sec = max;
        for (int i = 0; i < n; i++) {
            int u = int.Parse(Console.ReadLine());
            if ((u > max) && (u != max)) {
                sec = max;
                max = u;
            }
            else if ((u > sec) && (u != sec) && (u != max)) {
                sec = u;
            }
        }
        Console.WriteLine(max);
        Console.WriteLine(sec);
    }
}