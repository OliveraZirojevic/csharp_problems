using System;
class armstrong_numbers_using_method {
    static int broj_cifara(int n) {
        int count = 0;
        while (n != 0) {
            count++;
            n /= 10;
        }
        return count;
    }
    static int armstrong(int n, int k) {
        int sum = 0;
        int rez = 1;
        int ni = n;
        for (int i = 1; i <= k; i++) {
            rez = (int)Math.Pow((ni % 10), k);
            sum += rez;
            ni /= 10;
        }
        return sum;
    }
    static void Main() {
    int n = int.Parse(Console.ReadLine());
    
    if (n == armstrong(n, broj_cifara(n))) {
        Console.WriteLine("DA");
    }
    else Console.WriteLine("NE");
    }
}