using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Presentation.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoModeloDDD.Presentation.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookAppService _bookApp;

        public BooksController(IBookAppService bookApp)
        {
            _bookApp = bookApp;
        }

        // GET: Books
        public ActionResult Index()
        {
            var bookViewModel = Mapper.Map<IEnumerable<Book>, IEnumerable<BookViewModel>>(_bookApp.GetAllByTitle());
            return View(bookViewModel);
        }

        // GET: Books/Details/5
        public ActionResult Details(int id)
        {
            var book = _bookApp.GetById(id);
            var bookViewModel = Mapper.Map<Book, BookViewModel>(book);

            return View(bookViewModel);
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookViewModel book)
        {
            if (ModelState.IsValid)
            {
                var bookDomain = Mapper.Map<BookViewModel, Book>(book);
                _bookApp.Add(bookDomain);

                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int id)
        {
            var book = _bookApp.GetById(id);
            var bookViewModel = Mapper.Map<Book, BookViewModel>(book);

            return View(bookViewModel);
        }

        // POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BookViewModel book)
        {
            if (ModelState.IsValid)
            {
                var bookDomain = Mapper.Map<BookViewModel, Book>(book);
                _bookApp.Update(bookDomain);

                return RedirectToAction("Index");
            }
            return View(book);
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int id)
        {
            var book = _bookApp.GetById(id);
            var bookViewModel = Mapper.Map<Book, BookViewModel>(book);

            return View(bookViewModel);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var book = _bookApp.GetById(id);
            _bookApp.Remove(book);

            return RedirectToAction("Index");
        }
    }
}
