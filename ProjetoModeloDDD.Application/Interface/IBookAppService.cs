using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.Interface
{
    public interface IBookAppService : IServiceBase<Book>
    {
        IEnumerable<Book> GetAllByTitle();
    }
}
