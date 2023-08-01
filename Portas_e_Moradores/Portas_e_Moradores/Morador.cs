using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portas_e_Moradores
{
    public class Morador : Pessoa
    {

        public string Mostrar()
        {
            return $"Eu sou o morador {this.nome}, meu apartamento tem {this.area} metros e a cor da porta é {this.cor}";
        }
            


    }
}
