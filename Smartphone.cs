using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades
        public string Numero { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        // Construtor
        protected Smartphone(string numero, string marca, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Marca = marca;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos
        public void Ligar()
        {
            Console.WriteLine($"{Marca} {Modelo} - Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"{Marca} {Modelo} - Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}