namespace Ejercicio05.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Analizar un Número");

            Console.Write("Ingrese el número a número a analizar:");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("1 - Ver si es par o impar");
                Console.WriteLine("2 - Ver si es positivo, negativo o neutro");
                Console.WriteLine("3 - Ver si es múltiplo de 3, 5 o ambos");
                Console.Write("Ingrese la selección:");
                string? inputOpcion = Console.ReadLine();
                switch (inputOpcion)
                {
                    case "1":
                        if (EsPar(numero))
                        {
                            Console.WriteLine($"El número {numero} es par");
                        }
                        else
                        {
                            Console.WriteLine($"El número {numero} es impar");
                        }
                        break;
                    case "2":
                        Console.WriteLine(CondicionDelNumero(numero));
                        break;
                    case "3":
                        if (EsMultiploDe(numero, 3) && EsMultiploDe(numero, 5))
                        {
                            Console.WriteLine($"{numero} es múltiplo de 3 y 5");
                        }
                        else if (EsMultiploDe(numero, 3))
                        {
                            Console.WriteLine($"{numero} es multiplo de 3 y no de 5");
                        }
                        else if (EsMultiploDe(numero, 5))
                        {
                            Console.WriteLine($"{numero} es multiplo de 5 y no de 3");

                        }
                        else
                        {
                            Console.WriteLine("No es multiplo de ninguno");
                        }
                        break;
                    default:
                        Console.WriteLine("Selección fuera de rango!!!");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Número mal ingresado");
            }
        }
        private static bool EsMultiploDe(int numero, int divisor)
        {
            return numero % divisor == 0;
        }
        private static string CondicionDelNumero(int numero)
        {
            if (numero == 0)
            {
                return "Es neutro";
            }
            else if (numero < 0)
            {
                return $"{numero} es negativo";
            }
            else
            {
                return $"{numero} es positivo";
            }
        }

        static bool EsPar(int nro)
        {
            return nro % 2 == 0;
        }
    }
}
