using System;
using System.Collections.Generic;
using System.Text;

namespace SpecificationProject.Domain
{
    public class Customer
    {
        public Customer(Guid id, string firstName, string lastName, string email, DateTime birthDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
        }

        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public ICollection<Order> Orders { get; set; }
    }
}
