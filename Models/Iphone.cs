namespace SistemaCelular.Models
{
    public class Iphone : Celular
    {
        public Iphone(string modelo, string numero) : base(modelo, numero) { }

        public override void Ligar()
        {
            Console.WriteLine("iPhone está ligando...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("iPhone recebendo ligação...");
        }
    }
}

