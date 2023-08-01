using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portas_e_Moradores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnPorta_Click(object sender, EventArgs e)
        {
            Porta p = new Porta();
            p.ConstroiCor(txtCor.Text);
            MessageBox.Show(p.Mostrar());

        }

        private void btnhabitacao_Click(object sender, EventArgs e)
        {
            Habitacao hab= new Habitacao();
            hab.ConstroiHab(double.Parse(txtBase.Text),double.Parse(txtAltura.Text));
            hab.CalcularArea();
            hab.ConstroiCor(txtCor.Text);
            MessageBox.Show(hab.Mostrar());
        }

        private void btnPessoa_Click(object sender, EventArgs e)
        {
            Pessoa pe = new Pessoa();
            pe.ConstroiPessoa(txtNome.Text);
            MessageBox.Show(pe.Mostrar());
        }

        private void btnTudo_Click(object sender, EventArgs e)
        {
            Morador m = new Morador();
            m.ConstroiCor(txtCor.Text);
            m.ConstroiHab(double.Parse(txtBase.Text), double.Parse(txtAltura.Text));
            m.CalcularArea();
            m.ConstroiPessoa(txtNome.Text);
            MessageBox.Show(m.Mostrar());
        }
    }
}
