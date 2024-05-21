using Microsoft.AspNetCore.Mvc;
using Sklep_internetowy.DAL;
using Sklep_internetowy.Infrastructure;
using Sklep_internetowy.Models;


namespace SklepUKW2024.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        FilmsContext db;

        public MenuViewComponent(FilmsContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.quantity = GetCartQuantity();
            var categories = db.Categories.ToList();

            return await Task.FromResult((IViewComponentResult)View("_Menu", categories));
        }

        private int GetCartQuantity()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, Consts.CartSessionKey);


            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            int count = cart.Sum(i => i.Quantity);

            return count;
        }
    }
}