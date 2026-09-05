using System;
class tommorow {
    static void Main() {
        int dan = int.Parse(Console.ReadLine());
        int mesec = int.Parse(Console.ReadLine());
        int godina = int.Parse(Console.ReadLine());
        
        if (dan == 1) {
            switch(mesec) {
                case 1: dan = 31; godina--; mesec = 13; break;
                case 2: dan = 31; break;
                case 3: if ((godina % 400 == 0) || ((godina % 100 != 0) && (godina % 4 == 0))) {dan = 29;} else {dan = 28;}; break;
                case 4: dan = 31; break;
                case 5: dan = 30; break;
                case 6: dan = 31; break;
                case 7: dan = 30; break;
                case 8: dan = 31; break;
                case 9: dan = 31; break;
                case 10: dan = 30; break;
                case 11: dan = 31; break;
                case 12: dan = 30; break;
            }
            mesec--;
        }
        
        else {
            dan--;
        }
        
        Console.WriteLine("{0}.{1}.{2}.", dan, mesec, godina);
    }
} 