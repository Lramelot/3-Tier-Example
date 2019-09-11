using Jawad.Core.Domains;
using Jawad.Service.Beers.Commands;
using Jawad.Service.Beers.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Jawad.Web.Controllers
{
    public class BeersController : Controller
    {
        private readonly IBeerService _beerService;

        public BeersController(IBeerService beerService)
        {
            _beerService = beerService;
        }

        [Route("brewers/{id}/beers")]
        [HttpPost]
        public ActionResult<Beer> CreateBeer([FromRoute] int id, [FromBody] CreateBeerCommand command)
        {
            command.BrewerId = id;

            var createdBeer = _beerService.CreateBeer(command);

            return Ok(createdBeer);
        }
    }
}