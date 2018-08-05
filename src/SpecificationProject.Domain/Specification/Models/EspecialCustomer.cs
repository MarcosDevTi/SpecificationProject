using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SpecificationProject.Domain.Specification.Models
{
    public class EspecialCustomer : Specification<Customer>
    {
        public override Expression<Func<Customer, bool>> ToExpression()
        {
            return c => c.Orders.Count > 10;
        }
    }
}
