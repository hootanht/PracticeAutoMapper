using PracticeAutoMapper.Models;
using PracticeAutoMapper.ViewModels;

namespace PracticeAutoMapper.AutoMapperProfiles
{
    public class PersonProfile : AutoMapper.Profile
    {
        public PersonProfile()
        {
            CreateMap<PersonViewModel, Person>();
            CreateMap<Person, PersonViewModel>()
                .ForMember(pv => pv.FullName,
                option =>
                option.MapFrom(p => $"I'm {p.Name} {p.Family} and {p.Age} years old."));
        }
    }
}
