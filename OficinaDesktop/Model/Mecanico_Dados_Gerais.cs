﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OficinaDesktop.Model
{
    class Mecanico_Dados_Gerais
    {
        private int id;
        private string endereco_Rua;
        private string endereco_Bairro;
        private string endereco_Numero;
        private string endereco_Cidade;
        private string endereco_Estado;
        private string endereco_Cómplemento;
        private string endereco_Cep;
        private Mecanico mecanico;
        private DateTime data_Nascimento;
        private DateTime data_Contratacao;
        private DateTime data_Demissao;
        private bool ativo;

        public int Id { get => id; set => id = value; }
        public string Endereco_Rua { get => endereco_Rua; set => endereco_Rua = value; }
        public string Endereco_Bairro { get => endereco_Bairro; set => endereco_Bairro = value; }
        public string Endereco_Numero { get => endereco_Numero; set => endereco_Numero = value; }
        public string Endereco_Cidade { get => endereco_Cidade; set => endereco_Cidade = value; }
        public string Endereco_Estado { get => endereco_Estado; set => endereco_Estado = value; }
        public string Endereco_Cómplemento { get => endereco_Cómplemento; set => endereco_Cómplemento = value; }
        public string Endereco_Cep { get => endereco_Cep; set => endereco_Cep = value; }
        public DateTime Data_Nascimento { get => data_Nascimento; set => data_Nascimento = value; }
        public DateTime Data_Contratacao { get => data_Contratacao; set => data_Contratacao = value; }
        public DateTime Data_Demissao { get => data_Demissao; set => data_Demissao = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        internal Mecanico Mecanico { get => mecanico; set => mecanico = value; }
    }
}
