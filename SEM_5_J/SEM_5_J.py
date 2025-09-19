def EJER_1():
    edad = int(input("Ingrese la edad: "))

    print()
    if edad < 18: 
        print("No puede votar.")
        print("No puede ser candidato.")
    elif edad < 25:
        print("Puede votar.")
        print("No puede ser candidato.")
    else:
        print("Puede votar.")
        print("Puede ser candidato.")

def EJER_2():
    l1 = int(input("Ingrese lado 1: "))
    l2 = int(input("Ingrese lado 2: "))
    l3 = int(input("Ingrese lado 3: "))

    if l1 == l1 == l3:
        tp = "Equilátero"
    elif l1 == l2 or l1 == l3 or l2 == l3:
        tp = "Isósceles"
    else:
        tp = "Escaleno"
    print(f"\nTriángulo {tp}.")

EJER_2()