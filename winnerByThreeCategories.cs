using System;
class winner_by_three_cat {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int max = -1;
        int maxp = max;
        int maxm = max;
        int maxf = max;
        int count = 0;
        string[] kraj = new string[3];
        for (int i = 0; i < n; i++) {
            string[] t = Console.ReadLine().Split();
            int p = int.Parse(t[0]);
            int m = int.Parse(t[1]);
            int f = int.Parse(t[2]);

            if ((p + m + f) > max) {
                max = p + m + f;
                kraj = t;
                maxp = p;
                maxm = m;
                maxf = f;
                count = i + 1;
            }
            else if ((p + m + f) == max) {
                if (p > maxp) {
                    maxp = p;
                    kraj = t;
                    count = i + 1;
                }
                else if (p == maxp) {
                    if (m > maxm) {
                        maxm = m;
                        kraj = t;
                        count = i + 1;
                    }
                    else if (m == maxm) {
                        if (f > maxf) {
                            maxf = f;
                            kraj = t;
                            count = i + 1;
                        }
                    }
                }
            }
        }
        Console.WriteLine("{0}: {1} {2} {3}", count, kraj[0], kraj[1], kraj[2]);
    }
}