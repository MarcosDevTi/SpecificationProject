using SpecificationProject.Domain.Specification;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SpecificationProject.Domain.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll(Specification<T> spec);
        IEnumerable<TViewModel> GetAll<TViewModel>(Specification<T> spec);
    }
}
