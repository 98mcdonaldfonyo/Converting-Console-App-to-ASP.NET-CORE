using MyConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsole.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();//the Where method has a condition to filter the by ID.
        }
        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id=0, Title="My Life is of God", Author="Jesus "},
                new BookModel(){ Id=2, Title="My Goals", Author="Mc Donald"},
                new BookModel(){ Id=3, Title="My Career", Author="Mc Donald"},
                new BookModel(){ Id=1, Title="My Life Plans", Author="Jesus "},
                new BookModel(){ Id=4, Title="Strategies", Author="Mc Donald"},
                new BookModel(){ Id=5, Title="Personality Type", Author="Mc Donald"}
            };
        
        }


    }
}
