
namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingresadas las coordenadas de un punto en el plano, informar en qué cuadrante se encuentra el mismo");
                Console.Write("Ingrese el eje x del punto: ");
                int X1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el eje Y del punto: ");
                int Y1 = int.Parse(Console.ReadLine());

                Console.WriteLine($"El punto ({X1},{Y1}) está {SaberCuadrante(X1, Y1)}");
            }
            catch (FormatException ex)
            {

                Console.WriteLine("ERROR: El formato ingresado es invalido"); ;
            }
            catch (Exception ex)
            {

                Console.WriteLine("ERROR: Excepcion no manejada"); ;
            }


        }

        private static string SaberCuadrante(int x1, int y1)
        {
            if (x1 == 0 || y1 == 0)
            {
                return ($"sobre un eje y no pertenece a ningún cuadrante.");
            }

            else if (x1 > 0 && y1 > 0)
            {
                return ("en el primer cuadrante");
            }
            else if (x1 < 0 && y1 > 0)
            {
                return ("en el segundo cuadrante");
            }
            else if (x1 < 0 && y1 < 0)
            {
                return ("en el tercer cuadrante");
            }
            else
            {
                return ("en el cuarto cuadrante");
            }
        }
    }
}
