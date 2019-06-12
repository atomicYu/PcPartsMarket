using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcPartsMarket.Models
{
    public class PcComponent
    {
        public int PcComponentId { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public string InfoLink { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public bool IsPreferredPcComponent { get; set; }

        public bool InStock { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
