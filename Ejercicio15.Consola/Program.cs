

namespace Ejercicio15.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertidor de Medidas");
            Console.WriteLine("Elija la conversión que desea hacer:");
            Console.WriteLine("1. Centímetros a Pulgadas");
            Console.WriteLine("2. Pulgadas a Centímetros");
            Console.Write("Opción (1/2): ");
            string? inputOpcion = Console.ReadLine();

            Console.Write("Ingrese la medida: ");
            string? inputMedida = Console.ReadLine();

            if (int.TryParse(inputOpcion, out int opcion) && double.TryParse(inputMedida, out double medida))
            {
                if (PositivoEs(medida))
                {
                    if (OpcionValida(opcion))
                    {
                        Console.WriteLine($"La medida convertida es {CalcularConversion(medida, opcion):F3} {ObtenerUnidad(opcion)}");
                    }
                    else
                    {
                        Console.WriteLine("La opcion elegida no es valida");
                    }
                   
                }
                else
                {
                    Console.WriteLine("La medida no puede ser negativa.");
                }
            }
            else
            {
                Console.WriteLine("Error: Alguno de los valores introducidos no son válidos.");
            }
        }

        private static bool OpcionValida(int opcion)
        {
            return opcion>0 && opcion<=2;
        }

        private static bool PositivoEs(double medida)
        {
            return medida > 0;
        }

        private static string ObtenerUnidad(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    return "pulgadas";
                case 2:
                    return "centímetros";
                default:
                    return "";
            }
        }

        private static double CalcularConversion(double medida, int opcion)
        {
            switch (opcion)
            {
                case 1:
                    return medida * 0.39370; // Centímetros a pulgadas
                case 2:
                    return medida / 0.39370; // Pulgadas a centímetros
                default:
                    return 0;
            }
        }
    }
}
