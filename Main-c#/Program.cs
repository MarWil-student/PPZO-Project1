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

    static void Converter()
    {
        Console.WriteLine("Wybierz kierunek konwersji: C-Celsjusz na Farenheit, F-Farenheit na Celsjusz");
        string option = Console.ReadLine().ToLower();

        if (option == "c")
        {
            Console.WriteLine("Podaj temperature");
            float temp = float.Parse(Console.ReadLine());

            Console.WriteLine($"{temp} stopni Celsjusza to {temp * 1.8 + 32} stopni Farenheita");
        }

        else if (option == "f")
        {
            Console.WriteLine("Podaj temperature");
            float temp = float.Parse(Console.ReadLine());

            Console.WriteLine($"{temp} stopni Farenheita to {(temp-32) / 1.8} stopni Celsjusza");
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
                Converter();
                break;  

            case "3": 
                break;

            default:
                Console.WriteLine("Zla opcja");
                break;

        }

    }
}