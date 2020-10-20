using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaDesktop.Model
{
    class Servico_Ordem
    {
        private int id;
        private Servico servico;
        private int quantidade;
        private double valor;
        private bool autorizado;
        private Ordem ordem;

        public int Id { get => id; set => id = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public double Valor { get => valor; set => valor = value; }
        public bool Autorizado { get => autorizado; set => autorizado = value; }
        internal Servico Servico { get => servico; set => servico = value; }
        internal Ordem Ordem { get => ordem; set => ordem = value; }
    }
}
