﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcPartsMarket.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }

        public PcComponent PcComponent { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }
    }
}
