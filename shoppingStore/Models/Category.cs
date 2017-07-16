﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shoppingStore.Models
{
    public partial class Category
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public List <Item> Items { get; set; }
    }

}