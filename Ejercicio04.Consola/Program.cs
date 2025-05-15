
namespace Ejercicio04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar 2 números positivos, e informar si el segundo es múltiplo del primero.");
            Console.Write("Ingresa el primer numero:");
            string inputNro1 = Console.ReadLine();
            Console.Write("Ingresa el segundo numero:");
            string inputNro2 = Console.ReadLine();

            if (double.TryParse(inputNro1, out double numero1) && double.TryParse(inputNro2, out double numero2))
            {

                if (EsPositivo(numero1) && EsPositivo(numero2))
                {
                    if (SonMultiplos(numero1, numero2))
                    {
                        Console.WriteLine($"{numero2} es multiplo de {numero1}");

                    }
                    else
                    {
                        Console.WriteLine($"{numero2} no es multiplo de {numero1}");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Todos los numeros tienen que ser positivos");
                }

            }
            else
            {
                Console.WriteLine("ERROR:Algun dato ingresado no es valido");
            }
            Console.ReadKey();

        }

        private static bool EsPositivo(double numero1)
        {
            return numero1 > 0;
        }

        private static bool SonMultiplos(double nro1, double nro2)
        {
            return nro2 % nro1 == 0;
        }
    }
}
