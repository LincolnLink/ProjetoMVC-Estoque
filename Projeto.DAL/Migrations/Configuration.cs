namespace Projeto.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Projeto.Entidades;

    internal sealed class Configuration : DbMigrationsConfiguration<Projeto.DAL.Context.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Projeto.DAL.Context.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //criando estoques no banco de dados
            context.Estoque.AddOrUpdate(
            new Estoque { IdEstoque = 1, NomeEstoque = "Inform�tica" },
            new Estoque { IdEstoque = 2, NomeEstoque = "Eletr�nicos" },
            new Estoque { IdEstoque = 3, NomeEstoque = "Livraria" },
            new Estoque { IdEstoque = 4, NomeEstoque = "Games" }
            );
        }
    }
}
