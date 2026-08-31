using System;
class reverse_order
{
    static void Main() {
    int n = int.Parse(Console.ReadLine());
    int[] lista = new int[n];
    for (int i = 0; i < n; i++) {
        lista[i] = int.Parse(Console.ReadLine());
    }
    for (int j = (n - 1); j >= 0; j--) {
        Console.WriteLine(lista[j]);
    }
}}