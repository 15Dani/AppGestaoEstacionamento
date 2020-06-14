using System;
using System.Collections.Generic;
using System.Text;

namespace AppGestaoEstacionamento
{
    class Placa
        {
            // Atributos
            private string nome;
            private int tipo;

            // Construtor
            public Placa()
            { }

            public Placa(string nome, int tipo)
            {
                this.nome = nome;
                this.tipo = tipo;
            }

            public string Nome
            { get { return nome; } }

            public int Tipo
            { get { return tipo; } }

        }
    }



