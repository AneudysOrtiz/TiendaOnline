using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using shoppingStore.Models;
using System.ComponentModel.DataAnnotations;

namespace shoppingStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        [Key]
        public int id { get; set; }

        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}