using System;

namespace ejer5
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolares;
            double canteuros = 0.8902;
            string valor;
            Console.WriteLine("Digitar Monto de dolares a convertir a Euros:");
            valor = Console.ReadLine();
            dolares = Convert.ToDouble(valor);
            double conversion = dolares * canteuros;

            Console.WriteLine("{0} Dolares = {1} Euros", dolares, conversion);
        }
    }
}
