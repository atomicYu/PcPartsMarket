using Microsoft.EntityFrameworkCore;
using PcPartsMarket.Data.Interfaces;
using PcPartsMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcPartsMarket.Data.Repositories
{
    public class PcComponentRepository : IPcComponentRepository
    {
        private readonly AppDbContext _appDbContext;

        public PcComponentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<PcComponent> PcComponents => _appDbContext.PcComponents.Include(c => c.Category);

        public IEnumerable<PcComponent> PreferredPcComponents => _appDbContext.PcComponents.Where(p => p.IsPreferredPcComponent).Include(c => c.Category);

        public PcComponent GetPcComponentById(int pcComponentId) => _appDbContext.PcComponents.FirstOrDefault(p => p.PcComponentId == pcComponentId);
      
    }
}
