using Microsoft.AspNetCore.Mvc;
using MvcMovie.Data;
using MvcMovie.Models;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

    public class ParentSignUpPage : Controller
    {
        
        private readonly MvcMovieContext _context;

        public ParentSignUpPage(MvcMovieContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    

        public IActionResult ParentSignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ParentSignUp([Bind("Id,FirstName,LastName")] Parent parent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parent);
        }

        public string tesing()
        {
            return "this is the welcome aciton method...";
        }
    }
