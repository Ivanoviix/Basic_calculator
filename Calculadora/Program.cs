
using System;
using System.Text;  // Necesario para Encoding

class Program
{
    static void Main()
    {
        Prueba.ManejarDiccionario();
        Prueba.PrintWelcomeMessage();
        Console.Write("Escribe tu nombre: ");
        string nombre = Console.ReadLine();

        if (string.IsNullOrEmpty(nombre))
        {
            Console.WriteLine("No has escrito un nombre");
        }
        else
        {
            if (Prueba.AreEqualIgnoreCase(nombre, "Iván"))
            {
                Console.WriteLine("¡Hola, Iván!");
            }
            else
            {
                Console.WriteLine($"¡Hola, {nombre}!");
            }
        }

/* 
        // Crear una nueva instancia de la clase Calculator
        Calculadora calc = new Calculadora();

        // Realizar algunas operaciones matemáticas
        double sum = calc.Add(5, 3);
        double difference = calc.Subtract(10, 4);
        double product = calc.Multiply(4, 6);
        double quotient = calc.Divide(20, 4);

        // Mostrar los resultados
        Console.WriteLine($"Suma: {sum}");
        Console.WriteLine($"Resta: {difference}");
        Console.WriteLine($"Producto: {product}");
        Console.WriteLine($"Cociente: {quotient}");

        // Almacenar un valor en la memoria
        calc.StoreInMemory(50);

        // Obtener el valor de la memoria
        double memoryValue = calc.RecallMemory();
        Console.WriteLine($"Valor en memoria: {memoryValue}");
 */
        // Crear una nueva instancia de la clase CalculadoraConDescuento
        CalculadoraConDescuento calc = new CalculadoraConDescuento();

        // Realizar algunas operaciones matemáticas
        double sum = calc.Add(5, 3);
        double difference = calc.Subtract(10, 4);
        double product = calc.Multiply(4, 6);
        double quotient = calc.Divide(20, 4);

        // Mostrar los resultados
        Console.WriteLine($"Suma: {sum}");
        Console.WriteLine($"Resta: {difference}");
        Console.WriteLine($"Producto: {product}");
        Console.WriteLine($"Cociente: {quotient}");

        // Aplicar un descuento del 10% a un valor
        double originalPrice = 100;
        double discountedPrice = calc.AplicarDescuento(originalPrice);
        Console.WriteLine($"Precio original: {originalPrice}");
        Console.WriteLine($"Precio con descuento: {discountedPrice}");

        // Almacenar un valor en la memoria
        calc.StoreInMemory(50);

        // Obtener el valor de la memoria
        double memoryValue = calc.RecallMemory();
        Console.WriteLine($"Valor en memoria: {memoryValue}");
    }
}