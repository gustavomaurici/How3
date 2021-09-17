using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }

        public Pessoa()
        {
            
        }
        public Pessoa(int id, string nome, string cpf, string cidade, string bairro, string rua)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Cidade = cidade;
            this.Bairro = bairro;
            this.Rua = rua;
        }

    }
}
