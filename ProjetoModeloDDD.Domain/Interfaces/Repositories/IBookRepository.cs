using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositories
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
        IEnumerable<Book> GetAllByTitle();
    }
}
