using System;
using System.Collections.Generic;
using System.Text;

namespace AppGestaoEstacionamento
{
       class Estacionada
         {
            // Atributos
            private string placa;
            private string vaga;
            private DateTime entrada;
            private DateTime saida;

            // Construtor
            public Estacionada()
            { }

            public Estacionada(string placa, string vaga, DateTime entrada, DateTime saida)
            {
                this.placa = placa;
                this.vaga = vaga;
                this.entrada = entrada;
                this.saida = saida;
            }

            public string Vaga
            { get { return vaga; } }

            public string Placa
            { get { return placa; } }

            public DateTime Entrada
            { get { return entrada; } }

            public DateTime Saida
            { get { return saida; } }
        }
    }



