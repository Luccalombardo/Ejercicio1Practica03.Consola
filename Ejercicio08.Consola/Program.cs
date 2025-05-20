


namespace Ejercicio08.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Ingrese la temperatura en grados Celsius: ");
            string? inputCelsius = Console.ReadLine();

            Console.WriteLine("Convertidor de Temperaturas");
            Console.WriteLine("Elija la conversión que desea hacer:");
            Console.WriteLine("1. Reaumur");
            Console.WriteLine("2. Fahrenheit");
            Console.WriteLine("3. Kelvin");
            Console.WriteLine("4. Rankine");
            Console.Write("Opción (1/2/3/4): ");
            string? inputOpcion = Console.ReadLine();

            if (double.TryParse(inputCelsius, out double celsius) && int.TryParse(inputOpcion, out int opcion))
            {
                if (ValidarMinimo(celsius))
                {
                    Console.WriteLine($"La conversion de {celsius} grado Celsius son {CalculoConversion(celsius, opcion)} de grado {QueES(opcion)}");
                    
                }
                else
                {
                    Console.WriteLine("La temperatura ingresada es menor al minimo existente");
                }
            }

            else
            {
                Console.WriteLine("Error: Alguno de los valores introducidos no son validos");
            }
        }
        
private static bool ValidarMinimo(double celsius)
        {
            return celsius > -273.15;
        }

        private static string QueES(int menuOpcion)
        {
            switch (menuOpcion)
            {
                case 1:
                    return "Reaumur";

                    break;
                case 2:
                    return "Fahrenheit";

                    break;
                case 3:
                    return "Kelvin";
                    break;
                case 4:
                    return "Rankine";

                    break;
                default:
                    return "";
                    break;
            }
        }

        private static double CalculoConversion(double celsius, int menuOpcion)
        {

            switch (menuOpcion)
            {
                case 1:
                    return 0.8 * celsius;

                    break;
                case 2:
                    return 1.8 * celsius + 32;

                    break;
                case 3:
                    return celsius + 273.15;
                    break;
                case 4:
                    return (celsius + 273.15) * 9 / 5;

                    break;
                default:
                    return 0 ;
                    break;
            }
        }
    }
}
