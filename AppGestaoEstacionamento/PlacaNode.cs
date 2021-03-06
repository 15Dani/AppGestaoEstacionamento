﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppGestaoEstacionamento
{
        class PlacaNode
        {
            // Atributos
            private Placa placa;
            private PlacaNode direita;
            private PlacaNode esquerda;
            private PlacaNode pai;
            private int balanceamento;
            private List<Estacionada> estacionadas;

            // Construtor
            public PlacaNode()
            { }

            public PlacaNode(Placa placa, List<Estacionada> estacionadas)
            {
                this.placa = placa;
                this.esquerda = this.direita = null;
                this.estacionadas = estacionadas;
            }

            public Placa Placa
            {
                get { return placa; }
                set { placa = value; }
            }

            public PlacaNode Direita
            {
                get { return direita; }
                set { direita = value; }
            }

            public PlacaNode Esquerda
            {
                get { return esquerda; }
                set { esquerda = value; }
            }
            public PlacaNode Pai
            {
                get { return pai; }
                set { pai = value; }
            }

            public int Balanceamento
            {
                get { return balanceamento; }
                set { balanceamento = value; }
            }

            public List<Estacionada> Estacionadas
            {
                get { return estacionadas; }
                set { estacionadas = value; }
            }

        }
    }



