using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear un objeto de la clase Circulo con radio 5
        Circulo c = new Circulo(5);

        Console.WriteLine("=== CÍRCULO ===");
        Console.WriteLine("Área: " + c.CalcularArea());
        Console.WriteLine("Perímetro: " + c.CalcularPerimetro());

        // Crear un objeto de la clase Cuadrado con lado 4
        Cuadrado q = new Cuadrado(4);

        Console.WriteLine("\n=== CUADRADO ===");
        Console.WriteLine("Área: " + q.CalcularArea());
        Console.WriteLine("Perímetro: " + q.CalcularPerimetro());
    }
}
