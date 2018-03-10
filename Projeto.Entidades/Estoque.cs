using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades
{
    public class Estoque
    {
        public int IdEstoque { get; set; }
        public string NomeEstoque { get; set; }

        public List<Produto> Produtos { get; set; }

        public Estoque()
        {

        }

        public Estoque(int idEstoque, string nomeEstoque)
        {
            IdEstoque = idEstoque;
            NomeEstoque = nomeEstoque;

        }

        public override string ToString()
        {
            return "Id: " + IdEstoque + "Nome do Estoque: " + NomeEstoque;
        }
    }
}
