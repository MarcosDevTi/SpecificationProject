using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SpecificationProject.Domain.Specification.Models
{
    public class CustomersGreaterThan18Years : Specification<Customer>
    {
        public override Expression<Func<Customer, bool>> ToExpression() =>
            c => c.BirthDate.Year <= -18;
    }
}
