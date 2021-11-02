using System;

namespace Ejercicio_16_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca el primer número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca el segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("\n" + numero1 + " es mayor que " + numero2);
            }
            else
            {
                if (numero1 == numero2)
                {
                    Console.WriteLine("\nLos números son iguales");
                } else
                {
                    Console.WriteLine("\n" + numero2 + " es mayor que " + numero1);
                }
            }
        }
    }
}
