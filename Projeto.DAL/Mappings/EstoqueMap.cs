using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Projeto.Entidades;

namespace Projeto.DAL.Mappings
{
    public class EstoqueMap : EntityTypeConfiguration<Estoque>
    {
        public EstoqueMap()
        {
            //nome da tabela
            ToTable("Estoque");

            //chave primaria
            HasKey(e => e.IdEstoque);

            //Demais propriedades(campos)
            Property(e => e.IdEstoque)
                .HasColumnName("IdEstoque")
                .IsRequired();

            Property(e => e.NomeEstoque)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsRequired();

        }
        
    }
}
