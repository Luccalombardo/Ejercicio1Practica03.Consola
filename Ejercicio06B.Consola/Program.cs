namespace Ejercicio06B.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Días de la semana");
            Console.Write("Ingrese un número de día de la semana [1-7]:");
            if (int.TryParse(Console.ReadLine(), out int diaNumero)
                && (diaNumero >= 1 && diaNumero <= 7))
            {
                string nombreDia = NombreDelDia(diaNumero);
                Console.WriteLine($"El día {nombreDia} {TipoDeDia(diaNumero)}");

            }
            else
            {
                Console.WriteLine("Número de dia no válido o fuera de rango!!!");

            }
            Console.ReadKey();
        }
        private static string TipoDeDia(int diaNumero)
        {
            return diaNumero >= 1 && diaNumero <= 5
                ? "es día hábil"
                : "es fin de semana";
        }
        private static string NombreDelDia(int diaNumero)
        {
            switch (diaNumero)
            {
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miércoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                case 6:
                    return "Sábado";
                case 7:
                    return "Domingo";
                default:
                    throw new Exception("Algo no salio bien");
            }
        }
    }
}
