using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpecificationProject.Domain;
using SpecificationProject.Domain.Repositories;
using SpecificationProject.Domain.Specification.Models;

namespace SpecificationProject.Site.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IRepository<Customer> _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IActionResult Index()
        {
            var customers = _customerRepository.GetAll(
                new CustomersGreaterThan18Years()
                    .And(new EspecialCustomer()));
            return View(customers);
        }
    }
}