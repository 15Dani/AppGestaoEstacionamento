using System;
using System.Collections.Generic;
using System.Text;

namespace AppGestaoEstacionamento
{
    class ListaUso
    {
        UsoArquivo primeiro;
        UsoArquivo ultimo;
        public ListaUso()
        {
            primeiro = new UsoArquivo(0, "", DateTime.Now, DateTime.Now);
            ultimo = primeiro;
        }

        public UsoArquivo adicionaFinal(UsoArquivo novo)
        {
            ultimo.prox = novo;
            ultimo = novo;
            return ultimo;
        }

        //teste

        public UsoArquivo adicionaInicio(UsoArquivo novo)
        {
            novo.prox = this.primeiro.prox;
            this.primeiro.prox = novo;

            if (ultimo == primeiro)
                ultimo = novo;
            return novo;
        }


    }
}
    
    

