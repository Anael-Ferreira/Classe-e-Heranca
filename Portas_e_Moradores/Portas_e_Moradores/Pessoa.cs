using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portas_e_Moradores
{
    public class Pessoa : Apartamento
    {

        protected string nome { get; set; }

        public void ConstroiPessoa(string nome)
        {
            this.nome = nome;
        }

        public string Mostrar()
        {
            return $"Meu nome é {this.nome}.";
        }

    }
}
