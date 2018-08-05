using System;
using System.Collections.Generic;
using System.Text;

namespace SpecificationProject.Domain
{
    public class OrderItem
    {
        public OrderItem(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
        public Product Product { get; set; }
    }
}
