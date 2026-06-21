using System;

namespace FiguryGeometryczne
{
    class FiguraGeometryczna
    {
        // Pola przechowujące wyniki obliczeń
        public double Pole;
        public double Obwod;

        // Pobranie danych od użytkownika
        public virtual void PobierzDane()
        {
        }

        // Obliczenie pola
        public virtual double ObliczPole()
        {
            return 0;
        }

        // Obliczenie obwodu
        public virtual double ObliczObwod()
        {
            return 0;
        }

        // Wyświetlenie danych
        public virtual void WyswietlDane()
        {
        }
    }
}