// See https://aka.ms/new-console-template for more information
Console.WriteLine("Taller 2, Ciclos");
//4. Escribe un programa para leer 10 números del teclado y encontrar su suma y promedio.//

Console.Write("10 números a ingresar: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1, s = 0;
while (i <= n)
{
    Console.WriteLine(i);
    s = s + i;
    i = i + 1;

}
Console.WriteLine("La Sumatoria es {0}", s);
Console.WriteLine("El promedio es {0}", s / n);
Console.ReadKey();



