using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.Entidades;
using Projeto.DAL.Mappings;
using System.Configuration;

namespace Projeto.DAL.Context
{
    public class DataContext : DbContext
    {
        //Regra 2) Construtor que envie para o DbContext a connectionstring
        public DataContext()
        : base(ConfigurationManager.ConnectionStrings["aula"].ConnectionString)
        {
        }
        //Regra 3) Sobrescrever o método OnModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //adicionar as classes de mapeamento..
            modelBuilder.Configurations.Add(new EstoqueMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
        }
        //Regra 4) Declarar uma propriedade DbSet para cada entidade
        //permitir realizar operações de CRUD com as entidades..
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Produto> Produto { get; set; }
    }

}
