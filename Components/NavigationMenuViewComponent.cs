﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Assignment_1.Models;

namespace Assignment_1.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        
        private IStoreRepository repository;
        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
        
    }
}