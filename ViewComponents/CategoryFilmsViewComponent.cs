using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sklep_internetowy.DAL;


namespace Sklep_internetowy.ViewComponents
{
    public class CategoryFilmsViewComponent : ViewComponent
    {
        FilmsContext db;

        public CategoryFilmsViewComponent(FilmsContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(string categoryName)
        {
            var model = db.Categories.Include("Films").Where(c => c.Name.ToLower() == categoryName.ToLower()).Single().Films.ToList().OrderBy(f => f.Title).ToList();
            return await Task.FromResult((IViewComponentResult)View("_CategoryFilms", model));
        }
    }
}