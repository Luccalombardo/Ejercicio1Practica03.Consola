namespace Ejercicio10.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Promedio de Alumno");

            Console.Write("Ingrese la primer nota:");
            string? inputNota1 = Console.ReadLine();
            Console.Write("Ingrese la segunda nota:");
            string? inputNota2 = Console.ReadLine();
            Console.Write("Ingrese la tercer nota:");
            string? inputNota3 = Console.ReadLine();
            if (double.TryParse(inputNota1, out double nota1) &&
                double.TryParse(inputNota2, out double nota2) &&
                double.TryParse(inputNota3, out double nota3) &&
                (nota1 >= 0 && nota1 <= 10 && nota2 >= 0 && nota2 <= 10 && nota3 >= 0 && nota3 <= 10))
            {
                double promedio = CalcularPromedio(nota1, nota2, nota3);
                Console.WriteLine($"Su promedio es {promedio:F2}");
                Console.WriteLine($"{EvaluarPromedio(promedio)}");
            }
            else
            {
                Console.WriteLine("ERROR: algunas notas no son válidas");
            }

            Console.ReadKey();
        }
        private static double CalcularPromedio(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3;
        }
        private static string EvaluarPromedio(double promedio)
        {
            if (promedio >= 7)
            {
                return "Promociona";
            }
            else if (promedio >= 4 && promedio < 7)
            {
                return "Aprueba... Pero debe rendir final";
            }
            else
            {
                return "Recursa";
            }
        }
    }
}
