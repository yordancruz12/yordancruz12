//Ejercicio 1. Solicitar número al usuario y determinar si es par, impar o es cero.//
Console.WriteLine("Ingresa un numero para determinar si es par o impar");
//Variables//
int num1 = int.Parse(Console.ReadLine());
int num2 = 2;
int num3;
num3 = num1 % num2;
//Cargue de datos//
if (num3 == 0)
{
    Console.WriteLine("Es un número Par");
}
else
{
    Console.WriteLine("Es un número Impar");
}