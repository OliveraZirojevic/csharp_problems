using System;
class tommorow {
    static void Main() {
        int dan = int.Parse(Console.ReadLine());
        int mesec = int.Parse(Console.ReadLine());
        int godina = int.Parse(Console.ReadLine());
        
        if (dan == 31) {
            dan = 1;
            mesec++;
            if (mesec == 13) {
                godina++;
                mesec = 1;
            }
        }
        else if (dan == 30) {
            switch(mesec) {
                case 1: dan++; break;
                case 3: dan++; break;
                case 4: dan = 1; mesec++; break;
                case 5: dan++; break;
                case 6: dan = 1; mesec++; break;
                case 7: dan++; break;
                case 8: dan++; break;
                case 9: dan = 1; mesec++; break;
                case 10: dan++; break;
                case 11: dan = 1; mesec++; break;
                case 12: dan++; break;
            }
        }
        else if  ((mesec == 2) && (dan == 29)){
                dan = 1;
                mesec++;
        }
        else if ((mesec == 2) && (dan == 28) && !((godina % 400 == 0) || ((godina % 100 != 0) && (godina % 4 == 0)))) {
            dan = 1;
            mesec++;
        }
        else {
            dan++;
        }
        
        Console.WriteLine("{0}.{1}.{2}.", dan, mesec, godina);
    }
} 