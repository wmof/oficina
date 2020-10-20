using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaDesktop.Model
{
    class Ordem
    {
        private int id;
        private Cliente cliente;
        private Veiculo veiculo;
        private string observacao;
        private double valor;
        private double desconto;
        private double valor_Final;

        public int Id { get => id; set => id = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public double Valor { get => valor; set => valor = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public double Valor_Final { get => valor_Final; set => valor_Final = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
        internal Veiculo Veiculo { get => veiculo; set => veiculo = value; }
    }
}
