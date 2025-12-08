// La clase Cuadrado encapsula la longitud del lado y calcula área y perímetro
public class Cuadrado
{
    private double lado; // Atributo encapsulado

    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    // Método para calcular área: lado * lado
    public double CalcularArea()
    {
        return lado * lado;
    }

    // Método para calcular perímetro: 4 * lado
    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}
