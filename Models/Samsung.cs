namespace SistemaCelular.Models
{
    public class Samsung : Celular
    {
        public Samsung(string modelo, string numero) : base(modelo, numero) { }

        public override void Ligar()
        {
            Console.WriteLine("Samsung está ligando...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Samsung recebendo ligação...");
        }
    }
}

