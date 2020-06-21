using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsole.Controllers
{
    public class HomeController: Controller//inherit the HomeController class from Controller class
    {
        //we changed the return type from string to ViewResult, as the return types for action method with Views are ViewResult
        //and a View () has to be used for each Controller 
        //The name of the Controller has to be the same as its designated View file
        public ViewResult Index()

        {
            return View(); //You can either pass the name of the vIew file on the View("View name")
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
