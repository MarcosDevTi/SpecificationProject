using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpecificationProject.Domain.Repositories;

namespace SpecificationProject.Site.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            //_productRepository.GetAll()
            return View();
        }
    }
}