using PcPartsMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcPartsMarket.ViewModel
{
    public class PcComponentsListViewModel
    {
        public IEnumerable<PcComponent> PcComponents { get; set; }

        public string CurrentCategory { get; set; }
    }
}
