// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ejercicio en Clase, Ciclos");
Console.WriteLine("Ciclo Do While");

//2. Escriba un programa para encontrar la suma de los primeros 20 números naturales. El total debe ser 210.//

int a = 1;
int total = 0;

do
{

    
    total = total + a;
    Console.WriteLine(total);
    a++;

}
while (a <= 20);

