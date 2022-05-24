using System;

int multiplicador = 1, resto;
int numeroInvertido = 0;
Console.WriteLine("Escriba el numero (POSTIVO) a invertir: ");
int numero = int.Parse(Console.ReadLine());
if(numero > 0){
    while(numero > 0){
        resto = numero % 10;
        if(multiplicador == 1){
            numeroInvertido = resto;
            multiplicador = 10; 
        }else{
            numeroInvertido = (numeroInvertido * multiplicador) + resto;
        }
        numero = numero / 10;
    }
    Console.WriteLine("El numero invertido es: " + numeroInvertido);
}else{
    Console.WriteLine("ERROR, el numero no es positivo");
}