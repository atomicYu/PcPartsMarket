using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PcPartsMarket.Data.Interfaces;
using PcPartsMarket.Models;
using PcPartsMarket.ViewModel;

namespace PcPartsMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPcComponentRepository _pcComponentRepository;

        public HomeController(IPcComponentRepository pcComponentRepository)
        {
            _pcComponentRepository = pcComponentRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredPcComponents = _pcComponentRepository.PreferredPcComponents
            };

            return View(homeViewModel);
        }
    }
}
