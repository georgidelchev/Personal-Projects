using AutoMapper;

namespace MyLittleGithub.Services.Mapping;

public interface IHaveCustomMappings
{
    void CreateMappings(IProfileExpression configuration);
}
