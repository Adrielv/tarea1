using System;

namespace ejer4
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;
            string valor;
            Console.WriteLine("Digite los grados en celcius: ");
            valor = Console.ReadLine();
            celsius = Convert.ToDouble(valor);

            fahrenheit = ((9/5) * celsius) + 32;

            Console.WriteLine("{0} celcius = {1} fahrenheit", celsius, fahrenheit);
            Console.Read();
        }
    }
}
