using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdEstoque { get; set; }

        public Estoque Estoque { get; set; }

        public Produto()
        {

        }

        public Produto(int idProduto, string nomeProduto, decimal preco, int quantidade, DateTime dataCadastro)
        {
            IdProduto = idProduto;
            NomeProduto = nomeProduto;
            Preco = preco;
            Quantidade = quantidade;
            DataCadastro = dataCadastro;

        }

        public override string ToString()
        {
            return "iD: " + IdProduto +", Nome: " + NomeProduto + " Preco: " + Preco 
                + "Quantidade : " + Quantidade + " Data Cadastro : " + DataCadastro;
        }
    }
}
