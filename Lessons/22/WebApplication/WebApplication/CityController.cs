using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication
{
    public class City
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTimeOffset DateTime { get; set; }
        public int Population { get; set; }
        public City()
        {
        }

        public City(string title, DateTimeOffset dateTime, int population)
        {
            Id = Guid.NewGuid();
            Title = title;
            DateTime = dateTime;
            Population = population;
        }
    }

    public class Storage
    {
        private static Storage _intence;
        public static Storage Intance => _intence ??= new Storage();

        public List<City> Items { get; } = new List<City>
        {
            new City ("Moscow", DateTimeOffset.Parse("1147.02.03"),16_000_000),
            new City ("Saint Petersburg", DateTimeOffset.Parse("1703.02.03"),4_000_000)
        };
    }
    
    [Route("/api/cities")]
    public class CityController : ControllerBase
    {
        [HttpGet]
        public IActionResult List()
        {
            return Ok(Storage.Intance);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var item = Storage.Intance.Items.FirstOrDefault(_ => _.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }


        /*[HttpPost]
        public IActionResult Create()
        {
            //Create city and item 
        }*/
    }
}
