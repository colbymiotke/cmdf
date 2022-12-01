using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

    public class AdminPage : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    

        public IActionResult AdminLoggedIn()
        {
            return View();
        }

        public string tesing()
        {
            return "this is the welcome aciton method hi...";
        }
    }
