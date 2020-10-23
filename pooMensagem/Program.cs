using System;

namespace pooMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1, msg2;
            msg1 = new Mensagem();
            msg1.setTextoMensagem("Alô Mundo");
            Console.WriteLine(msg1.getTextoMensagem());

            msg2 = new Mensagem();
            msg2.TextoMensagem = "Segundo Objeto";
            msg2.ExibirMensagem();
            Console.ReadKey();
        }
    }
}
