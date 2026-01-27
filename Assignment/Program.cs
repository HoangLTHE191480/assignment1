using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhan phim bat ky de bat dau...");
        Console.ReadKey();
        Console.WriteLine();

        Console.WriteLine("Nhan 1 de hien 'xin chào'");
        Console.WriteLine("Nhan 2 de hien 'tạm biệt'");
        Console.Write("Lua chon cua ban: ");

        char choice = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (choice == '1')
        {
            Console.WriteLine("xin chào");
        }
        else if (choice == '2')
        {
            Console.WriteLine("tạm biệt");
        }
        else
        {
            Console.WriteLine("Lua chon khong hop le");
        }

        Console.ReadKey();
    }
}
