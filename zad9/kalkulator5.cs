using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("podaj dzialanie");
        string dzialanie = Console.ReadLine();

        char[] znaki = new char[dzialanie.Length];
        int[] mznak = new int[dzialanie.Length];
        int licznik = 0, pocz, konic;
        for(int i =0;i<dzialanie.Length;i++){
            if(dzialanie[i] =='+'||dzialanie[i] =='-'||dzialanie[i] =='*'||dzialanie[i] =='/'){
                znaki[licznik] = dzialanie[i];
                mznak[licznik] = i;
                licznik++;
            }
        }
        double[] liczby = new double[licznik+1];
        for (int i1 = 0; i1 < licznik + 1; i1++){
            if (i1 == 0) pocz = 0;

            else pocz = mznak[i1 - 1] + 1;
            
            if (i1 == licznik)konic = dzialanie.Length - pocz; 
            
            else konic = mznak[i1] - pocz; 
            
            liczby[i1] = double.Parse(dzialanie.Substring(pocz, konic));  
        }
        
        double wynik = liczby[0];

        for(int i2=0;i2<licznik;i2++){
            if (znaki[i2] == '+')
                wynik = Dodawanie(wynik, liczby[i2 +1]);
            else if (znaki[i2] == '-')
                wynik = Odejmowanie(wynik, liczby[i2 +1 ]);
            else if (znaki[i2] == '*')
                wynik = Mnorzenie(wynik, liczby[i2 +1 ]);
            else if (znaki[i2] == '/')
                wynik = Dzielenie(wynik, liczby[i2 +1 ]);
        }
          Console.WriteLine(wynik);
    }
           
    static double Dodawanie(double a, double b)
    {   
        return a+b;
    }

    static double Odejmowanie(double a, double b)
    {
        return a - b;
    }

    static double Mnorzenie(double a, double b)
    {
        return a * b;
    }

    static double Dzielenie(double a, double b)
    {
        return a / b;
    }
}