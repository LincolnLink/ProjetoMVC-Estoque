using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Entidades;
using Projeto.DAL.Context;

namespace Projeto.DAL.Repositories
{
    class ProdutoRepositorio : BaseRepositorio<Produto>
    {
        public override List<Produto> FindAll()
        {
            using (DataContext d = new DataContext())
            {
                return d.Produto //Consulta em Produto
                .Include(p => p.Estoque) //JOIN..
               .ToList(); //retornar..
            }
        }
        //método para retornar produtos por intervalo de preço..
        public List<Produto> FindByPreco(decimal precoIni, decimal precoFim)
        {
            using (DataContext d = new DataContext())
            {
                /*
                * select * from Produto p
                * inner join Estoque e
                * on p.IdEstoque = e.IdEstoque
                * where p.Preco >= @PrecoIni and Preco <= @PrecoFim
                *order by Preco
                */
                 return d.Produto
                 .Include(p => p.Estoque)
                .Where(p => p.Preco >= precoIni && p.Preco <= precoFim)
                .OrderBy(p => p.Preco)
                .ToList();
            }
        }
    }
}
