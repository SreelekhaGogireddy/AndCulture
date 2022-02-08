using AndCultureCodingChallenge.Core.Models;
using AndCultureCodingChallenge.Infrastrcture.Repositories.Interfaces;
using AndCultureCodingChallenge.Infrastrcture.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
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

        public async Task<JsonResult> GetBreweries(string city)
        {
            try
            {
                var breweriesList = await _breweriesRepository.GetBreweries();
                var filteredList = string.IsNullOrEmpty(city) ? breweriesList : breweriesList.Where(s => s.City == city);
                return RequestResponseFactory.CreateSuccessfulResponse(filteredList);
            }
            catch
            {
                //Log exception("Failed to get Breweries List:{BreweriesService}{GetBreweries} ex");
                throw new Exception("Failed to get Breweries List");
            }
        }
    }
}
