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
    
    //<T> tipo de dado genérico
    public class BaseRepositorio<T>
        where T : class
    {
        //método para inserir..
        public virtual void Insert(T obj)
        {
            using (DataContext d = new DataContext())
            {
                d.Entry(obj).State = EntityState.Added;
                d.SaveChanges();
            } //Dispose..
        }

        //método para atualizar..
        public virtual void Update(T obj)
        {
            using (DataContext d = new DataContext())
            {
                d.Entry(obj).State = EntityState.Modified;
                d.SaveChanges();
            } //Dispose..
        }

        //método para excluir..
        public virtual void Delete(T obj)
        {
            using (DataContext d = new DataContext())
            {
                d.Entry(obj).State = EntityState.Deleted;
                d.SaveChanges();
            } //Dispose..
        }

        //método para listar todos os registros..
        public virtual List<T> FindAll()
        {
            using (DataContext d = new DataContext())
            {
                return d.Set<T>().ToList();
            }
        }

        //método obter 1 registro pelo id..
        public virtual T FindById(int id)
        {
            using (DataContext d = new DataContext())
            {
                return d.Set<T>().Find(id);
            }
        }
    }    
}
