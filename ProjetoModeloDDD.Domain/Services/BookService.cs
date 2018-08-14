using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class BookService : ServiceBase<Book>, IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
            : base(bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAllByTitle()
        {
            return _bookRepository.GetAllByTitle();
        }
    }
}
