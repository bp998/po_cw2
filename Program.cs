using ProjektZaj2;
using System;

//namespace Diagram

    class Program
{
    static void Main()
    {
        var pracownikZdalny = new PracownikZdalny
        {
            Imie = "Tomek",
            Nazwisko = "Kokoszka",
            Stanowisko = "Programista",
            Wynagrodzenie = 12000,
            IloscDniZdalnych = 20
        };

        var pracownikBiurowy = new PracownikBiurowy
        {
            Imie = "Robert",
            Nazwisko = "Lewandowski",
            Stanowisko = "Kopacz",
            Wynagrodzenie = 500000,
            IloscGodzinPracy = 10
        };
        var menadzer = new Menadzer
        {
            Imie = "Maciej",
            Nazwisko = "Konop",
            Stanowisko = "Menadzer",
            Wynagrodzenie = 20000,
            BonusRoczny = 5000
        };

        pracownikZdalny.PokazInformacje();
        pracownikBiurowy.PokazInformacje();
        menadzer.PokazInformacje();
    }
}