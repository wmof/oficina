using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaDesktop.Model
{
    class Produto_Ordem
    {
        private int id;
        private Produto produto;
        private double valor;
        private int quantidade;
        private bool autorizado;
        private Ordem ordem;

        public int Id { get => id; set => id = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public bool Autorizado { get => autorizado; set => autorizado = value; }
        internal Produto Produto { get => produto; set => produto = value; }
        internal Ordem Ordem { get => ordem; set => ordem = value; }
    }
}
