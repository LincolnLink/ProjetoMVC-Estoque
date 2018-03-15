using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.DAL.Repositories;

namespace Projeto.BLL
{
    public class ProdutoBusiness
    {
        public void Cadastrar(Produto p)
        {
            p.DataCadastro = DateTime.Now;
            ProdutoRepositorio rep = new ProdutoRepositorio();
            rep.Insert(p);
        }
        public void Atualizar(Produto p)
        {
            ProdutoRepositorio rep = new ProdutoRepositorio();
            rep.Update(p);
        }
        public void Excluir(Produto p)
        {
            ProdutoRepositorio rep = new ProdutoRepositorio();
            rep.Delete(p);
        }

        public List<Produto> Consultar()
        {
            ProdutoRepositorio rep = new ProdutoRepositorio();
            return rep.FindAll();
        }

        public List<Produto> ConsultarPorPreco(decimal precoIni, decimal precoFim)
        {
            ProdutoRepositorio rep = new ProdutoRepositorio();
            return rep.FindByPreco(precoIni, precoFim);
        }

        public Produto ObterPorId(int id)
        {
            ProdutoRepositorio rep = new ProdutoRepositorio();
            return rep.FindById(id);
        }
    }
}
