using System.Collections;
using System.Collections.Generic;
using Jawad.Core.Domains;
using Jawad.Service.Beers.Services.Interfaces;
using Jawad.Service.Brewers.Commands;
using Jawad.Service.Brewers.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Jawad.Web.Controllers
{
    public class BrewersController : Controller
    {
        private readonly IBrewerService _brewerService;

        public BrewersController(IBrewerService brewerService)
        {
            _brewerService = brewerService;
        }

        [Route("brewers")]
        [HttpGet]
        public ActionResult<IEnumerable<Brewer>> GetAll()
        {
            var brewers = _brewerService.GetAll();

            return Ok(brewers);
        }

        [Route("brewers")]
        [HttpPost]
        public ActionResult<Brewer> Create(CreateBrewerCommand command)
        {
            var brewer = _brewerService.Create(command);
            return Ok(brewer);
        }
    }
}