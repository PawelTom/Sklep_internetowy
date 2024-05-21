using Microsoft.AspNetCore.Mvc;
using Sklep_internetowy.DAL;
using Sklep_internetowy.Infrastructure;
using Sklep_internetowy.Models;
using System.Dynamic;

namespace Sklep_internetowy.Controllers
{
    public class CartController : Controller
    {
        FilmsContext db;

        public CartController(FilmsContext db)
        {
            this.db = db;
        }

        [Route("/Koszyk")]
        public IActionResult Index()
        {
            var cart = CartManager.GetCartItems(HttpContext.Session);

            double? sum = cart.Sum(item => item.Quantity * item.Film.Price);
            ViewBag.total = sum;

            return View(cart);
        }

        public IActionResult AddToCart(int filmId)
        {
            CartManager.AddToCart(HttpContext.Session, filmId, db);

            return RedirectToAction("Index");
        }


        public IActionResult Remove(int filmId)
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, Consts.CartSessionKey);

            int index = GetIndex(filmId);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, Consts.CartSessionKey, cart);

            return RedirectToAction("Index");
        }

        private int GetIndex(int filmId)
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, Consts.CartSessionKey);

            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Film.FilmId.Equals(filmId))
                {
                    return i;
                }
            }

            return -1;
        }

    }
}