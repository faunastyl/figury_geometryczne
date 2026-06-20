//aplikacja języku C#, która umożliwia obliczanie
//pola i obwodu figur płaskich: prostokąt, kwadrat, trójkąt, koło.

using System;
using System.Collections;

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

        // Wyświetlenie danych figury
        public virtual void WyswietlDane()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList listaFigur = new ArrayList();

            int wybor;

            do
            {
                Console.WriteLine("\n=== FIGURY GEOMETRYCZNE ===");
                Console.WriteLine("1. Dodaj kwadrat");
                Console.WriteLine("2. Dodaj prostokat");
                Console.WriteLine("3. Dodaj kolo");
                Console.WriteLine("4. Dodaj trojkat");
                Console.WriteLine("5. Wyswietl wszystkie figury");
                Console.WriteLine("0. Wyjscie");

                Console.Write("Wybierz opcje: ");
                wybor = Convert.ToInt32(Console.ReadLine());

                FiguraGeometryczna nowaFigura = null;

                switch (wybor)
                {
                    case 1:
                        nowaFigura = new Kwadrat();
                        break;

                    case 2:
                        nowaFigura = new Prostokat();
                        break;

                    case 3:
                        nowaFigura = new Kolo();
                        break;

                    case 4:
                        nowaFigura = new Trojkat();
                        break;

                    case 5:

                        if (listaFigur.Count == 0)
                        {
                            Console.WriteLine("Brak figur na liscie.");
                        }
                        else
                        {
                            foreach (FiguraGeometryczna figura in listaFigur)
                            {
                                figura.WyswietlDane();
                            }
                        }

                        break;

                    case 0:
                        Console.WriteLine("Koniec programu.");
                        break;

                    default:
                        Console.WriteLine("Niepoprawny wybor.");
                        break;
                }

                if (wybor >= 1 && wybor <= 4)
                {
                    nowaFigura.PobierzDane();

                    nowaFigura.ObliczPole();
                    nowaFigura.ObliczObwod();

                    listaFigur.Add(nowaFigura);

                    Console.WriteLine("Figura zostala dodana do listy.");
                }

            } while (wybor != 0);
        }
    }
}