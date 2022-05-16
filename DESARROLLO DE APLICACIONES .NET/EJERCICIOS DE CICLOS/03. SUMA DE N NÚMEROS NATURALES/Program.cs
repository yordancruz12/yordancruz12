// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio en Clase, Ciclos");
Console.WriteLine("Ciclo for");

//3. Escriba un programa para mostrar n términos de número natural y su suma.//
int n = int.Parse(Console.ReadLine());
int suma = 0;

for (int i = 1; i <= n; i++)
{
    suma = suma + i;
    Console.WriteLine(suma);
}
