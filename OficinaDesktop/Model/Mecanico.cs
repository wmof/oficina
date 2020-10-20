using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaDesktop.Model
{
    class Mecanico
    {
        private int id;
        private string nome;
        private string cpf;
        private string rg;
        private Usuario usuario;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        internal Usuario Usuario { get => usuario; set => usuario = value; }
    }
}
