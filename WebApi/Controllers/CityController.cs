using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly DataContext dc;
        public CityController(DataContext dc)
        {
            this.dc = dc;

        }

        [HttpGet]
        public async Task<IActionResult> GetCities()
        {
           var cities = await dc.Cities.ToListAsync();
           return Ok(cities);
        }

        // Post api/city/add?cityname = Miami
        // Post api/city/add/Los Angeles
        [HttpPost("add")]
        [HttpPost("add{cityName}")]
        public async Task<IActionResult> AddCity(string cityName)
        {
           var city = new City();
           city.Name = cityName;
           
           await dc.Cities.AddAsync(city);
           await dc.SaveChangesAsync();
           return Ok(city);
        //    return Created()
        }

        [HttpGet("{id}")]
        public string Get(string id)
        {
            return "New York";
        }
    }
}
