using System;

namespace FiguryGeometryczne
{
    class Kolo : FiguraGeometryczna
    {
        // Promień koła
        public double promien;

        // Pobranie danych od użytkownika
        public override void PobierzDane()
        {
            Console.Write("Podaj promien kola: ");
            promien = Convert.ToDouble(Console.ReadLine());
        }

        // Obliczenie pola
        public override double ObliczPole()
        {
            Pole = Math.PI * promien * promien;
            return Pole;
        }

        // Obliczenie obwodu
        public override double ObliczObwod()
        {
            Obwod = 2 * Math.PI * promien;
            return Obwod;
        }

        // Wyświetlenie danych
        public override void WyswietlDane()
        {
            Console.WriteLine("\n=== KOLO ===");
            Console.WriteLine("Promien: " + promien);
            Console.WriteLine("Pole: " + Math.Round(Pole, 2));
            Console.WriteLine("Obwod: " + Math.Round(Obwod, 2));
        }
    }
}