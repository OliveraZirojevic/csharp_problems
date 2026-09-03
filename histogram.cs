using System;
class histogram {
    static void Main() {
        string[] s = Console.ReadLine().Split();
        double a = double.Parse(s[0]);
        double b = double.Parse(s[1]);
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        double[] merenja = new double[k];
        int[] podeoci = new int[n];
        for (int i = 0; i < k; i++)
        {
            merenja[i] = double.Parse(Console.ReadLine());
            for (int podeok = 0; podeok < n; podeok++) 
            {
                if (merenja[i] < (podeok + 1)*((b - a)/n))
                {
                    podeoci[podeok] += 1;
                    break;
                }
            }
        }
        for (int element = 0; element < n; element++) {
           Console.Write("[{0}, {1}): {2}    ", (((b - a)/n)*element).ToString("0.000"), (((b - a)/n)*(element + 1)).ToString("0.000"), podeoci[element]);
           for (int j = 0; j < Math.Round(((double)100*podeoci[element])/n); j++) {
               Console.Write("*");
           }
           Console.WriteLine();
        }
        
    }
}