namespace Ejercicio03B.Consola
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
                int mayor = int.Max(numero1, numero2);
                int menor = int.Min(numero1, numero2);
                if (mayor == menor)
                {
                    Console.WriteLine("Ambos números son iguales!!!");

                }
                else
                {
                    Console.WriteLine($"{mayor} es mayor que  {menor}");

                }
            }
            else
            {
                Console.WriteLine("Alguno de los ingresos no son válidos!!!");
            }
        }
    }
}
