namespace Ejercicio11B.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificación de año bisiesto");
            Console.Write("Ingrese un año:");
            string? inputAnio = Console.ReadLine();
            if (int.TryParse(inputAnio, out int anio) && anio > 0)
            {
                bool esBisiesto = EsBisiesto(anio);

                if (esBisiesto)
                {
                    Console.WriteLine($"{anio} {ToBe(anio)} bisiesto");
                }
                else
                {
                    Console.WriteLine($"{anio} no {ToBe(anio)} bisiesto");
                }
            }
            else
            {
                Console.WriteLine("Año ingresado no válido o fuera de rango");
            }
            Console.ReadKey();
        }
        private static bool EsBisiesto(int anioIngresado)
        {
            return DateTime.IsLeapYear(anioIngresado);

        }
        private static string ToBe(int anioIngresado)
        {
            int anioActual = DateTime.Today.Year;
            if (anioIngresado < anioActual)
            {
                return "fue";

            }
            else if (anioIngresado > anioActual)
            {
                return "será";
            }
            else
            {
                return "es";
            }
        }
    }
}
