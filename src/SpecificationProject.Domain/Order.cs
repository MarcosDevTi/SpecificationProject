using System;
using System.Collections.Generic;
using System.Text;

namespace SpecificationProject.Domain
{
    public class Order
    {
        public Order(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; private set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public Customer Customer { get; set; }
    }
}
