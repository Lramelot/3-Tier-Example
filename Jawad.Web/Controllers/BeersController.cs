using Jawad.Core.Domains;
using Jawad.Service.Beers.Commands;
using Jawad.Service.Beers.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Jawad.Web.Controllers
{
    [Route("api")]
    [ApiController]
    public class BeersController : ControllerBase
    {
        private readonly IBeerService _beerService;

        public BeersController(IBeerService beerService)
        {
            _beerService = beerService;
        }

        [HttpPost]
        [Route("brewers/{id:int}/beers")]
        public ActionResult<Beer> CreateBeer([FromRoute] int id, [FromBody] CreateBeerCommand command)
        {
            command.BrewerId = id;

            var createdBeer = _beerService.CreateBeer(command);

            return Ok(createdBeer);
        }
    }
}