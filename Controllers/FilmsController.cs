using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Sklep_internetowy.DAL;
using Sklep_internetowy.Models;

namespace Sklep_internetowy.Controllers
{
    public class FilmsController : Controller
    {
        FilmsContext db;

        public FilmsController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FilmsList(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).Single();

            var filmsFromCategory = category.Films.ToList();

            return View(filmsFromCategory);
        }

        public IActionResult Details(int filmId)
        {
            var film = db.Films.Find(filmId);
            var category = db.Categories.Find(film.CategoryId);

            return View(film);
        }

        public IActionResult AddFilm()
        {
            var model = new AddFilmViewModel();
            model.Categories= db.Categories.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddFilm(AddFilmViewModel model)
        {
            model.Film.AddDate = DateTime.Now;  //breakpoint
            model.Film.Poster = "cube.jpg";
            db.Films.Add(model.Film);
            db.SaveChanges();

         


            return RedirectToAction("Details", new {filmId=model.Film.FilmId});
        }

        
    }
}