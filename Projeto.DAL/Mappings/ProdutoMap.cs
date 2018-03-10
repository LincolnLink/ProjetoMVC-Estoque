using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entidades;

namespace Projeto.DAL.Mappings
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            ToTable("Produto");

            HasKey(p => p.IdProduto);

            Property(p => p.IdProduto)
                .HasColumnName("IdProduto")
                .IsRequired();

            Property(p => p.NomeProduto)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Preco)
                .HasColumnName("Preco")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(p => p.Quantidade)
                .HasColumnName("Quantidade")
                .IsRequired();

            Property(p => p.DataCadastro)
                .HasColumnName("DataCadastro")
                .IsRequired();

            //Mapeamento do relacionamento
            HasRequired(p => p.Estoque) //Produto TEM 1 Estoque
                .WithMany(e => e.Produtos) //Estoque TEM muitos Produtos
                .HasForeignKey(p => p.IdEstoque); //chave estrangeira
        }
    }
}
