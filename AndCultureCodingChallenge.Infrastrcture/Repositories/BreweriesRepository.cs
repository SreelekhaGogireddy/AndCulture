using AndCultureCodingChallenge.Core.Models;
using AndCultureCodingChallenge.Infrastrcture.Clients.Interfaces;
using AndCultureCodingChallenge.Infrastrcture.Repositories.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

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
           var response=await _breweriesClient.GetBreweries();
            return response;
        }
    }
}
