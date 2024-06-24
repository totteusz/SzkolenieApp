using System;
using System.Collections.Generic;
using System.Linq;

public class Uczestnik
{
    public int Id { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Adres { get; set; }
}

public class Szkolenie
{
    public int Id { get; set; }
    public string Nazwa { get; set; }
    public DateTime DataRozpoczecia { get; set; }
    public int CzasTrwaniaWDniach { get; set; }
    public string Opis { get; set; }
    public List<Uczestnik> Uczestnicy { get; set; } = new List<Uczestnik>();
}

public class KonsolowyWidok
{
    public void WyswietlMenu()
    {
        Console.WriteLine("1. Dodaj uczestnika");
        Console.WriteLine("2. Dodaj szkolenie");
        Console.WriteLine("3. Edytuj uczestnika");
        Console.WriteLine("4. Edytuj szkolenie");
        Console.WriteLine("5. Usuñ uczestnika");
        Console.WriteLine("6. Usuñ szkolenie");
        Console.WriteLine("7. Wyœwietl uczestników");
        Console.WriteLine("8. Wyœwietl szkolenia");
        Console.WriteLine("9. WyjdŸ");
    }

    public void WyswietlUczestnikow(List<Uczestnik> uczestnicy)
    {
        foreach (var uczestnik in uczestnicy)
        {
            Console.WriteLine($"{uczestnik.Id}: {uczestnik.Imie} {uczestnik.Nazwisko} - {uczestnik.Adres}");
        }
    }

    public void WyswietlSzkolenia(List<Szkolenie> szkolenia)
    {
        foreach (var szkolenie in szkolenia)
        {
            Console.WriteLine($"{szkolenie.Id}: {szkolenie.Nazwa} - {szkolenie.DataRozpoczecia.ToShortDateString()} - {szkolenie.CzasTrwaniaWDniach} dni - {szkolenie.Opis}");
        }
    }
}

#pragma warning disable CS0146 // Zadeklaruj typy w przestrzeniach nazw
public class KontrolerSzkolen : KontrolerSzkolen
#pragma warning restore CS0146 // Zadeklaruj typy w przestrzeniach nazw
{
    private List<Uczestnik> uczestnicy = new List<Uczestnik>();
    private List<Szkolenie> szkolenia = new List<Szkolenie>();
    public KonsolowyWidok widok = new KonsolowyWidok();
    private int nextUczestnikId = 1;
    private int nextSzkolenieId = 1;

    public void DodajUczestnika(Uczestnik uczestnik)
    {
        uczestnik.Id = nextUczestnikId++;
        uczestnicy.Add(uczestnik);
    }

    public void DodajSzkolenie(Szkolenie szkolenie)
    {
        szkolenie.Id = nextSzkolenieId++;
        szkolenia.Add(szkolenie);
    }

    public void EdytujUczestnika(int id, Uczestnik zaktualizowanyUczestnik)
    {
        if (zaktualizowanyUczestnik is null)
        {
            throw new ArgumentNullException(nameof(zaktualizowanyUczestnik));
        }
    }
}