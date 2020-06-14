using System;
using System.Collections.Generic;
using System.Text;

namespace AppGestaoEstacionamento
{
    class ListaVagas
    {
        VagasArquivos primeiro;
        VagasArquivos ultimo;

        public ListaVagas()
        {
            primeiro = new VagasArquivos(0,0);
            ultimo = primeiro;
        }

        public VagasArquivos adicionaFinal(VagasArquivos novo)
        {
            ultimo.prox = novo;
            ultimo = novo;
            return ultimo;
        }

        public VagasArquivos adicionaInicio(VagasArquivos novo)
        {
            novo.prox = this.primeiro.prox;
            this.primeiro.prox = novo;

            if (ultimo == primeiro)     
                ultimo = novo;
            return novo;
        }

        
    }
}
    
