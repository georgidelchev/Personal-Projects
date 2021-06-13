using AutoMapper;
using DemoProj.Data.Entities;
using DemoProj.Models;

namespace DemoProj.Data.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonModel>();

            CreateMap<PersonModel, Person>()
                .ForMember(m => m.Id, src => src.Ignore());
        }
    }
}