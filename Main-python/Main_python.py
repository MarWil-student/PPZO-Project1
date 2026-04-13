def calculator():
    num1 = float(input("Podaj pierwsza liczbe"))
    num2 = float(input("Podaj druga liczbe"))
    option = input("Wybierz operację (+, -, *, /): ")
    if option == "+":
        print(f"Wynik: {num1 + num2}")        
    elif option == "-":
        print(f"Wynik: {num1 - num2}")            
    elif option == "*":
        print(f"Wynik: {num1 * num2}")         
    elif option == "/":
            if num2 == 0:
                print("Nie można dzielić przez 0")
            else:
                print(f"Wynik: {num1 / num2}")
    else:
        print("Zla opcja")

def converter():
    print("Wybierz kierunek konwersji: C-Celsjusz na Fahrenheit, F-Fahrenheit na Celsjusz")
    option = input().lower()
    if option == "c":
        temp = float(input("Podaj temperaturę: "))
        print(f"{temp} stopni Celsjusza to {temp * 1.8 + 32} stopni Fahrenheita")
    elif option == "f":
        temp = float(input("Podaj temperaturę: "))
        print(f"{temp} stopni Fahrenheita to {(temp - 32) / 1.8} stopni Celsjusza")
    else:
        print("Zła opcja")

def student_gpa():
        count = int(input("Podaj liczbe ocen: "))
        suma = 0
        if count > 0:
            for i in range(count):
                suma += int(input(f"Podaj ocene: "))           
            print(f"Srednia: {suma/count}")
            if (suma/count) < 3.0:
                print("Uczen nie zdal")
            else:
                print("Uczen zdal")
        else:
            print("Brak ocen")

def main():
    print("Wybierz opcję: 1-kalkulator, 2-konwerter, 3-srednia")
    option = input()  
    match option:
        case "1":
            calculator()
        case "2":
            converter()
        case "3":
            student_gpa()

if __name__ == "__main__":
    main()
