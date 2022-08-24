using System;

namespace PBranchs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo("Fiat", "500", "Branco", 5,4,100000);
            Console.WriteLine(veiculo);
        }
    }
}
