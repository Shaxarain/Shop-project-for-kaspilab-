﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBs.DB;
using Funcs;
using Shop.Models;
using WCFContracts.DataContracts;

namespace Shop.Controllers
{
    public class CartController : Controller
    {
        private IOrderProcessor orderProcessor;
        public CartController(IOrderProcessor proc) 
        {
            orderProcessor = proc;
        }
        public CartController(){ }
        public ViewResult Index ()
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart()
            });
        }
        public RedirectToRouteResult AddToCart(int ProductID)
        {
            ProductServiceRef.MainContractOf_ProductDataClient client = new ProductServiceRef.MainContractOf_ProductDataClient();
            ProductData product = client.Get(ProductID);
            if (product != null)
            {
                try
                {
                    GetCart().Adding(product, 1);
                }
                catch
                {
                    return RedirectToAction("Index");
                }
                
            }
            client.Close();
            return RedirectToAction("Index");
        }
        public RedirectToRouteResult RemoveFromCart(int ProductID)
        {
            ProductServiceRef.MainContractOf_ProductDataClient client = new ProductServiceRef.MainContractOf_ProductDataClient();
            ProductData Productincart = client.Get(ProductID);

            if (Productincart != null)
            {
                GetCart().Deleting(Productincart);
            }
            client.Close();
            return RedirectToAction("Index");
        }
        public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
        [HttpPost]
        public ViewResult Checkout(Cart cart, PurchasingDetail purchasingDetails)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                orderProcessor.ProcessOrder(cart, purchasingDetails);
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(purchasingDetails);
            }
        }
        public ViewResult Checkout()
        {
            return View(new PurchasingDetail());
        }
    }
}