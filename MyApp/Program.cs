using System;
double numero;


Console.WriteLine("Ingrese un numero");
numero = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("El numero en valor absoluto es: " + Math.Abs(numero));
Console.WriteLine("El cuadrado del numero es: " + Math.Pow(numero,2));
Console.WriteLine("La raiz cuadrada del numero es: " + Math.Sqrt(Math.Abs(numero)));//hago el numero positivo para la raiz
Console.WriteLine("El coseno del numero es: " + Math.Cos(numero));
Console.WriteLine("El seno del numero es: " + Math.Sin(numero));
Console.WriteLine("La parte entera del numero es: " + Math.Truncate(numero));








 