//Ejercicio 5. Crear un programa con un menú de opciones, que permita calcular las áreas de figuras geométricas: cuadrado, rectángulo, triángulo, círculo, rombo y trapecio.//
Console.WriteLine("elige entre cinco opciones para el cálculo del área de algunas figuras geométricas");
//Cargue de datos//
Console.WriteLine("Elija una figura geométrica: ");
Console.WriteLine("1. Cuadrado ");
Console.WriteLine("2. Rectángulo ");
Console.WriteLine("3. Triángulo ");
Console.WriteLine("4. Circulo ");
Console.WriteLine("5. Rombo ");
Console.WriteLine("6. Trapecio ");
int Tipo = int.Parse(Console.ReadLine());
if (Tipo == 1)
{
    Console.WriteLine("Cálculo del area del cuadrado");
    Console.WriteLine("Ingrese la medida de uno de sus lados");
    float Lado = float.Parse(Console.ReadLine());
    float Área = (Lado * Lado);
    Console.WriteLine("El area del cuadrado es: " + Área);
}
else if (Tipo == 2)
{
    Console.WriteLine("Cálculo del area del Rectangulo");
    Console.WriteLine("Ingrese la medida de la altura");
    float Altura = float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la medida del ancho");
    float Base1 = float.Parse(Console.ReadLine());
    float Área = (Altura * Base1);
    Console.WriteLine("El area del rectangulo es: " + Área);
}
else if (Tipo == 3)
{
    Console.WriteLine("Cálculo del area del Triangulo");
    Console.WriteLine("Ingrese la medida de la altura");
    float Altura = float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la medida de la Base");
    float Basea = float.Parse(Console.ReadLine());
    float Área = (Altura * Basea) / 2;
    Console.WriteLine("El area del rectangulo es: " + Área);
}
else if (Tipo == 4)
{
    Console.WriteLine("Cálculo del area del Circulo");
    Console.WriteLine("Ingrese el radio del circulo");
    float radio = float.Parse(Console.ReadLine());
    float pi = 3.1416F;
    float radio2 = radio * radio;
    float Área = (radio2 * pi) / 2;
    Console.WriteLine("El area del Circulo es: " + Área);
}
else if (Tipo == 5)
{
    Console.WriteLine("Cálculo del area del Rombo");
    Console.WriteLine("Ingrese la medida de la diagonal larga");
    float Diagonal1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese la medida de la diagonal corta");
    float Diagonal2 = float.Parse(Console.ReadLine());
    float Área1 = Diagonal1 * Diagonal2;
    float Área2 = Área1 / 2;
    Console.WriteLine("El area del Rombo es: " + Área2);
}
else if (Tipo == 6)
{
    Console.WriteLine("Calculacion del area del Trapecio");
    Console.WriteLine("Por favor ingrese la medida de la base mas larga");
    float Base1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Por favor ingrese la medida de la base mas corta");
    float Base2 = float.Parse(Console.ReadLine());
    Console.WriteLine("Por favor ingrese la medida de la altura");
    float Altura = float.Parse(Console.ReadLine());
    float Basetotal = Base1 + Base2;
    float Basealtura = Basetotal * Altura;
    float Área = Basealtura / 2;
    Console.WriteLine("el area del Trapecio es: " + Área);

}
