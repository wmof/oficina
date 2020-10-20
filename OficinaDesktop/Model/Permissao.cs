using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaDesktop.Model
{
    class Permissao
    {
        private int id;
        private string nome;
        private Tipo_Usuario tipo_Usuario;
        private bool ativo;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        internal Tipo_Usuario Tipo_Usuario { get => tipo_Usuario; set => tipo_Usuario = value; }
    }
}
