using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsole.Controllers
{
    public class HomeController: Controller//inherit the HomeController class from Controller class
    {
        public string Index()

        {
            return "My first MVC"; 
        }

    }
}
