// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("===== MENU =====");
Console.WriteLine("1. Xin chào");
Console.Write("select option: ");

string? choice = Console.ReadLine();

if (choice == "1")
{
    Console.WriteLine("xin chào");
}

Console.ReadKey();

