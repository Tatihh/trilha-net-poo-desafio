using System;

namespace DesafioPOO.Models
{
    public class iPhone : Smartphone
    {
        // Construtor
        public iPhone(string numero, string modelo, string imei, int memoria)
            : base(numero, "iPhone", modelo, imei, memoria)
        {
            // TODO: Adicionar lógica específica do construtor da classe iPhone, se necessário
        }

        // Sobrescrever o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{Marca} {Modelo} - Instalando {nomeApp} na App Store.");
        }
    }
}
