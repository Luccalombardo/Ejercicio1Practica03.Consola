namespace Ejercicio09.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el peso en kilogramos: ");
            string? inputKg = Console.ReadLine();

            Console.WriteLine("Convertidor de Pesos");
            Console.WriteLine("Elija la conversión que desea hacer:");
            Console.WriteLine("1. Gramos (grs)");
            Console.WriteLine("2. Libras (lb)");
            Console.WriteLine("3. Onzas (oz)");
            Console.WriteLine("4. Stones (st)");
            Console.Write("Opción (1/2/3/4): ");
            string? inputOpcion = Console.ReadLine();

            if (double.TryParse(inputKg, out double kilogramos) && int.TryParse(inputOpcion, out int opcion))
            {
                if (ValidarMinimo(kilogramos))
                {
                    Console.WriteLine($"La conversión de {kilogramos} kg son {CalculoConversion(kilogramos, opcion):F3} {QueEs(opcion)}");
                }
                else
                {
                    Console.WriteLine("El peso ingresado debe ser mayor a cero.");
                }
            }
            else
            {
                Console.WriteLine("Error: Alguno de los valores introducidos no son válidos.");
            }
        }

        private static bool ValidarMinimo(double kg)
        {
            return kg > 0;
        }

        private static string QueEs(int menuOpcion)
        {
            switch (menuOpcion)
            {
                case 1:
                    return "gr";
                case 2:
                    return "lb";
                case 3:
                    return "oz";
                case 4:
                    return "st";
                default:
                    return "unidad desconocida";
            }
        }

        private static double CalculoConversion(double kg, int menuOpcion)
        {
            switch (menuOpcion)
            {
                case 1:
                    return kg * 1000;
                case 2:
                    return kg * 2.20462;
                case 3:
                    return kg * 35.274;
                case 4:
                    return kg / 6.35029;
                default:
                    return 0;
            }
        }
    }
}
