namespace Ejercicio11.Consola
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
                if (EsBisiesto(anio))
                {
                    Console.WriteLine($"{anio} es bisiesto");
                }
                else
                {
                    Console.WriteLine($"{anio} no es bisiesto");
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
            return anioIngresado % 4 == 0
                && (anioIngresado % 100 != 0 || anioIngresado % 400 == 0);

        }
    }
}
