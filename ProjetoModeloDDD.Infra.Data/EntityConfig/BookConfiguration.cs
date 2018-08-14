using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    class BookConfiguration : EntityTypeConfiguration<Book>
    {
        public BookConfiguration()
        {

            HasKey(b => b.BookId);

            Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(150);

            Property(b => b.Author)
                .IsRequired()
                .HasMaxLength(150);

            Property(b => b.Isbn)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
