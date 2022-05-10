//Ejercicio 3. Solicitar tres números al usuario e imprimirlos en orden descendente (de mayor a menor).//
Console.WriteLine("Ingresa tres números para ordenarlos de mayor a menor");
//Variables//
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int Mayor;
int Menor;
int Intermedio;

if (a > b && b > c)
{
    Mayor = a;
}
else if (b > a && b > c)
{
    Mayor = b;
}
else
{
    Mayor = c;
}
if (a < b && b < c)
{
    Menor = a;
}
else if (b < a && b < c)
{
    Menor = b;
}
else
{
    Menor = c;
}
if (a > Menor && a < Mayor)
{
    Intermedio = a;
}
else if (b > Menor && b < Mayor)
{
    Intermedio = b;
}
else
{
    Intermedio = c;
}
{
    Console.WriteLine("El orden de los números es " + Mayor + "-" + Intermedio + "-" + Menor);
    }
