using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeerFlightApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BeerFlightApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        [Route("GetAddedBreweries")]
        [HttpGet]
        public IActionResult GetAddedBreweries()
        {
            List<Brewery> Breweries = new List<Brewery>()
            {
                new Brewery()
                {
                    Id = 0,
                    Name = "Great Divide Brewing Co.",
                    Type = "marker",
                    Coords = new List<double> { 39.753837, -104.988581 },
                    Beers = GetBeers("Great Divide Brewing Co.")
                }
            };


            return Ok(JsonConvert.SerializeObject(Breweries));
        }


        // POST api/<controller>
        [Route("AddNewBrewery")]
        [HttpPost]
        public IActionResult AddNewBrewery([FromQuery]string name, [FromQuery]string address)
        {
            //Utilize Mapbox geolocation

            List<string> coords = new List<string>();

            return Ok(coords);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public List<Beer> GetBeers(string breweryName)
        {
            List<Beer> beers = new List<Beer>()
            {
                new Beer()
                {
                    Id = 0,
                    Name = "Titan IPA",
                    IBU = 77,
                    AlcoholContent = "6.8%"
                },
                new Beer()
                {
                    Id = 1,
                    Name = "Some Beer",
                    IBU = 33,
                    AlcoholContent = "4.2%"
                }
            };

            return beers;
        }
    }
}