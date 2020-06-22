using System;

namespace Aula22Statisc
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(Conversor.DolarParaReal(52f));
           Console.WriteLine(Conversor.RealParaDolar(52f));
           Console.WriteLine(Conversor.EuroParaReal(52f));
           Console.WriteLine(Conversor.RealParaEuro(52f));
        }
    }
}
