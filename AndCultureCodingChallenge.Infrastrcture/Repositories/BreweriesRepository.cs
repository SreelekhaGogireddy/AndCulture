using AndCultureCodingChallenge.Core.Models;
using AndCultureCodingChallenge.Infrastrcture.Clients.Interfaces;
using AndCultureCodingChallenge.Infrastrcture.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AndCultureCodingChallenge.Infrastrcture.Repositories
{
    public class BreweriesRepository : IBreweriesRepository
    {
        private IBreweriesClient _breweriesClient;
        public BreweriesRepository(IBreweriesClient breweriesClient)
        {
            _breweriesClient = breweriesClient;
        }

        public async Task<List<BreweriesResponse>> GetBreweries()
        {
            try
            {
                var response = await _breweriesClient.GetBreweries();
                return response;
            }
            catch(Exception ex)
            {
                //Log exception("Failed to get Breweries List:{BreweriesRepository}{GetBreweries} ex");
                throw new Exception("Failed to get Breweries List");
            }
        }
    }
}
