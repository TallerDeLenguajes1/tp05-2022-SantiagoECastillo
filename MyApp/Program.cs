using System;
double numero, numero2, resultado;
int opcion = 0;
String? salir = "s";


while(salir == "s"){
    opcion = menu();

    switch (opcion)
    {
        case 1:
            Console.WriteLine("SUMA");
            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            resultado = numero + numero2;
            Console.WriteLine("El resultado de la suma es: " + resultado);
            break;

        case 2:
            Console.WriteLine("RESTA");
            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            resultado = numero - numero2;
            Console.WriteLine("El resultado de la resta es: " + resultado);
            break;

        case 3:
            Console.WriteLine("MULTIPLICACION");
            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            resultado = numero * numero2;
            Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
            break;

        case 4:
            Console.WriteLine("DIVISION");
            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            resultado = numero / numero2;
            Console.WriteLine("El resultado de la division es: " + resultado);
            break;
        case 5:
            Console.WriteLine("---Valor absoluto---");
            Console.WriteLine("Ingrese el numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El numero en valor absoluto es: " + Math.Abs(numero));
            break;
        case 6:
            Console.WriteLine("---Cuadrado---");
            Console.WriteLine("Ingrese el numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El cuadrado del numero es: " + Math.Pow(numero,2));
            break;
        case 7:
            Console.WriteLine("---Raiz Cuadrada---");
            Console.WriteLine("Ingrese el numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La raiz cuadrada del numero es: " + Math.Sqrt(Math.Abs(numero)));//hago el numero positivo para la raiz
            break;
        case 8:
            Console.WriteLine("---Coseno---");
            Console.WriteLine("Ingrese el numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El coseno del numero es: " + Math.Cos(numero));
            break;
        case 9:
            Console.WriteLine("---Seno---");
            Console.WriteLine("Ingrese el numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El seno del numero es: " + Math.Sin(numero));
            break;
        case 10:
            Console.WriteLine("---Parte entera---");
            Console.WriteLine("Ingrese el numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("La parte entera del numero es: " + Math.Truncate(numero));
            break;
        case 11:
            Console.WriteLine("---Mayor entre---");
            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("el mayor entre ellos es: " + Math.Max(numero, numero2));
            break;
        case 12:
            Console.WriteLine("---Menor entre---");
            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("el menor entre ellos es: " + Math.Min(numero, numero2));
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }

    Console.WriteLine("Desea realizar otra operacion? s(si)/n(no): ");
    salir = Convert.ToString(Console.ReadLine());
}

Console.WriteLine("El programa finalizo");

int menu(){
    int opcion;
    Console.WriteLine("\n------MENU------");
    Console.WriteLine("1- Sumar");
    Console.WriteLine("2- Restar");
    Console.WriteLine("3- Multiplicar");
    Console.WriteLine("4- Dividir");
    Console.WriteLine("5- Valor absoluto");
    Console.WriteLine("6- Cuadrado");
    Console.WriteLine("7- Raiz cuadrada");
    Console.WriteLine("8- Seno");
    Console.WriteLine("9- Coseno");
    Console.WriteLine("10- Parte entera");
    Console.WriteLine("11- Mayor entre");
    Console.WriteLine("12- Menor entre");
    Console.WriteLine("Ingrese la opcion: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    return opcion;
}

