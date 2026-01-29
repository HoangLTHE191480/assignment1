using System;

Console.WriteLine("===== MENU =====");
Console.WriteLine("1. Xin chào");
Console.WriteLine("2. Tạm biệt");
Console.Write("Select option: ");

string choice = Console.ReadLine();

if (choice == "1")
{
    Console.WriteLine("xin chào");
}
else if (choice == "2")
{
    Console.WriteLine("tạm biệt");
}
else
{
    Console.WriteLine("Lựa chọn không hợp lệ");
}

Console.ReadKey();

