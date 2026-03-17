using System;

Console.WriteLine("Wprowadź liczby oddzielone spacją:");
string input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Uwaga: Musisz podać jakieś liczby.");
    return;
}