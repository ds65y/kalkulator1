using System;

class Program
{
    static char[] znaki; 
    static int[] mznak;   
    static int licznik = 0; 

    static void Main()
    {
        Console.WriteLine("Podaj dzialanie:");
        string dzialanie = Console.ReadLine();
        Znak(dzialanie);
        double wynik = 0d;
        double[] liczby = new double[licznik + 1];

       int pocz, koniec;
        for (int i1 = 0; i1 < licznik + 1; i1++){
            if (i1 == 0) pocz = 0;
            else pocz = mznak[i1 - 1] + 1;

            if (i1 == licznik) koniec = dzialanie.Length - pocz;
            else koniec = mznak[i1] - pocz;

            liczby[i1] = double.Parse(dzialanie.Substring(pocz, koniec));
        }

        wynik = liczby[0];

        for (int i2 = 0; i2 < licznik; i2++){
            if (znaki[i2] == '+')
                wynik = Dodawanie(wynik, liczby[i2 + 1]);
            else if (znaki[i2] == '-')
                wynik = Odejmowanie(wynik, liczby[i2 + 1]);
            else if (znaki[i2] == '*')
                wynik = Mnorzenie(wynik, liczby[i2 + 1]);
            else if (znaki[i2] == '/')
                wynik = Dzielenie(wynik, liczby[i2 + 1]);
        }

        Console.WriteLine("Wynik: " + wynik);
    }

    static void Znak(string dzialanie){
        znaki = new char[dzialanie.Length];
        mznak = new int[dzialanie.Length];
        licznik = 0;
        
        for (int i = 0; i < dzialanie.Length; i++){
            if (dzialanie[i] == '+' || dzialanie[i] == '-' || dzialanie[i] == '*' || dzialanie[i] == '/') {
             znaki[licznik] = dzialanie[i];
             mznak[licznik] = i;
             licznik++;
            }
        }
    }
    static double Dodawanie(double a, double b)    {return a + b;}
    static double Odejmowanie(double a, double b)    {return a - b;}
    static double Mnorzenie(double a, double b)    {return a * b;}
    static double Dzielenie(double a, double b)    {return a / b;}
}
