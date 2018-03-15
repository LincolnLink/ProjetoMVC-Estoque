using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades;
using Projeto.DAL.Repositories;

namespace Projeto.BLL
{
    public class EstoqueBussines
    {
        public void Cadastrar(Estoque e)
        {
            EstoqueRepositorio rep = new EstoqueRepositorio();
            rep.Insert(e);
        }

        public void Atualizar(Estoque e)
        {
            EstoqueRepositorio rep = new EstoqueRepositorio();
            rep.Update(e);
        }

        public void Excluir(Estoque e)
        {
            EstoqueRepositorio rep = new EstoqueRepositorio();
            rep.Delete(e);
        }

        public List<Estoque> Consultar()
        {
            EstoqueRepositorio rep = new EstoqueRepositorio();
            return rep.FindAll();
        }

        public Estoque ObterPorId(int id)
        {
            EstoqueRepositorio rep = new EstoqueRepositorio();
            return rep.FindById(id);
        }
    }
}
