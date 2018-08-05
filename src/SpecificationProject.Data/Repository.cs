using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AutoMapper.QueryableExtensions;
using SpecificationProject.Domain;
using SpecificationProject.Domain.Repositories;
using SpecificationProject.Domain.Specification;

namespace SpecificationProject.Data
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly SpecificationProjectContext _context;

        protected Repository(SpecificationProjectContext context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll(Specification<T> spec)
        {
            return _context.Set<T>().Where(spec.ToExpression()).ToList();
        }

        public IEnumerable<TViewModel> GetAll<TViewModel>(Specification<T> spec)
        {
            return _context.Set<T>().Where(spec.ToExpression()).ProjectTo<TViewModel>().ToList();
        }
    }
}
