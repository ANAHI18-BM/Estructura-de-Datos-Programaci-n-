// La clase Circulo encapsula el radio y permite calcular área y perímetro
public class Circulo
{
    private double radio; // Atributo encapsulado

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Método para calcular el área del círculo
    // Fórmula: PI * r^2
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Método para calcular el perímetro del círculo
    // Fórmula: 2 * PI * r
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}
