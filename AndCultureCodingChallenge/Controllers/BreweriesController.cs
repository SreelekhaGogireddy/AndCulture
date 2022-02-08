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

        /// <summary>
        /// Get Breweries based on city passed
        /// </summary>
        [HttpGet]
        public async Task<JsonResult> GetBreweries(string city)
        {
            JsonResult response;

            try
            {
                response = await _breweriesService.GetBreweries(city);
            }
            catch(Exception ex)
            {
                //Log exception("Failed to get Breweries List:{BreweriesController}{GetBreweries}");
                response = RequestResponseFactory.CreateErrorResponse(ex.Message);
            }
            return response;
        }
    }
}
