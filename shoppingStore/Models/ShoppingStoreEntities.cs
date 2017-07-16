using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace shoppingStore.Models
{
    public class ShoppingStoreEntities : DbContext
    {
        public ShoppingStoreEntities(): base("conexion") { }
        public DbSet<Item> Items{get; set;}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<shoppingStore.Models.Producer> Producers { get; set; }

        public System.Data.Entity.DbSet<shoppingStore.ViewModels.ShoppingCartViewModel> ShoppingCartViewModels { get; set; }
    }
}