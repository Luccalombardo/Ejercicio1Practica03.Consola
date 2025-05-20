


namespace Ejercicio12.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresado la medida de 3 lados verifique si las mismas forman un triángulo, y luego informe de qué tipo de triángulo se trata.");
            Console.Write("Ingrese el valor del primer lado: ");
            string? inputLadoA = Console.ReadLine();
            Console.Write("Ingrese el valor del segundo lado: ");
            string? inputLadoB = Console.ReadLine();
            Console.Write("Ingrese el valor del segundo lado: ");
            string? inputLadoC = Console.ReadLine();

            if (double.TryParse(inputLadoA, out double ladoA) && double.TryParse(inputLadoB, out double ladoB) && double.TryParse(inputLadoC, out double ladoC) && ValidarPositivo(ladoA,ladoB,ladoC))
            {
                if (VerificarTriangulo(ladoA, ladoB, ladoC))
                {
                    
                    Console.WriteLine($"La figura se trata de un triangulo {TipoDeTriangulo(ladoA,ladoB,ladoC)} ");
                }
                else
                {
                    Console.WriteLine("Los valores ingresados no corresponden a ningun triangulo");
                }
            }
            else
            {
                Console.WriteLine("El valor ingresado no es válido");
            }

        }

        private static string TipoDeTriangulo(double lado1, double lado2, double lado3)
        {
            double ladoMayor = CualEsLadoMayor(lado1, lado2, lado3);
            double cateto1, cateto2;

            if (lado1 == ladoMayor)
            {
                 cateto1 = lado2;
                 cateto2 = lado3;
            }
            else if (lado2 == ladoMayor)
            {
                 cateto1 = lado1;
                 cateto2 = lado3;
            }
            else
            {
                 cateto1 = lado1;
                 cateto2 = lado2;
            }

            if ( Math.Pow(ladoMayor,2) == Math.Pow(cateto1,2) + Math.Pow(cateto2,2))
            {
                return "rectángulo";
            }
            else if (Math.Pow(ladoMayor, 2) > Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2))
            {
                return "obtusángulo";
            }
            else
            {
                return "acutángulo";
            }

            //b.Si A2 = B2 + C2 Se forma un triángulo rectángulo.
            //c.Si A2 > B2 + C2 Se forma un triángulo obtusángulo.
            //d.Si A2<B2 +C2 Se forma un triángulo acutángulo.

        }

        private static double CualEsLadoMayor(double lado1, double lado2, double lado3)
        {
            if(lado1>lado2 && lado1 > lado3)
            {
                return lado1;
            }
            else if (lado2> lado1 && lado2 > lado3)
            {
                return lado2;
            }
            else
            {
                return lado3;
            }
        }

        private static bool VerificarTriangulo(double ladoA, double ladoB, double ladoC)
        {
            return (ladoA + ladoB > ladoC) && (ladoA + ladoC > ladoB) && (ladoB + ladoC > ladoA);
        }
   

        private static bool ValidarPositivo(double ladoA, double ladoB, double ladoC)
        {
            return (ladoA>0) && (ladoB>0) && (ladoC>0);
        }

    }
}
