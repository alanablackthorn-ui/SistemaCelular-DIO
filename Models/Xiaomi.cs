namespace SistemaCelular.Models
{
    public class Xiaomi : Celular
    {
        public Xiaomi(string modelo, string numero) : base(modelo, numero) { }

        public override void Ligar()
        {
            Console.WriteLine("Xiaomi iniciando ligação...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Xiaomi recebendo ligação...");
        }
    }
}

