//Ejercicio 7. Programa que permita a un usuario tomar una decisión del tipo de pago a usar.
//Si la cuenta es menor a $150000 pago en efectivo.
//Si no, si es de $150000 hasta $300000 pago con el celular (dinero electrónico).
//Si es mayor a $300000 hasta $600000, pago con la tarjeta de débito. Caso contrario, pago con la tarjeta de crédito.//
Console.WriteLine("Ingresa el valor de la cuenta");
//Variables//
int valor = int.Parse(Console.ReadLine());
//Cargar datos//
if (valor < 150000)
{
    Console.WriteLine("El tipo de pago a usar es con dinero en efectivo");
}
else if (valor >= 150000 && valor <= 300000)
{
    Console.WriteLine("El tipo de pago a usar es con el celular");
}
else if (valor > 300000 && valor <= 600000)
{
    Console.WriteLine("El tipo de pago a usar es con tarjeta débito");
}
else
{
    Console.WriteLine("El tipo de pago a usar es con tarjeta de crédito");
}

