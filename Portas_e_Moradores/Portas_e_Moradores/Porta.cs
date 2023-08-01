using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portas_e_Moradores
{
    public class Porta
    {
        // public
        protected string cor { get; set; }

        public void ConstroiCor(string cor)
        {
            this.cor = cor;
        }

        public string Mostrar()
        {
            return $"Olá, eu sou uma porta e minha cor é {this.cor}";
        }

    }
}
