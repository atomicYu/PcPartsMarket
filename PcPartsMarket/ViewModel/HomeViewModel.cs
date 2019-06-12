using PcPartsMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcPartsMarket.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<PcComponent> PreferredPcComponents { get; set; }
    }
}
