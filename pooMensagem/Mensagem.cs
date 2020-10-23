using System;
using System.Collections.Generic;
using System.Text;

namespace pooMensagem
{
    class Mensagem
    {
        //private string TextoMensagem;

        //public void ExibirMensagem()
        //{
        //    Console.WriteLine(this.TextoMensagem);
        //}

        //public string getTextoMensagem()
        //{
        //    return this.TextoMensagem;
        //}
        //public void setTextoMensagem(string valor)
        //{
        //    this.TextoMensagem = valor.ToUpper();
        //}

        private string textoMensagem;
        public string TextoMensagem
        {
            get
            {
                return this.TextoMensagem;
            }

            set
            {
                this.textoMensagem = value.ToUpper();
            }
        }

    }
}
