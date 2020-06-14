using System;
using System.Collections.Generic;
using System.Text;

namespace AppGestaoEstacionamento
{
    class VagasArquivos
    {
       public int IdEstacionamento { get; set; }
       public int IdVaga { get; set; }

       public VagasArquivos prox;

        public VagasArquivos(int IdEstacionamento, int IdVaga)
        {
            this.IdEstacionamento = IdEstacionamento;
            this.IdVaga = IdVaga;
            this.prox = null;
        }
    }
}
