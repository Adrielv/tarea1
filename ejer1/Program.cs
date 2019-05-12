using System;

namespace ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            float cantidadlados;
            float Valorlados;
            string valor;
            float perimetro;

            Console.WriteLine("Digite Los lados del angulo: ");
            valor = Console.ReadLine();
            cantidadlados = Convert.ToSingle(valor);

            Console.WriteLine("Digite el valor de los lados: ");
            valor = Console.ReadLine();
            Valorlados = Convert.ToSingle(valor);

            perimetro = cantidadlados * Valorlados;

            Console.WriteLine("El perimetro es: {0} ", perimetro);
            Console.Read();
        }
    }
}
