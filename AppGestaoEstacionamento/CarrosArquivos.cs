using System;
using System.Collections.Generic;
using System.Text;

namespace AppGestaoEstacionamento
{
    class CarrosArquivos
    {
        public string Placa { get; set; }

        public CarrosArquivos prox;

        public CarrosArquivos(string Placa)
        {
            this.Placa = Placa;
            this.prox = null;
        }

    }
}
