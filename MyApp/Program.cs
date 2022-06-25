using System;
double numero;
int opcion = 0;
String? salir = "s";

while(salir == "s"){
    opcion = menu();

    switch (opcion)
    {
        case 1:
            Console.WriteLine("---Valor absoluto---");
            Console.WriteLine("Ingrese el numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El numero en valor absoluto es: " + Math.Abs(numero));
            break;
        case 2:
            Console.WriteLine("---Cuadrado---");
            Console.WriteLine("Ingrese el numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El cuadrado del numero es: " + Math.Pow(numero,2));
            break;
        case 3:
            Console.WriteLine("---Raiz Cuadrada---");
            Console.WriteLine("Ingrese el numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La raiz cuadrada del numero es: " + Math.Sqrt(Math.Abs(numero)));//hago el numero positivo para la raiz
            break;
        case 4:
            Console.WriteLine("---Coseno---");
            Console.WriteLine("Ingrese el numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El coseno del numero es: " + Math.Cos(numero));
            break;
        case 5:
            Console.WriteLine("---Seno---");
            Console.WriteLine("Ingrese el numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El seno del numero es: " + Math.Sin(numero));
            break;
        case 6:
            Console.WriteLine("---Parte entera---");
            Console.WriteLine("Ingrese el numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La parte entera del numero es: " + Math.Truncate(numero));
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }

    Console.WriteLine("Desea realizar otra operacion? s(si)/n(no): ");
    salir = Convert.ToString(Console.ReadLine());
}

int menu(){
    int opcion;
    Console.WriteLine("\n------MENU------");
    Console.WriteLine("1- Valor absoluto");
    Console.WriteLine("2- Cuadrado");
    Console.WriteLine("3- Raiz cuadrada");
    Console.WriteLine("4- Seno");
    Console.WriteLine("5- Coseno");
    Console.WriteLine("6- Parte entera");
    Console.WriteLine("Ingrese la opcion: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    return opcion;
}






 