using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcPartsMarket.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        
        public List<PcComponent> PcComponents { get; set; }
    }
}
