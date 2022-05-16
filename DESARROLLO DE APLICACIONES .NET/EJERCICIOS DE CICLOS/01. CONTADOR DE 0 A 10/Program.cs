// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio en Clase, Ciclos");
Console.WriteLine("Ciclos While");
//1. Escriba un programa para mostrar los primeros 10 números naturales.//

int i = 0;
while (i <= 10)
{
    Console.WriteLine(i);
    i++;
}

Console.WriteLine("Ciclo Do While");
//Contador de 0 a 10 con ciclo Do While//

int a = 0;
do
{
    Console.WriteLine(a);
    a++;
}
while (a < 11);

Console.WriteLine("Ciclo For");
//Contador de 0 a 10 con ciclo For//

for (int b = 0; b <= 10; b++)
{
    Console.WriteLine(b);
}
