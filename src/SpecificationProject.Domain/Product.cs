using System;
using System.Collections.Generic;
using System.Text;

namespace SpecificationProject.Domain
{
    public class Product
    {
        public Product(Guid id, string name, string description, decimal price, bool inStock)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            InStock = inStock;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public bool InStock { get; private set; }
    }
}
