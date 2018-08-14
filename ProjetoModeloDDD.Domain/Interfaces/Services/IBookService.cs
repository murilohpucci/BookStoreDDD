using ProjetoModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Interfaces.Services
{
    public interface IBookService : IServiceBase<Book>
    {
        IEnumerable<Book> GetAllByTitle();
    }
}
