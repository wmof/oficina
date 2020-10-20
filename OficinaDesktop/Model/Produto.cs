using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaDesktop.Model
{
    class Produto
    {
        int id;
        private string nome;
        private string descricao;
        private string marca;
        private double valor;
        private double custo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Marca { get => marca; set => marca = value; }
        public double Valor { get => valor; set => valor = value; }
        public double Custo { get => custo; set => custo = value; }
    }
}
