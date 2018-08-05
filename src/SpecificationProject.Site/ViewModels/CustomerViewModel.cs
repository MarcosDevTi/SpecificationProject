using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SpecificationProject.Domain;
using SpecificationProject.Domain.AutoMapper;

namespace SpecificationProject.Site.ViewModels
{
    public class CustomerViewModel : IMapperConfig
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public void Map(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Customer, CustomerViewModel>()
                .ForMember(x => x.Name, opt => opt.MapFrom(s => s.FirstName + s.LastName));
        }
    }
}
