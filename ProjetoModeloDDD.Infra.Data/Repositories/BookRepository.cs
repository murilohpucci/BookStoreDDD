using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public IEnumerable<Book> GetAllByTitle()
        {
            return Db.Books
                .Where(b => b.Active == true)
                .OrderBy(b => b.Title)
                .ToList();
        }

    }
}
