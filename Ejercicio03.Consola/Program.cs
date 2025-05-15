namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número:");
            string? inputNumero1 = Console.ReadLine();
            Console.Write("Ingrese otro número:");
            string? inputNumero2 = Console.ReadLine();
            if (int.TryParse(inputNumero1, out int numero1) &&
                int.TryParse(inputNumero2, out int numero2))
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine($"{numero1} es mayor que {numero2}");
                }
                else if (numero1 < numero2)
                {
                    Console.WriteLine($"{numero2} es mayor que  {numero1}");
                }
                else
                {
                    Console.WriteLine("Ambos números son iguales!!!");
                }
            }
            else
            {
                Console.WriteLine("Alguno de los ingresos no son válidos!!!");
            }
        }
    }
}
