using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBranchs
{
    //classe moto herdou da classe veiculo
    internal class Moto : Veiculo
    {
        int Cilindradas;
        bool PartidaEletrica;

    //método construtor

    public Moto(string marca, string modelo, string cor, int rodas, int capacidade, float preco, int cilindradas, bool partidaeletrica)
            : base(marca, modelo, cor, rodas, capacidade, preco)
        {
            Cilindradas = cilindradas;
            PartidaEletrica = partidaeletrica;

            Moto moto = new Moto("Yamaha", "XJ6", "Branca", 2, 2, 30000, 600, true);

            Console.WriteLine(moto);
        }

        public override string ToString()
        {
            string mensagem;

            if (PartidaEletrica)
            {
                mensagem = "Sim";
            }
            else
            {
                mensagem = "Não";
            }
            return base.ToString() + "\nCilindradas: " + Cilindradas + "\nPartida Elétrica: " + mensagem;
        }//retorno usando base para reaproveitamento do código anterior

    }

}
