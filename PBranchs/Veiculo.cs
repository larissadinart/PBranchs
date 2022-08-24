using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBranchs
{

    //definição dos atributos da classe
    internal class Veiculo
    {
        String Marca;
        String Modelo;
        String Cor;
        int Rodas;
        int Capacidade;
        float Preco;

        //método de construção
        public Veiculo(string marca, string modelo, string cor, int rodas, int capacidade, float preco)
        {
            Marca = marca;  
            Modelo = modelo;    
            Cor = cor;  
            Rodas = rodas;  
            Capacidade = capacidade;    
            Preco = preco; 
        }

        //método para retornar os atributos do objeto
        public override string ToString()
        {
            return "Marca: " + Marca + "\nModelo: " + Modelo + "\nCor: " + Cor + "\nRodas: "+ Rodas + "\nCapacidade: " + Capacidade + "\nPreço: " + Preco;
        }

        public string getMarca()
        {
            return Marca;
        }


    }


}
