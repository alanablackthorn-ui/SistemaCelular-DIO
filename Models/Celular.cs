using System;

namespace SistemaCelular.Models
{
    public abstract class Celular
    {
        // Já começam com string vazia, assim nunca ficam null
        public string Modelo { get; protected set; } = string.Empty;
        public string Numero { get; protected set; } = string.Empty;

        // Construtor obrigatório: todo celular precisa ter modelo e número
        protected Celular(string modelo, string numero)
        {
            Modelo = modelo;
            Numero = numero;
        }

        public abstract void Ligar();
        public abstract void ReceberLigacao();

        public virtual void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"{Modelo} ({Numero}) enviou: {mensagem}");
        }
    }
}
