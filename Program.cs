using System;

// Definición de la clase Estudiante
class Estudiante
{
    // Atributos del estudiante
    public int Id;
    public string Nombres;
    public string Apellidos;
    public string Direccion;
    public string[] Telefonos; // Array para los números de teléfono

    // Método para mostrar los datos del estudiante
    public void MostrarDatos()
    {
        Console.WriteLine("\n--- DATOS DEL ESTUDIANTE ---");
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Nombres: " + Nombres);
        Console.WriteLine("Apellidos: " + Apellidos);
        Console.WriteLine("Dirección: " + Direccion);
        Console.WriteLine("Teléfonos:");

        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine("Teléfono " + (i + 1) + ": " + Telefonos[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creación del objeto estudiante
        Estudiante est = new Estudiante();

        Console.Write("Ingrese ID: ");
        est.Id = int.Parse(Console.ReadLine());

        Console.Write("Ingrese Nombres: ");
        est.Nombres = Console.ReadLine();

        Console.Write("Ingrese Apellidos: ");
        est.Apellidos = Console.ReadLine();

        Console.Write("Ingrese Dirección: ");
        est.Direccion = Console.ReadLine();

        // Inicialización del array de teléfonos
        est.Telefonos = new string[3];

        for (int i = 0; i < est.Telefonos.Length; i++)
        {
            Console.Write("Ingrese teléfono " + (i + 1) + ": ");
            est.Telefonos[i] = Console.ReadLine();
        }

        // Mostrar los datos ingresados
        est.MostrarDatos();

        Console.ReadKey();
    }
}
