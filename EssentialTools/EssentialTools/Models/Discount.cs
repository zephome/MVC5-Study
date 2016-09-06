using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EssentialTools.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }

    public class DefaultDiscountHelper : IDiscountHelper
    {
        // NinjectDependencyResolver에서 WithPropertyValue로 접근
        //public decimal DiscountSize { get; set; }

        public decimal DiscountSize;

        public DefaultDiscountHelper(decimal discountParam)
        {
            DiscountSize = discountParam;
        }

        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (DiscountSize / 100m * totalParam));
        }
    }
}