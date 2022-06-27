string? cadena, palabraBuscar, cadena2;
/*
Console.WriteLine("Ingrese una linea de texto: ");
cadena = Console.ReadLine();


//Obtener longitud de cadena
Console.WriteLine("El tamaño de la cadena ingresada es: " + cadena.Length); 

//Concatenar cadena
Console.WriteLine("Ingrese una segunda cadena para concatenar: ");
cadena2 = Console.ReadLine();
Console.WriteLine(cadena +" " + cadena2);
Console.WriteLine($"{cadena} {cadena2}");
Console.WriteLine(string.Concat(cadena, cadena2));



//Extraer un subcadena

//Uso de foreach
Console.WriteLine("cadena caractea a caracter(foreach)");
foreach(char caracter in cadena){
    Console.WriteLine(caracter);
}


//Uso de split
string[] cadenaSearada = cadena.Split(' ');
Console.WriteLine("Cadena separada por espacios: ");
foreach(string palabra in cadenaSearada){
    Console.WriteLine(palabra);
}

//Buscar una palabra o subcadena dentro de la cadena ingresada
Console.WriteLine("Ingrese la palarba a busca en la cadena: ");
palabraBuscar = Console.ReadLine();
if(cadena.Contains(palabraBuscar)){
    Console.WriteLine("la palabra '" + palabraBuscar + "' Si esta contenida en la cadena");
}else{
    Console.WriteLine("La palabra no esta contenida");
}

//cadena a MAYUSCULAS
Console.WriteLine("cadena en Mayusculas: " + cadena.ToUpper());

//cadena a minusculas
Console.WriteLine("cadena en Minuscula: " + cadena.ToLower());


//Comaprar cadena
Console.WriteLine("\nComparando cadenas");
Console.WriteLine("Ingrese una segunda cadena para comparar");
string cadenaComparada = Console.ReadLine();
if(cadena.CompareTo(cadenaComparada) == 0){
    Console.WriteLine("las cadenas son iguales");
}else{
    Console.WriteLine("las cadenas no son iguales");
}
*/

//a modo de simplificar, solo realizare la suma
Console.WriteLine("\n ---Calculadora----");
double numero1, numero2, resultado;
Console.WriteLine("Ingrese un numero: ");
numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese otro numero: ");
numero2 = Convert.ToDouble(Console.ReadLine());
resultado = numero1 + numero2;
Console.WriteLine($"la suma de {numero1} y de {numero2} es: {resultado} ");
