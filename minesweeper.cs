using System;
class minesweeper {
    static void Main() {
        string[] s = Console.ReadLine().Split();
        int m = int.Parse(s[0]);
        int n = int.Parse(s[1]);
        int[ , ] mine = new int[m, n];
        for (int i = 0; i < m; i++) {
            string[] r = Console.ReadLine().Split();
            for (int j = 0; j < n; j++) {
                mine[i, j] = int.Parse(r[j]);
            }
        } 
        
        for (int i = 0; i < m; i++) {
            int d = 0;
           for (int j = 0; j < n; j++) {
              if (j == 0) {
                  d = mine[i, j + 1];
                  if (i == 0) {
                       d += mine[i + 1, j] + mine[i + 1, j + 1];
                  }
                  else if (i == (m - 1)) {
                      d += mine[i - 1, j] + mine[i - 1, j + 1];
                  }
                  else {
                     d += mine[i - 1, j] + mine[i + 1, j] + mine[i + 1, j + 1] + mine[i - 1, j + 1];
                  }
              } 
              else if (j == (n - 1)) {
                  d = mine[i, j - 1];
                  if (i == 0) {
                      d += mine[i + 1, j] + mine[i + 1, j - 1];
                  }
                  else if (i == (m - 1)) {
                      
                      d += mine[i - 1, j] + mine[i - 1, j - 1];
                  }
                  else {
                      d += mine[i - 1, j] + mine[i - 1, j - 1] + mine[i + 1, j - 1] + mine[i + 1, j];
                  }
              }
              else if (i == 0) {
                  d = mine[i, j + 1] + mine[i, j - 1] + mine[i + 1, j] + mine[i + 1, j - 1] + mine[i + 1, j + 1];
              }
              else if (i == (m - 1)) {
                  d = mine[i, j - 1] + mine[i, j + 1] + mine[i - 1, j] + mine[i - 1, j - 1] + mine[i - 1, j + 1];
              }
              else {
                  d = mine[i, j + 1] + mine[i, j - 1] + mine[i + 1, j] + mine[i + 1, j - 1] + mine[i + 1, j + 1] + mine[i - 1, j - 1] + mine[i - 1, j + 1] + mine[i - 1, j];
              }
              Console.Write("{0} ", d);
              
           } 
           Console.WriteLine();
        }
    }
}