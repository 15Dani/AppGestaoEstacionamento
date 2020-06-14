using System;
using System.Collections.Generic;
using System.Text;

namespace AppGestaoEstacionamento
{
        class Vaga
        {
            // Atributos
            private string nome;
            private int tipo;

            // Construtor
            public Vaga()
            { }

            public Vaga(string nome, int tipo)
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



