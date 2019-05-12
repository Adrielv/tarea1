using System;

namespace ejer3
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            double grados;
            double radianes;
            Console.WriteLine("Digite los grados:");
            valor = Console.ReadLine();
            grados = Convert.ToDouble(valor);

            radianes = grados * ( Math.PI /180);
            Console.WriteLine("{0} Grados = {1} Radianes", grados, radianes);
            Console.Read();
        }
    }
}
