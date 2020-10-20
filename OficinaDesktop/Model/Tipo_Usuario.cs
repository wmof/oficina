using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaDesktop.Model
{
    class Tipo_Usuario
    {
        private int id;
        private string nome;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
