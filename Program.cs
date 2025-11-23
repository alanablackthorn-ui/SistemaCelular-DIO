using System;
using SistemaCelular.Models;

class Program
{
    static void Main()
    {
        var iphone = new Iphone("iPhone 15", "1199999-0001");
        var samsung = new Samsung("Galaxy S24", "1199999-0002");
        var xiaomi = new Xiaomi("Redmi Note 13", "1199999-0003");

        iphone.Ligar();
        samsung.ReceberLigacao();

        xiaomi.EnviarMensagem("Oi, sou um Xiaomi!");
    }
}
