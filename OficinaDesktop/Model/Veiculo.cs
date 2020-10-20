using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaDesktop.Model
{
    class Veiculo
    {
        private int id;
        private string marca;
        private string modelo;
        private string ano_Fabricacao;
        private string ano_Modelo;
        private string observacao;
        private Cliente cliente;

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Ano_Fabricacao { get => ano_Fabricacao; set => ano_Fabricacao = value; }
        public string Ano_Modelo { get => ano_Modelo; set => ano_Modelo = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
    }
}
