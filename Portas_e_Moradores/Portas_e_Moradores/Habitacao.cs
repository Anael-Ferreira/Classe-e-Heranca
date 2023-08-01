using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portas_e_Moradores
{
    public class Habitacao : Porta
    {

        protected double area { get; set; }
        protected double B { get; set;}
        protected double H { get; set;}

        public void ConstroiHab(double B, double H)
        {
            this.B = B;
            this.H = H;
        }


        public double CalcularArea()
        {
            return this.area = this.B * this.H;
        }

        public string Mostrar()
        {
            return $" Eu sou uma habitação, minha area é {this.area} m², e a cor da minha porta é {this.cor}";
        }

    }
}
