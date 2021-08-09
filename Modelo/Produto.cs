using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_PDV.Modelo
{
    class Produto
    {
        private int Codigo { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public double Total { get; private set; }

        public Produto(){}

        public Produto(int quantidade, double preco)
        {
            this.Quantidade = quantidade;
            this.Preco = preco;
        }

        public Produto(int codigo, string descricao, int quantidade, double preco)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.Preco = preco;
        }

        private List<Produto> getProdutos()
        {
            List<Produto> resultado = new List<Produto>();
            resultado.Add(new Produto(1, "Melancia", 4, 2.30));
            resultado.Add(new Produto(2, "Maçã", 6, 0.30));
            resultado.Add(new Produto(3, "Banana", 2, 2.00));
            resultado.Add(new Produto(4, "Limão", 7, 0.20));
            resultado.Add(new Produto(5, "Pêra", 6, 0.75));

            return resultado;
        }

        public Produto buscarPorId(int Codigo)//Faz uma busca no método getProdutos a partir do id selecionado
        {
            Produto produtoBuscado = null;
            foreach(var produto in getProdutos())
            {
                if(produto.Codigo == Codigo)//Verifica se o código de entrada bate com algum da lista
                {
                    produtoBuscado = produto;
                    break;
                }
            }

            return produtoBuscado;

        }

        public double somaTotal(Produto prod)
        {
            double total;

            if(prod.Total > 0)
            {
                total = prod.Quantidade * prod.Preco + prod.Total;
                this.Total = total;
                return total;
            }
            else
            {
                total = prod.Preco * prod.Quantidade;
                this.Total = total;
                return total;
            }
        
        }

    }
}
