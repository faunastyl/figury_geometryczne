using System;

namespace FiguryGeometryczne
{
    class Kwadrat : FiguraGeometryczna
    {
        // Długość boku kwadratu
        public double bok;

        // Pobranie danych od użytkownika
        public override void PobierzDane()
        {
            Console.Write("Podaj dlugosc boku kwadratu: ");
            bok = Convert.ToDouble(Console.ReadLine());
        }

        // Obliczenie pola
        public override double ObliczPole()
        {
            Pole = bok * bok;
            return Pole;
        }

        // Obliczenie obwodu
        public override double ObliczObwod()
        {
            Obwod = 4 * bok;
            return Obwod;
        }

        // Wyświetlenie danych
        public override void WyswietlDane()
        {
            Console.WriteLine("\n=== KWADRAT ===");
            Console.WriteLine("Bok: " + bok);
            Console.WriteLine("Pole: " + Pole);
            Console.WriteLine("Obwod: " + Obwod);
        }
    }
}