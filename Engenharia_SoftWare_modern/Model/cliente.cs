using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engenharia_SoftWare_modern.Model
{
    class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int cpf { get; set; }
        public string endereco { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public int telefone { get; set; }

        public Cliente(int id, string nome, int cpf, string endereco, string rua, int numero, string complemento, int telefone)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.rua = rua;
            this.numero = numero;
            this.complemento = complemento;
            this.telefone = telefone;
        }
    }
}
