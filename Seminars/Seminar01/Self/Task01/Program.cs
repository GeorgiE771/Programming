using System;

class Program
{
    static void Main()
    {
        string first_name = Console.ReadLine();
        string second_name = Console.ReadLine();
        string last_name = Console.ReadLine();

        Console.WriteLine($"Фамилия: {second_name}\nИмя: {first_name}\nОтчество: {last_name}");
    }
}