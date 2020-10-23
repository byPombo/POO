using System;

namespace pooMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1, msg2;
            msg1 = new Mensagem();
            msg1.TextoMensagem = "Alô Mundo";
            msg1.ExibirMensagem();

            msg2 = new Mensagem();
            msg2.TextoMensagem = "Segundo Objeto";
            msg2.ExibirMensagem();
            Console.ReadKey();
        }
    }
}
