namespace Ejercicio07.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinar cercania entre dos puntos, y si se encuentran dentro de la circunferencia");

            Console.Write("Ingrese la coordenada X del primer punto: ");
            string? inputX1 = Console.ReadLine();
            Console.Write("Ingrese la coordenada Y del primer punto: ");
            string? inputY1 = Console.ReadLine();
            Console.Write("Ingrese la coordenada X del segundo punto: ");
            string? inputX2 = Console.ReadLine();
            Console.Write("Ingrese la coordenada Y del segundo punto: ");
            string? inputY2 = Console.ReadLine();

            if (double.TryParse(inputX1, out double x1) && double.TryParse(inputY1, out double y1) && double.TryParse(inputX2, out double x2) && double.TryParse(inputY2, out double y2))
            {
                double distancia1 = SaberDistancia(x1, y1);
                double distancia2 = SaberDistancia(x2, y2);

                Console.WriteLine($"La distancia del primer punto ({x1},{y1}) es de {distancia1}");
                Console.WriteLine($"La distancia del primer punto ({x2},{y2}) es de {distancia2}");

                Console.WriteLine($"Entre el primer punto ({x1},{y1}) y el segundo punto ({x2},{y2}), {CercaniaOrdenada(distancia1, distancia2)}");
                
                
                Console.Write("Introduzca la radio para saber si los puntos se encuentran dentro de la circunferencia: ");
                string? inputRadio = Console.ReadLine();
                if(double.TryParse(inputRadio, out double radio))
                {
                    Console.WriteLine(DentroCircunferencia(distancia1, distancia2, radio));
                }
                else
                {
                    Console.WriteLine("ERROR: El valor de algun punto no es valido");
                }


            }
            else
            {
                Console.WriteLine("ERROR: El valor de algun punto no es valido");
            }
        }
        private static string DentroCircunferencia(double distancia1, double distancia2, double radio)
        {
            if(distancia1 <= radio && distancia2 <= radio)
            {
                return "El primer Punto y el segundo Punto estan dentro de la circunferencia";
            }
            else if(distancia1 > radio && distancia2 > radio)
            {
                return "El primer Punto y el segundo Punto estan fuera de la circunferencia";
            }
            else
            {
                if (distancia1 <= radio && distancia2>radio)
                {
                    return ("El primer Punto está dentro de la circunferencia.");
                }
                else
                {
                   
                    return ("El segundo Punto está dentro de la circunferencia.");
                    
                }

                
            }


          
        }
        private static string CercaniaOrdenada(double distanciaA, double ditanciaB)
        {
            if (distanciaA < ditanciaB)
            {
               return "el primer punto es el que esta más cerca de la ordenada al origen";
            }
            else if (distanciaA > ditanciaB)
            {
                return "el segundo punto es el que esta más cerca de la ordenada al origen";
            }
            else
            {
                return "ambos estan a la misma distancia de la ordenada al origen";
            }
        }
      

        private static double SaberDistancia(double coordenadaX, double coordenadaY)
        {
            return Math.Sqrt(Math.Pow(coordenadaX, 2) + Math.Pow(coordenadaY, 2));
        }
    }
}
