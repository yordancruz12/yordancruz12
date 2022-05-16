// See https://aka.ms/new-console-template for more information
//5. Escriba un programa para mostrar la tabla de multiplicar de un número entero dado.//
Console.WriteLine("Ingresar número de la tabla de multiplicar");
int n, i;
Console.WriteLine("Digite el valor de n: ");
    n = Convert.ToInt32(Console.ReadLine());

for (i = 0; i <= 100; i++)
{
    Console.WriteLine(" {0} * {1} = {2}", n, i, (n * i));
}
Console.ReadKey();

