namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Saber si el número positivo o negativo y si el mismo es par o impar");

                Console.Write("Ingrese un numero: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero >= 0)
                {
                    Console.WriteLine($"El numero {numero} es positivo");
                }
                else
                {
                    Console.WriteLine($"El numero {numero} es negativo");
                }

                Console.ReadKey();

                if (numero % 2 == 0)
                {
                    Console.WriteLine($"El numero {numero} es par");
                }
                else
                {
                    Console.WriteLine($"El numero {numero} es impar");
                }
                Console.ReadKey();
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
    }
}
