using System;
using System.Collections.Generic;
using System.Text;

namespace AppGestaoEstacionamento
{
        class Data
        {
            // Atributos
            public DateTime entradas;

            // Construtor
            public Data()
            { }

            public Data(DateTime entrada)
            {
                this.entradas = entrada;
            }

            public DateTime Entradas
            { get { return entradas; } }
        }
    }



