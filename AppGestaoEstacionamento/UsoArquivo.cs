using System;
using System.Collections.Generic;
using System.Text;

namespace AppGestaoEstacionamento
{
    class UsoArquivo
    {
        public int IdVaga { get; set; }
        public string Placa { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSaida { get; set; }

        public UsoArquivo prox;

        public UsoArquivo(int IdVaga, string Placa, DateTime HoraEntrada, DateTime HoraSaida)
        {
            this.IdVaga = IdVaga;
            this.Placa = Placa;
            this.HoraEntrada = HoraEntrada;
            this.HoraSaida = HoraSaida;
            this.prox = null;
        }
    }
}
