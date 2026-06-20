using System;

namespace FiguryGeometryczne
{
    class Prostokat : FiguraGeometryczna
    {
        // Długości boków prostokąta
        public double bokA;
        public double bokB;

        // Pobranie danych od użytkownika
        public override void PobierzDane()
        {
            Console.Write("Podaj bok A: ");
            bokA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj bok B: ");
            bokB = Convert.ToDouble(Console.ReadLine());
        }

        // Obliczenie pola
        public override double ObliczPole()
        {
            Pole = bokA * bokB;
            return Pole;
        }

        // Obliczenie obwodu
        public override double ObliczObwod()
        {
            Obwod = 2 * bokA + 2 * bokB;
            return Obwod;
        }

        // Wyświetlenie danych
        public override void WyswietlDane()
        {
            Console.WriteLine("\n=== PROSTOKAT ===");
            Console.WriteLine("Bok A: " + bokA);
            Console.WriteLine("Bok B: " + bokB);
            Console.WriteLine("Pole: " + Pole);
            Console.WriteLine("Obwod: " + Obwod);
        }
    }
}