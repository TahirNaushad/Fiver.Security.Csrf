using Microsoft.AspNetCore.Mvc;
using Fiver.Security.Csrf.Models.Home;

namespace Fiver.Security.Csrf.Controllers
{
    //[AutoValidateAntiforgeryToken]
    public class HomeController : Controller
    {
        private readonly IMovieService service;

        public HomeController(IMovieService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            var model = this.service.GetMovies();
            return View(model);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        //[IgnoreAntiforgeryToken]
        public IActionResult Save(Movie model)
        {
            this.service.AddMovie(model);
            return RedirectToAction("Index");
        }
    }
}
