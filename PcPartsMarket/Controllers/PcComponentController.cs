using Microsoft.AspNetCore.Mvc;
using PcPartsMarket.Data.Interfaces;
using PcPartsMarket.Models;
using PcPartsMarket.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcPartsMarket.Controllers
{
    public class PcComponentController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IPcComponentRepository _pcComponentRepository;

        public PcComponentController(ICategoryRepository categoryRepository, IPcComponentRepository pcComponentRepository)
        {
            _categoryRepository = categoryRepository;
            _pcComponentRepository = pcComponentRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<PcComponent> pcComponents;

            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                pcComponents = _pcComponentRepository.PcComponents.OrderBy(i => i.PcComponentId);
                currentCategory = "All Components";
            }

            else
            {
                pcComponents = _pcComponentRepository.PcComponents.Where(c => c.Category.CategoryName.Equals(_category)).OrderBy(c => c.Name);

                currentCategory = _category;
            }

            var pcComponentListViewModel = new PcComponentsListViewModel
            {
                PcComponents = pcComponents,
                CurrentCategory = currentCategory
            };

            return View(pcComponentListViewModel);
        }
        
        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<PcComponent> pcComponents;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                pcComponents = _pcComponentRepository.PcComponents.OrderBy(p => p.PcComponentId);
            }
            else
            {
                pcComponents = _pcComponentRepository.PcComponents.Where(p => p.Name.ToLower().Contains(_searchString.ToLower()));

                if (pcComponents.Count()==0)
                {
                    pcComponents = _pcComponentRepository.PcComponents.Where(p => p.Brand.ToLower().Contains(_searchString.ToLower()));
                }
                if (pcComponents.Count() == 0)
                {
                    pcComponents = _pcComponentRepository.PcComponents.Where(p => p.Category.CategoryName.ToLower().Contains(_searchString.ToLower()));
                }

            }

            return View("~/Views/PcComponent/List.cshtml", new PcComponentsListViewModel { PcComponents = pcComponents, CurrentCategory = "All components" });
        }

        public ViewResult Details(int pcComponentId)
        {
            var pcComponent = _pcComponentRepository.PcComponents.FirstOrDefault(i => i.PcComponentId == pcComponentId);
            if (pcComponent == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(pcComponent);
        }

    }
}
