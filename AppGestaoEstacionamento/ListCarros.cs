using System;
using System.Collections.Generic;
using System.Text;

namespace AppGestaoEstacionamento
{
    class ListCarros
    {
        CarrosArquivos primeiro;
        CarrosArquivos ultimo;

        public ListCarros()
        {
            primeiro = new CarrosArquivos("");
            ultimo = primeiro;
        }

        public CarrosArquivos adicionaFinal(CarrosArquivos novo)
        {
            ultimo.prox = novo;
            ultimo = novo;
            return ultimo;
        }

        public CarrosArquivos adicionaInicio(CarrosArquivos novo)
        {
            novo.prox = this.primeiro.prox;
            this.primeiro.prox = novo;

            if (ultimo == primeiro)
                ultimo = novo;
            return novo;
        }
    }
}
