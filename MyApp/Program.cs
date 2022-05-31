using System;

int opcion = 0;
int numero1, numero2, resultado;
while(opcion == 0){

    Console.WriteLine("---------MENU-------");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("Elija una opcion: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    
    switch (opcion)
    {
        case 1:
            Console.WriteLine("SUMA");
            Console.WriteLine("Ingrese un numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            resultado = numero1 + numero2;
            Console.WriteLine("El resultado de la suma es: " + resultado);
            opcion = siguienteOperacion();
            break;

        case 2:
            Console.WriteLine("RESTA");
            Console.WriteLine("Ingrese un numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            resultado = numero1 - numero2;
            Console.WriteLine("El resultado de la resta es: " + resultado);
            opcion = siguienteOperacion();
            break;

        case 3:
            Console.WriteLine("MULTIPLICACION");
            Console.WriteLine("Ingrese un numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            resultado = numero1 * numero2;
            Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
            opcion = siguienteOperacion();
            break;

        case 4:
            Console.WriteLine("DIVISION");
            Console.WriteLine("Ingrese un numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            resultado = numero1 / numero2;
            Console.WriteLine("El resultado de la division es: " + resultado);
            opcion = siguienteOperacion();
            break;
        default:
            Console.WriteLine("La opcion elegida no es valida");
            break;
    }

    Console.WriteLine("Fin del programa");
}


int siguienteOperacion(){
    Console.WriteLine("Desea realizar otra operacion ? s/n");//suponiendo que se ingresa solo s(si) o n(no)
    var respuesta = Console.ReadLine();
    if(respuesta == "n"){
        return 1;
    }else{
        return 0;
    }

}