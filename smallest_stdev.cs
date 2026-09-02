using System;
class smallest_stdev
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] a = new double[n];
        double suma = 0;
        for (int i = 0; i < n; i++)
        {
            a[i] = double.Parse(Console.ReadLine());
            suma += a[i];
        }
        double prosek = suma / n;
        double minimal = 100000000;
        for (int j = 0; j < n; j++)
        {
            minimal = Math.Min(Math.Abs(prosek - a[j]), minimal);
        }
        Console.WriteLine(minimal.ToString("0.00"));
        }
}