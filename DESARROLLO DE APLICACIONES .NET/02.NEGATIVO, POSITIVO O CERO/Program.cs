//Ejercicio 2. Solicitar número al usuario y determinar si es negativo, positivo o cero.//
Console.WriteLine("Ingresa un numero para determinar si es negativo, positivo o cero");
int numero = int.Parse(Console.ReadLine());
if (numero == 0)
{
    Console.WriteLine("El número " + numero + " es el número cero");
}
else if (numero > 0)
{
    Console.WriteLine("El número " + numero + " es un número positivo");
}
else
{
    Console.WriteLine("El número " + numero + " es un número negativo");
}