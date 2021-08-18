using Exercicio_PDV.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_PDV
{
    public partial class Pn1 : Form
    {

        Produto produto = new Produto();

        public Pn1()
        {
            InitializeComponent();
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {

            int cod = int.Parse(txtCodigo.Text);

            Produto busca = produto.buscarPorId(cod);

            if(busca != null)
            {
                lbDesc.Text = busca.Descricao;
                txtPreco.Text = busca.Preco.ToString();
                txtQuantidade.Text = busca.Quantidade.ToString();
            }

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtQuantidade.Text);
            double preco = double.Parse(txtPreco.Text);
            double aux = double.Parse(txtTotal.Text);

            Produto prod;

            if (aux != 0)
            {
                prod = new Produto(quantidade, preco, aux);
            }
            else
            {
                prod = new Produto(quantidade, preco);
            }

            double total = prod.somaTotal(prod);

            txtTotal.Text = total.ToString("N2");
        }
    }
}
