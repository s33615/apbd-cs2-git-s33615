using System;

Console.WriteLine("Wprowadź liczby oddzielone spacją:");
string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Błąd: Nie wprowadzono żadnych danych.");
    return;
}