using System;
using System.Collections;
using System.IO;

namespace FiguryGeometryczne
{
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
                Console.WriteLine("6. Zapisz do pliku");
                Console.WriteLine("7. Odczytaj z pliku");
                Console.WriteLine("0. Wyjscie");

                Console.Write("Wybierz opcje: ");
                wybor = Convert.ToInt32(Console.ReadLine());

                switch (wybor)
                {
                    case 1:
                        Kwadrat k = new Kwadrat();
                        k.PobierzDane();
                        k.ObliczPole();
                        k.ObliczObwod();
                        listaFigur.Add(k);
                        Console.WriteLine("Dodano kwadrat.");
                        break;

                    case 2:
                        Prostokat p = new Prostokat();
                        p.PobierzDane();
                        p.ObliczPole();
                        p.ObliczObwod();
                        listaFigur.Add(p);
                        Console.WriteLine("Dodano prostokat.");
                        break;

                    case 3:
                        Kolo ko = new Kolo();
                        ko.PobierzDane();
                        ko.ObliczPole();
                        ko.ObliczObwod();
                        listaFigur.Add(ko);
                        Console.WriteLine("Dodano kolo.");
                        break;

                    case 4:
                        Trojkat t = new Trojkat();
                        t.PobierzDane();
                        t.ObliczPole();
                        t.ObliczObwod();
                        listaFigur.Add(t);
                        Console.WriteLine("Dodano trojkat.");
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

                    case 6:
                        ZapiszDoPliku(listaFigur);
                        break;

                    case 7:
                        OdczytajZPliku(listaFigur);
                        break;

                    case 0:
                        Console.WriteLine("Koniec programu.");
                        break;

                    default:
                        Console.WriteLine("Niepoprawny wybor.");
                        break;
                }

            } while (wybor != 0);
        }

        static void ZapiszDoPliku(ArrayList lista)
        {
            using (StreamWriter sw = new StreamWriter("figury.txt"))
            {
                foreach (FiguraGeometryczna f in lista)
                {
                    sw.WriteLine(f.GetType().Name);
                    sw.WriteLine(f.Pole);
                    sw.WriteLine(f.Obwod);
                }
            }

            Console.WriteLine("Zapisano do pliku.");
        }

        static void OdczytajZPliku(ArrayList lista)
        {
            if (!File.Exists("figury.txt"))
            {
                Console.WriteLine("Brak pliku.");
                return;
            }

            lista.Clear();

            string[] linie = File.ReadAllLines("figury.txt");

            for (int i = 0; i < linie.Length; i += 3)
            {
                string typ = linie[i];
                double pole = Convert.ToDouble(linie[i + 1]);
                double obwod = Convert.ToDouble(linie[i + 2]);

                FiguraGeometryczna f = null;

                switch (typ)
                {
                    case "Kwadrat":
                        f = new Kwadrat();
                        break;
                    case "Prostokat":
                        f = new Prostokat();
                        break;
                    case "Kolo":
                        f = new Kolo();
                        break;
                    case "Trojkat":
                        f = new Trojkat();
                        break;
                }

                if (f != null)
                {
                    f.Pole = pole;
                    f.Obwod = obwod;
                    lista.Add(f);
                }
            }

            Console.WriteLine("Odczytano dane z pliku.");
        }
    }
}