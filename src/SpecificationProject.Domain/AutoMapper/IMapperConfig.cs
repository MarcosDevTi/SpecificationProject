using AutoMapper;

namespace SpecificationProject.Domain.AutoMapper
{
    public interface IMapperConfig
    {
        void Map(IMapperConfigurationExpression cfg);
    }
}
