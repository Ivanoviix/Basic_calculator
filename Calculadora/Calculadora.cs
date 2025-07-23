public class Calculadora
{
    // Propiedades de la calculadora
    public double Memory { get; set; }  // Memoria para guardar un valor temporal

    // Constructor de la clase Calculadora
    public Calculadora(double initialMemory = 0)
    {
        Memory = initialMemory;  // Inicializa la memoria con el valor que se pase al crear el objeto
    }

    // Método para sumar dos números
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Método para restar dos números
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    // Método para multiplicar dos números
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    // Método para dividir dos números
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN;  // Devolver NaN en caso de error (división por cero)
        }
        return a / b;
    }

    // Método para almacenar un valor en la memoria
    public void StoreInMemory(double value)
    {
        Memory = value;
    }

    // Método para obtener el valor almacenado en la memoria
    public double RecallMemory()
    {
        return Memory;
    }
}

public class CalculadoraConDescuento : Calculadora
{
    // Constructor que llama al constructor base
    public CalculadoraConDescuento(double initialMemory = 0) : base(initialMemory)
    {
    }

    // Método para aplicar un descuento del 10%
    public double AplicarDescuento(double cantidad)
    {
        return cantidad * 0.9;  // Aplica un descuento del 10%
    }
}