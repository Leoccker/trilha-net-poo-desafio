namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Memoria { get; set; }
        public string IMEI { get; set; }

        public Smartphone(string numero, string modelo, string memoria, string imei)
        {
            Numero = numero;
            Modelo = modelo;
            Memoria = memoria;
            IMEI = imei;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}