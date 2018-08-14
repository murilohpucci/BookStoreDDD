using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application
{
    public class BookAppService : AppServiceBase<Book>, IBookAppService
    {
        private readonly IBookService _bookService;

        public BookAppService(IBookService bookService)
            : base(bookService)
        {
            _bookService = bookService;
        }

        public IEnumerable<Book> GetAllByTitle()
        {
            return _bookService.GetAllByTitle();
        }
    }
}
