﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBs.Production;
using Funcs;
using System.Data.Entity;
using System.Data;

namespace Funcs
{
    public class Cart
    {
        private List<CartLine> Carting = new List<CartLine>();
        public void Adding(Product product, int quantity)
        {
            CartLine cartline = Carting
                .Where(pi => pi.Product.ProductID == product.ProductID)
                .FirstOrDefault();

            if (cartline.Product == null)
            {
                Carting.Add(new CartLine(product, quantity));
            }
            else
            {
                cartline.Quantity += 1;
            }
        }
        public void Deleting(Product product)
        {
            Carting.RemoveAll(l => l.Product.ProductID == product.ProductID);
        }
        public IEnumerable<CartLine> Lines
        {
            get { return Carting; }
        }
    }
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public CartLine(Product p, int q) 
        {
            Product = p;
            Quantity = q;
        }
        public CartLine() { }
    }
}