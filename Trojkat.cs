using System;

namespace FiguryGeometryczne
{
    class Trojkat : FiguraGeometryczna
    {
        // Długości boków trójkąta
        public double bokA;
        public double bokB;
        public double bokC;

        // Pobranie danych od użytkownika
        public override void PobierzDane()
        {
            Console.Write("Podaj bok A: ");
            bokA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj bok B: ");
            bokB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj bok C: ");
            bokC = Convert.ToDouble(Console.ReadLine());
        }

        // Obliczenie pola
        public override double ObliczPole()
        {
            double p = (bokA + bokB + bokC) / 2;

            Pole = Math.Sqrt(p * (p - bokA) * (p - bokB) * (p - bokC));

            return Pole;
        }

        // Obliczenie obwodu
        public override double ObliczObwod()
        {
            Obwod = bokA + bokB + bokC;
            return Obwod;
        }

        // Wyświetlenie danych
        public override void WyswietlDane()
        {
            Console.WriteLine("\n=== TROJKAT ===");
            Console.WriteLine("Bok A: " + bokA);
            Console.WriteLine("Bok B: " + bokB);
            Console.WriteLine("Bok C: " + bokC);
            Console.WriteLine("Pole: " + Math.Round(Pole, 2));
            Console.WriteLine("Obwod: " + Math.Round(Obwod, 2));
        }
    }
}