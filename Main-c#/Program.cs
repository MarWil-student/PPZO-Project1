using System;

class Program
{
    static void Calculator()
    {
        Console.WriteLine("Podaj pierwsza liczbe: ");
        float num1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Podaj druga liczbe: ");
        float num2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Wybierz operację (+, -, *, /): ");
        string option = Console.ReadLine();

        if (option == "+")
        {
            Console.WriteLine($"Wynik: {num1 + num2}");
        }
        else if (option == "-")
        {
            Console.WriteLine($"Wynik: {num1 - num2}");
        }
        else if (option == "*")
        {
            Console.WriteLine($"Wynik: {num1 * num2}");
        }
        else if (option == "/")
        {
            if (num2 == 0)
            {
                Console.WriteLine("Nie można dzielic przez 0");
            }
            else
            {
                Console.WriteLine($"Wynik: {num1 * num2}");
            }
        }

        else
        {
            Console.WriteLine("Zla opcja");
        }
    }
    static void Main()
    {
        Console.WriteLine("Wybierz opcje: 1-kalkulator, 2-konwerter, 3-srednia");
        string opt = Console.ReadLine();

        switch (opt)
        {
            case "1":
                Calculator();
                break;
            
            case "2":
                break;  

            case "3": 
                break;

            default:
                Console.WriteLine("Zla opcja");
                break;

        }

    }
}