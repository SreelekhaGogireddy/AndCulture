using AndCultureCodingChallenge.Core.Models;
using AndCultureCodingChallenge.Infrastrcture.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Threading.Tasks;

namespace AndCultureCodingChallenge.Controllers
{
    [ApiController]
    [Route("/api/[Controller]/[action]")]
    public class BreweriesController : ControllerBase
    {
        private IBreweriesService _breweriesService;
        public BreweriesController(IBreweriesService breweriesService)
        {
            _breweriesService = breweriesService;
        }
        [HttpGet]
        public async Task<JsonResult> GetBreweries()
        {
            JsonResult response;

            try
            {
                response = await _breweriesService.GetBreweries();
            }
            catch(Exception ex)
            {
                response = RequestResponseFactory.CreateErrorResponse(ex.Message);
            }
            return response;
        }
    }
}
