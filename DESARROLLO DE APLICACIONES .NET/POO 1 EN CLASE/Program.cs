// See https://aka.ms/new-console-template for more information
//Instalar una clase o creando un ejemplar de la clase car//
Car MiCarro = new Car();
Console.WriteLine($"Marca: {MiCarro.marca}");
Console.WriteLine($"Color: {MiCarro.color}");
Console.WriteLine($"Placa: {MiCarro.placa}");
Console.WriteLine($"Encendido: {MiCarro.encender()}");


class Car
{
    public string marca = "Audi";
    public string color = "Blanco";
    int MaxVelocidad = 200;
    public string placa = "AZU986";
    int modelo = 2022;
    int cilindraje = 1800;


        public bool encender()
    {
        return true;
    }
}
