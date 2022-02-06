using AndCultureCodingChallenge.Core.Models;
using AndCultureCodingChallenge.Infrastrcture.Repositories.Interfaces;
using AndCultureCodingChallenge.Infrastrcture.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AndCultureCodingChallenge.Infrastrcture.Services
{
    public class BreweriesService : IBreweriesService
    {
        private IBreweriesRepository _breweriesRepository;
        public BreweriesService(IBreweriesRepository breweriesRepository)
        {
            _breweriesRepository = breweriesRepository;
        }

        public async Task<JsonResult> GetBreweries()
        {
            try
            {
                var breweriesList = await _breweriesRepository.GetBreweries();
                return RequestResponseFactory.CreateSuccessfulResponse(breweriesList);
            }
            catch
            {
                throw new Exception("Failed to get Breweries List:{BreweriesService}{GetBreweries}");
            }
        }
    }
}
