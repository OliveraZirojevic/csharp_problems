using System;
class stdev_from_minimum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] a = new double[n];
        double minimal = 10000000000000;
        for (int i = 0; i < n; i++)
        {
            a[i] = double.Parse(Console.ReadLine());
            minimal = Math.Min(a[i], minimal);
        }
        double suma = 0;
        for (int j = 0; j < n; j++)
        {
            suma += a[j] - minimal;
        }
        suma /= n;
        Console.WriteLine((suma).ToString("0.00"));
        }
}