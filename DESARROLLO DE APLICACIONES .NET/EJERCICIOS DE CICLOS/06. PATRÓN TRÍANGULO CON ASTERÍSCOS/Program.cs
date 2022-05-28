// See https://aka.ms/new-console-template for more information
Console.WriteLine("Patrón Triángulo con asteríscos");
//6.Escriba un programa para mostrar el patrón como triángulo con asteriscos. El patrón es:

//*
//**
//***
//****
//*****
//****
//***
//**
//*

Console.WriteLine("Dibujo del triángulo con un patrón de asteríscos");
int a = 9;
while (a <= 10 && a >= 1)
{
    Console.WriteLine("\n");
    Console.WriteLine("*");
    a--;
    while (a <= 9 && a >= 3)
    {
        Console.WriteLine("\n");
        Console.WriteLine("**");
        a--;
        while (a <= 8 && a >= 4)
        {
            Console.WriteLine("\n");
            Console.WriteLine("*");
            a--;
            while (a <= 7 && a >= 5)
            {
                Console.WriteLine("\n");
                Console.WriteLine("**");
                a--;
                while (a <
                    
                    
                    7 && a > 5)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("***");
                    a--;
                }
            }
        }
    }
}
