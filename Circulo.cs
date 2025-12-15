// Esta clase representa un Círculo.
// Encapsula el dato primitivo 'radio' y proporciona métodos
// para calcular el área y el perímetro del círculo.

public class Circulo
{
    // Atributo privado para guardar el radio del círculo
    private double radio;

    // Constructor que recibe el radio como parámetro
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // CalcularArea es una función que devuelve un valor double.
    // Calcula el área de un círculo usando la fórmula: π * radio^2.
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // CalcularPerimetro devuelve un double.
    // Calcula la circunferencia usando la fórmula: 2 * π * radio.
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}
