using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PcPartsMarket.Data.Interfaces;
using PcPartsMarket.Models;
using PcPartsMarket.ViewModel;

namespace PcPartsMarket.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPcComponentRepository _pcComponentkRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPcComponentRepository pcComponentkRepository, ShoppingCart shoppingCart)
        {
            _pcComponentkRepository = pcComponentkRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var item = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = item;

            var shoppCartVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppCartVM);
        }

        public RedirectToActionResult AddToShoppingCart(int pcComponentId)
        {
            var selectedPcComponent = _pcComponentkRepository.PcComponents.FirstOrDefault(p => p.PcComponentId == pcComponentId);
            if (selectedPcComponent != null)
            {
                _shoppingCart.AddToCart(selectedPcComponent, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int pcComponentId)
        {
            var selectedPcComponent = _pcComponentkRepository.PcComponents.FirstOrDefault(p => p.PcComponentId == pcComponentId);
            if (selectedPcComponent != null)
            {
                _shoppingCart.RemoveFromCart(selectedPcComponent);
            }
            return RedirectToAction("Index");
        }
    }
}