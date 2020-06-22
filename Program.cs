using System;

namespace Aula22
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Converção de dólar: ");
            Console.WriteLine( Conversor.ConverterRealParaDolar(50) );
            Console.WriteLine( Conversor.ConverterDolarParaReal(50) );

            System.Console.WriteLine("Conversão de euro: ");
            Console.WriteLine( Conversor.ConverterRealParaEuro(50) );
            Console.WriteLine( Conversor.ConverterEuroParaReal(50) );
        }
    }
}
