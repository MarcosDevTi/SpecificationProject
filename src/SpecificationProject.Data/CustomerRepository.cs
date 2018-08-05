using System;
using System.Collections.Generic;
using System.Text;
using SpecificationProject.Domain;
using SpecificationProject.Domain.Repositories;
using SpecificationProject.Domain.Specification;

namespace SpecificationProject.Data
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SpecificationProjectContext context) : base(context)
        {
        }
    }
}
