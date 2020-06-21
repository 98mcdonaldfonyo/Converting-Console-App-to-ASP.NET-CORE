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
            return View(); 
            
            
            
            //You can either pass the name of the vIew file on the View("View name")
           // var obj = new { Id = 1, Name = "Foxx" };
           // return View(obj);//if the name of the View is the same as Obj name
            //else
           // return View("View name", obj);
           //when using View from other dir then it will be Return("~/folderAnme/viewname.cshtml"); where "~" means that the View will be the Root one.
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
