# Figury Geometryczne

## Opis projektu

Aplikacja konsolowa napisana w języku C#.

Program umożliwia:

* obliczanie pola figur geometrycznych,
* obliczanie obwodu figur geometrycznych,
* dodawanie figur do listy,
* zapis danych do pliku,
* odczyt danych z pliku.

Obsługiwane figury:

* kwadrat,
* prostokąt,
* koło,
* trójkąt.

## Wykorzystane elementy języka C#

* klasy,
* dziedziczenie,
* metody wirtualne i override,
* ArrayList,
* operacje na plikach,
* instrukcje warunkowe,
* pętle.

## Bożena Czempas-Chowaniec

Projekt wykonany w ramach zajęć z Programowania Zorientowanego Obiektowo.
Treść zadania

Temat: Aplikacja Figury Geometryczne wykorzystująca dziedziczenie 

 

 

Napisać aplikację języku C#, która umożliwia obliczanie pola i obwodu figur płaskich:
prostokąt, kwadrat, trójkąt, koło. 
Zaimplementować klasę FiguraGeometryczna, która będzie klasą bazową i będzie posiadała
pola Pole i Obwód do przechowywania wyliczanych wartości. Odpowiednie metody powinny być w klasach
do obsługi poszczególnych figur geometrycznych i powinny zwracać wartości rzeczywiste reprezentujące
odpowiednie parametry figury. Uwzględnić następujące figury (prostokąt, kwadrat, koło, trójkąt). 
Napisać klasy poszczególnych figur geometrycznych, które będą dziedziczyły po klasie FiguraGeometryczna. 

Klasy powinny zawierać metody: 
- pobierzDane(); 
- WyświetlDane(); 
- ObliczObwod(); 
- ObliczPole(); 
W głównej funkcji aplikacji napisać kod, który pozwoli na przetestowanie poprawności obliczania pól i obwodów
dla poszczególnych figur. Użytkownik powinien mieć możliwość wyboru figury, wprowadzenia parametrów oraz wyświetlenia wyników.  
Rozszerzyć program w taki sposób, aby obiekty opisujące figury były zapisywane na liście obiektów.
Użyć klasę ArrayList do obsługi listy. 

Dodać możliwość wybrania przez użytkownika dwóch opcji – zapisz do pliku dane o figurach,
odczytaj z pliku dane o figurach. Po wybraniu zapisu do pliku program powinien zapisać stan obiektów na liście do pliku.
Wybranie opcji odczytu z pliku powinno odczytać dane z pliku i umieścić na liście. 
