using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaDesktop.Model
{
    class Usuario
    {
        private int id;
        private string identificacao;
        private Tipo_Usuario tipo_Usuario;
        private string email;
        private bool ativo;
        private string senha;

        public int Id { get => id; set => id = value; }
        public string Identificacao { get => identificacao; set => identificacao = value; }
        public string Email { get => email; set => email = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public string Senha { get => senha; set => senha = value; }
        internal Tipo_Usuario Tipo_Usuario { get => tipo_Usuario; set => tipo_Usuario = value; }
    }
}
