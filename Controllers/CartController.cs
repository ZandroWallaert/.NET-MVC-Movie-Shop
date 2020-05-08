using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Web;
using howest_movie_lib.Library.Models;
using howest_movie_shop.Library.Handlers;
using howest_movie_shop.Models;
using howest_movie_shop.ViewModels.Movies;
using Library.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace howest_movie_shop.Controllers
{
    public class CartController : Controller
    {
        private SessionService service = new SessionService();
        private OrderHandler orderHandler = new OrderHandler();

        public ActionResult Shoppingcart()
        {
            ViewBag.ShowCart = true;
            string cartString = HttpContext.Session.GetString("Cart");
            if (cartString == null || HttpContext.Session.GetString("Cart") == "")
            {
                ViewBag.ShowDefaultInfo = true;
                List<OrderViewModel> cart = new List<OrderViewModel>();
                return View(orderHandler.CreateOrderPage(cart));
            }
            else
            {
                List<OrderViewModel> cart = JsonSerializer.Deserialize<List<OrderViewModel>>(cartString);
                return View(orderHandler.CreateOrderPage(cart));
            }
        }

        public ActionResult Buy(long id)
        {
            if (HttpContext.Session.GetString("Cart") == null || HttpContext.Session.GetString("Cart") == "")
            {
                List<OrderViewModel> cart = new List<OrderViewModel>();
                cart.Add(new OrderViewModel
                {
                    Movie = service.AllMovies().Where(s => s.Id.Equals(id)),
                    Quantity = 1
                });
                HttpContext.Session.SetString("Cart", JsonSerializer.Serialize(cart));
                HttpContext.Session.SetInt32("CartCounter", cart.Count());
            }
            else
            {
                string cartStr = HttpContext.Session.GetString("Cart");
                List<OrderViewModel> cart = JsonSerializer.Deserialize<List<OrderViewModel>>(cartStr);
                if (Exist(id))
                {
                    return RedirectToAction("", "Movie");
                }
                else
                { 
                    cart.Add(new OrderViewModel
                    {
                        Movie = service.AllMovies().Where(s => s.Id.Equals(id)),
                        Quantity = 1
                    });
                }
                HttpContext.Session.SetString("Cart", JsonSerializer.Serialize(cart));
                HttpContext.Session.SetInt32("CartCounter", cart.Count());
            }
            return RedirectToAction("", "Movie");
        }

        /* public ActionResult Remove(long id)
        {
            string cartStr = HttpContext.Session.GetString("Cart");
            List<MoviesViewModel> cart = JsonSerializer.Deserialize<List<MoviesViewModel>>(cartStr);
            int index = isExist(id);
            cart.RemoveAt(index);
            HttpContext.Session.SetString("Cart", JsonSerializer.Serialize(cart));
            return RedirectToAction("Shoppingcart");
        } */

        private bool Exist(long id)
        {
            string cartStr = HttpContext.Session.GetString("Cart");
            string idStr = ":"+id.ToString()+",";
            if (cartStr.Contains(idStr)) {
                return true;
            }
            else {
                return false;
            }
        }
    }

}