using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using AutoMapper;
using DemoProj.Data.Entities;
using DemoProj.Data.Repositories;
using DemoProj.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace DemoProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IRepository<Person> _personRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;

        public PersonController
            (
                IRepository<Person> personRepository,
                IWebHostEnvironment webHostEnvironment,
                IMapper mapper
            )
        {
            _personRepository = personRepository;
            _webHostEnvironment = webHostEnvironment;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<PersonModel[]>> Get()
        {
            try
            {
                var data = await _personRepository.All();
                var result = _mapper.Map<PersonModel[]>(data);

                return result;
            }
            catch (Exception ex)
            {
                if (_webHostEnvironment.IsDevelopment())
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, "Database failure");
            }
        }

        [HttpPost]
        public async Task<ActionResult<PersonModel>> Post(PersonModel model)
        {
            try
            {
                var existing = await _personRepository.GetByProperty(p => p.Egn == model.Egn);

                if (existing is not null)
                {
                    return BadRequest("Person already exists");
                }

                var person = _mapper.Map<Person>(model);

                var result = await _personRepository.Add(person);

                return model;
            }
            catch (Exception ex)
            {
                if (_webHostEnvironment.IsDevelopment())
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex);
                }
                return StatusCode(StatusCodes.Status500InternalServerError, "Database failure");
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var person = await _personRepository.GetByProperty(p => p.Id == id);

                await _personRepository.Delete(person);

                return Ok($"Person with id {id} deleted successfully.");
            }
            catch (Exception ex)
            {
                if (_webHostEnvironment.IsDevelopment())
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, ex);
                }

                return StatusCode(StatusCodes.Status500InternalServerError, "Database failure");
            }
        }
    }
}
