using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Smartphone
    {
        public string? Numero;
        private string? Modelo;
        private string? IMEI;
        private int Memoria;

        public void Ligar(){
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao(){
            Console.WriteLine("Recebendo Ligação...");
        }
        public abstract void InstalarAplicativo(string nome);


        public Smartphone(string numero, string modelo, string imei, int memoria){

            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;
        }


    }

}