using System.Collections.Generic;
using Jawad.Core.Domains;
using Jawad.Service.Brewers.Commands;
using Jawad.Service.Brewers.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Jawad.Web.Controllers
{
    [Route("api")]
    [ApiController]
    public class BrewersController : ControllerBase
    {
        private readonly IBrewerService _brewerService;

        public BrewersController(IBrewerService brewerService)
        {
            _brewerService = brewerService;
        }

        [HttpGet]
        [Route("brewers")]
        public ActionResult<IEnumerable<Brewer>> GetAll()
        {
            var brewers = _brewerService.GetAll();
            return Ok(brewers);
        }

        [HttpGet]
        [Route("brewers/{id}")]
        public ActionResult<IEnumerable<Brewer>> GetOne(int id)
        {
            var brewer = _brewerService.GetOne(id);
            return Ok(brewer);
        }

        [HttpPost]
        [Route("brewers")]
        public ActionResult<Brewer> Create(CreateBrewerCommand command)
        {
            var brewer = _brewerService.Create(command);
            return Ok(brewer);
        }
    }
}