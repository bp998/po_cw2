using ProjektZaj2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZaj2
{
    public abstract class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Stanowisko { get; set; }
        public decimal Wynagrodzenie { get; set; }

        public abstract void PokazInformacje();
        public virtual decimal ObliczRoczneWynagrodzenie()
        {
            return Wynagrodzenie * 12;
        } 
    }
}

public class PracownikZdalny : Pracownik
{
    public int IloscDniZdalnych { get; set; }

    public virtual decimal ObliczRoczneWynagrodzenie()
    {
        return Wynagrodzenie * 12;
    }
    public override void PokazInformacje()
    {
        Console.WriteLine($"Imie: {Imie}, Nazwisko: {Nazwisko}, Stanowisko: {Stanowisko}, Wynagrodzenie: {Wynagrodzenie}, Ilosc dni zdalnych: {IloscDniZdalnych}");
        Console.WriteLine("\r\n");
    }
}

public class PracownikBiurowy : Pracownik
{
    public int IloscGodzinPracy { get; set; }

    public virtual decimal ObliczRoczneWynagrodzenie()
    {
        return Wynagrodzenie * 12;
    }
    public override void PokazInformacje()
    {
        Console.WriteLine($"Imie: {Imie}, Nazwisko: {Nazwisko}, Stanowisko: {Stanowisko}, Wynagrodzenie: {Wynagrodzenie}, Ilosc godzin pracy: {IloscGodzinPracy}");
        Console.WriteLine("\r\n");
    }

}

public class Menadzer : Pracownik
{
    public int BonusRoczny { get; set; }

    public override void PokazInformacje()
    {
        Console.WriteLine($"Imie: {Imie}, Nazwisko: {Nazwisko}, Stanowisko: {Stanowisko}, Wynagrodzenie: {Wynagrodzenie}, Bonus roczny: {BonusRoczny}");
        Console.WriteLine("\r\n");
    }
}
