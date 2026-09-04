using System;
class sort_3 {
    static void Main() {
        double prvi = double.Parse(Console.ReadLine());
        double drugi = double.Parse(Console.ReadLine());
        double treci = double.Parse(Console.ReadLine());
        double min, sred, max;
        if ((treci > prvi) && (treci > drugi)) {
            max = treci;
            min = (prvi < drugi) ? prvi : drugi;
            sred = (prvi > drugi) ? prvi : drugi;
        }
        else if ((treci > prvi) || (treci > drugi)) {
            sred = treci;
            min = (prvi < drugi) ? prvi : drugi;
            max = (prvi > drugi) ? prvi : drugi; 
        }
        else {
            min = treci;
            sred = (prvi < drugi) ? prvi : drugi;
            max = (prvi > drugi) ? prvi : drugi;
        }
        Console.WriteLine(min);
        Console.WriteLine(sred);
        Console.WriteLine(max);
    }
}