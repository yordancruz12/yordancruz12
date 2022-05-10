//Ejercicio 3. Solicitar dos números al usuario y calcular cuál es el mayor y cuál el menor, e imprimir los resultados.//
Console.WriteLine("Ingresa dos números para determinar cual es mayor");
//Variables//
int numero1, numero2;
string cadena;
//Cargar números//
Console.WriteLine("Ingrese el primer número");
cadena = Console.ReadLine();
numero1 = int.Parse(cadena);
Console.WriteLine("Ingrese el segundo número");
cadena = Console.ReadLine();
numero2 = int.Parse(cadena);
//Condicionales//
if (numero1 == numero2)
{
    Console.WriteLine("Los números " + numero1 + " y " + numero2 + " son iguales");
}
else if (numero1 > numero2)
{
    Console.WriteLine("El primer número es mayor ");
}
else
{
    Console.WriteLine("El segundo número es mayor ");
}
{
    Console.Read();
}

