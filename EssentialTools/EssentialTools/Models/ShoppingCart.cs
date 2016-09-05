using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public class ShoppingCart
    {
        // 수정 Ver 1
        //private LinqValueCalculator calc;
        private IValueCalculator calc;

        // 수정 Ver 1
        //public ShoppingCart(LinqValueCalculator calcParam)
        public ShoppingCart(IValueCalculator calcParam)
        {
            calc = calcParam;
        }

        public IEnumerable<Product> Products { get; set; }

        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(Products);
        }
    }
}