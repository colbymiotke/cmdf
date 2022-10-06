using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

    public class child : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    

        public IActionResult clockinout()
        {
            return View();
        }

       public IActionResult createchild()
        {
            return View();
        }
    }
