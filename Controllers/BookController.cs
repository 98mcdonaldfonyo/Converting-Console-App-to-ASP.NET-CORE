using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyConsole.Controllers
{
    public class BookController : Controller
    {
        public string getAllBooks()
        {
            return "All books";
        }
    }
}
