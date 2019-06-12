using PcPartsMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcPartsMarket.Data.Interfaces
{
    public interface IPcComponentRepository
    {
        IEnumerable<PcComponent> PcComponents { get; }

        IEnumerable<PcComponent> PreferredPcComponents { get; }

        PcComponent GetPcComponentById(int pcComponentId);
    }
}
