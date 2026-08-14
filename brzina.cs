using System;
class brzina {
    static void Main() {
        double v0 = double.Parse(Console.ReadLine());
        double a = double.Parse(Console.ReadLine());
        double t = double.Parse(Console.ReadLine());
        double dt = double.Parse(Console.ReadLine());

        for (int i = 0; i <= t; i += dt)
        {
            Console.WriteLine(v0*dt + (a*dt*dt)/2);
        }
    }
}