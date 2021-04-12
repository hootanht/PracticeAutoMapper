using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PracticeAutoMapper.Models;
using PracticeAutoMapper.ViewModels;

namespace PracticeAutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly IMapper _mapper;
        public SampleController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //Initial Person =>
            Person person = new Person()
            {
                Age = 24,
                Name = "hootan",
                Family = "ht"
            };

            PersonViewModel personViewModel = _mapper.Map<PersonViewModel>(person);

            return Ok(personViewModel.GetInformation());
        }
    }
}
