namespace Ejercicio13.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertidor de Temperaturas");
            Console.WriteLine("Elija la conversión que desea hacer:");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.Write("Opción (1/2): ");
            string? inputOpcion = Console.ReadLine();

            Console.Write("Ingrese la temperatura: ");
            string? inputTemp = Console.ReadLine();

            if (int.TryParse(inputOpcion, out int opcion) && double.TryParse(inputTemp, out double temperatura))
            {
                if (ValidarMinimo(temperatura, opcion))
                {
                    double resultado = CalcularConversion(temperatura, opcion);
                    string escalaDestino = opcion == 1 ? "Fahrenheit" : "Celsius";
                    Console.WriteLine($"La temperatura convertida es {resultado:F2} grados {escalaDestino}.");
                }
                else
                {
                    Console.WriteLine("La temperatura ingresada es menor al mínimo absoluto permitido.");
                }
            }
            else
            {
                Console.WriteLine("Error: Alguno de los valores introducidos no son válidos.");
            }
        }

        private static bool ValidarMinimo(double temperatura, int opcion)
        {
            // Opción 1: Celsius a Fahrenheit, no menor a -273.15°C
            // Opción 2: Fahrenheit a Celsius, no menor a -459.67°F
            if (opcion == 1)
                return temperatura >= -273.15;
            else if (opcion == 2)
                return temperatura >= -459.67;
            else
                return false;
        }

        private static double CalcularConversion(double temperatura, int opcion)
        {
            switch (opcion)
            {
                case 1:
                    return 1.8 * temperatura + 32; // Celsius a Fahrenheit
                case 2:
                    return (temperatura - 32) * 5 / 9; // Fahrenheit a Celsius
                default:
                    return 0;
            }
        }
    }
}
