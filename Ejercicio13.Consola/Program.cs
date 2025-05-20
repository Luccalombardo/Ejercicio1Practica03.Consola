


namespace Ejercicio13.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar 3 números cual quiera y distintos entre ellos y se motraran en orden");
            Console.Write("Ingrese el primer numero: ");
            string? inputNro1 = Console.ReadLine();
            Console.Write("Ingrese el segundo numero: ");
            string? inputNro2 = Console.ReadLine();
            Console.Write("Ingrese el tercer numero: ");
            string? inputNro3 = Console.ReadLine();
            Console.WriteLine("Ingrese la opcion segun el tipo de ordenamiento que quiera");
            Console.WriteLine("1 - De Menor a Mayor");
            Console.WriteLine("2 - De Mayor a Menor");
            Console.Write("Ingrese opciones (1/2): ");
            string? inputOpcion = Console.ReadLine();
            if(int.TryParse(inputNro1, out int numero1) && int.TryParse(inputNro2, out int numero2) && int.TryParse(inputNro3, out int numero3) && int.TryParse(inputOpcion, out int menuOpcion) && NumerosDistinto(numero1,numero2, numero3))
            {
                int nroMayor = CualEsMayor(numero1, numero2, numero3);
                int nroMenor = CualEsMenor(numero1, numero2, numero3);
                int nroMedio = CualEsMedio(numero1, numero2, numero3);
                

                switch(menuOpcion)
                {
                    case 1:
                        Console.WriteLine($"Los numeros de Menor a Mayor son {nroMenor}, {nroMedio}, {nroMayor}");
                        break;
                    case 2:
                        Console.WriteLine($"Los numeros de Mayor a Menor son {nroMayor}, {nroMedio}, {nroMenor}");
                        break;
                    default:
                        Console.WriteLine("El valor ingresado no esta entre las opciones disponibles");
                        break;
                }

            }
            else
            {
                Console.WriteLine("ERROR: los numeros ingresados no son validos");
            }
        }

        private static bool NumerosDistinto(int numero1, int numero2, int numero3)
        {
            return (numero1 != numero2) && (numero2 != numero3) && (numero3 != numero1);
        }

        private static int CualEsMedio(int numero1, int numero2, int numero3)
        {
            if (numero1 != CualEsMenor(numero1, numero2, numero3) && numero1 != CualEsMayor(numero1, numero2, numero3)) 
            {
                return numero1;
            }
            else if (numero2 != CualEsMenor(numero1, numero2, numero3) && numero2 != CualEsMayor(numero1, numero2, numero3))
            {
                return numero2;
            }
            else
            {
                return numero3;
            }
        }

        private static int CualEsMenor(int numero1, int numero2, int numero3)
        {
            if (numero1 < numero2 && numero1 < numero3)
            {
                return numero1;
            }
            else if (numero2 < numero1 && numero2 < numero3)
            {
                return numero2;
            }
            else
            {
                return numero3;
            }
        }

        private static int CualEsMayor(int numero1, int numero2, int numero3)
        {
            if(numero1 > numero2 && numero1> numero3)
            {
                return numero1;
            }
            else if(numero2>numero1 && numero2 > numero3)
            {
                return numero2;
            }
            else
            {
                return numero3;
            }
        }
    }
}
