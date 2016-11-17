using System;

namespace Zakupy
{
    class Produkt
    {
        private string nazwa;
        private int cena;
        private int ilosc;

        public Produkt(string nazwa, int cena, int ilosc)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.ilosc = ilosc;
        }

        public int podajCene()
        {
            return ilosc * cena;
        }

        public string podajNazwe()
        {
            return nazwa;
        }
    }
    class Koszyk
    {
        private Produkt[] zakupy = new Produkt[25]; // nie są to obiekty a tablica NA nie
        private int cena;
        private int ilosc_elementow;

        public void włóżDoKoszyka(Produkt przedmiot)
        {
            zakupy[ilosc_elementow++] = przedmiot; // wpisanie obiektu do tablicy
            cena += przedmiot.podajCene();
        }
        public int podajCeneKoszyka()
        {
            return cena;
        }
        public void podajZawartoscKoszyka()
        {
            for (int i = 0; i < ilosc_elementow; i++)
                Console.WriteLine((i + 1) + ": Nazwa: " + zakupy[i].podajNazwe() + ", cena: " + zakupy[i].podajCene());
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Produkt artykuł1 = new Produkt("Jabłko", 6, 2);
            Produkt artykuł2 = new Produkt("Groszek", 2, 5);
            Produkt artykuł3 = new Produkt("Banan", 3, 3);

            Koszyk Arek = new Koszyk();
            Arek.włóżDoKoszyka(artykuł1);
            Console.WriteLine("Aktualnie w koszyku:");
            Arek.podajZawartoscKoszyka();

            Arek.włóżDoKoszyka(artykuł2);
            Arek.włóżDoKoszyka(artykuł3);
            Console.WriteLine("\nAktualnie w koszyku:");
            Arek.podajZawartoscKoszyka();

            Console.WriteLine("\nCena zakupów: " + Arek.podajCeneKoszyka());
            Console.ReadLine();
        }
    }
}