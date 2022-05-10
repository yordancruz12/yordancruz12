//Ejercicio 4. Solicitar cinco (5) notas de 0.0 a 5.0 a un estudiante y calcular promedio. Mostrar como "Aprobó" si el promedio es mayor o igual a 3.0, o mostrar "No aprobó" si su nota es menor a 3.0.//
Console.WriteLine("Ingresa cinco notas y calcule el promedio");
//Variables//
decimal nota1, nota2, nota3, nota4, nota5;
//Cargue de datos//
Console.WriteLine("Ingrese la nota 1: ");
nota1 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota 2: ");
nota2 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota 3: ");
nota3 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota 4: ");
nota4 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la nota 5: ");
nota5 = decimal.Parse(Console.ReadLine());
double promedio = Convert.ToDouble(nota1 + nota2 + nota3 + nota4 + nota5) / 5;
promedio = Math.Round(promedio, 1);
if (promedio >= 3.0)
{
    Console.WriteLine("Su nota es: " + promedio + " Aprobó");
}
else
{
    Console.WriteLine("Su nota es: " + promedio + " No aprobó");
}
{ 
    Console.Read();
}