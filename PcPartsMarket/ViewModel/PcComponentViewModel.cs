﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcPartsMarket.ViewModel
{
    public class PcComponentViewModel
    {
        public int PcComponentId { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string ShortDescription { get; set; }

        public decimal Price { get; set; }

        public string ImageThumbnailUrl { get; set; }
    }
}