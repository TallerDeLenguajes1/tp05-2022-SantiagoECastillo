using System;
int numero;

Console.WriteLine("Ingrese un numero (valor aboluto)");
numero = Convert.ToInt32(Console.ReadLine());
numero = valorAbsoluto(numero);
Console.WriteLine("El numero en valor absoluto es: " + numero);


int valorAbsoluto(int numero){
    if(numero < 0){
        numero = numero * (-1);
        return numero;
    }else{
        return numero;
    }
}

 