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

def main():
    print("Wybierz opcję: 1-kalkulator, 2-konwerter, 3-srednia")
    option = input()  
    match option:
        case "1":
            calculator()
        case "2":
            print("converter")
        case "3":
            print("student gpa")

if __name__ == "__main__":
    main()
