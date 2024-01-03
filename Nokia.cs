using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, "Nokia", modelo, imei, memoria)
        {
            // TODO: Adicionar lógica específica do construtor da classe Nokia, se necessário
        }

        // Sobrescrever o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{Marca} {Modelo} - Instalando {nomeApp} na plataforma Windows Phone.");
        }
    }
}