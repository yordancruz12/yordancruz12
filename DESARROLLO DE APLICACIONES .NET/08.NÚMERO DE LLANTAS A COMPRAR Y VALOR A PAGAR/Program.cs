//Ejercicio 8. Leer el número de llantas de una compra y mostrar el valor que debe pagarse. El almacén las vende con la siguiente política:
//Si se compran menos de 5 llantas, el precio unitario es $240000.
//Si se compran 6 o 7, el precio unitario es $221000, y si se compran más de 7 llantas, el precio unitario es $180000.//
Console.WriteLine("Ingresa el número de llantas y muestra el calor a pagar");
//Variables//
float Númerodellantas = float.Parse(Console.ReadLine());
//Cargar datos//
if (Númerodellantas < 5)
{
    Console.WriteLine("El precio unitario es de $240000");
}
else if (Númerodellantas >= 6 && Númerodellantas <= 7)
{
    Console.WriteLine("El precio unitario es $221000");
}
else if (Númerodellantas > 7)
{
    Console.WriteLine("El precio unitario es $180000");
}
