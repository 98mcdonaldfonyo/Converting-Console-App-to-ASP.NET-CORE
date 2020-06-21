using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyConsole.Models;
using MyConsole.Repository;

namespace MyConsole.Controllers
{
    public class BookController : Controller
    {

        private readonly BookRepository bookRepository=null;

        public BookController()//type ctr to get the deafult constructor
        {
            bookRepository = new BookRepository();  
        }
        //at first we had a string type, but cz we are dealing with a list type inside the method, then we change the return type to List
        //After creating a view file for this method, we have to chnage it's return type to ViewResult and return View() 
        public ViewResult GetAllBooks()
        {
            var data= bookRepository.GetAllBooks();
            return View();
        }
        public BookModel GetBook(int id)
        {
            return bookRepository.GetBookById(id);
        }
        public List<BookModel> SearchBooks(string bookName,string authorName)
        {
            return bookRepository.SearchBook(bookName, authorName);
        }
    }
}
