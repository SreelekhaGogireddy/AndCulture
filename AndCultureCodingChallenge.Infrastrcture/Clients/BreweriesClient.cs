using AndCultureCodingChallenge.Core.Models;
using AndCultureCodingChallenge.Infrastrcture.Clients.Interfaces;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace AndCultureCodingChallenge.Infrastrcture.Clients
{
    public class BreweriesClient : IBreweriesClient
    {
        private HttpClient _client;
        private readonly ILogger _logger;
        public BreweriesClient(HttpClient client, ILogger logger)
        {
            _client = client;
            _logger = logger;
        }

        public async Task<List<BreweriesResponse>> GetBreweries()
        {
            var breweriesResponse = new List<BreweriesResponse>();
            try
            {
                var uriBuilder = new UriBuilder("https://api.openbrewerydb.org/breweries");
                var query = HttpUtility.ParseQueryString(uriBuilder.Query);
                uriBuilder.Query = query.ToString();
                var response = await _client.GetAsync(uriBuilder.Uri.ToString());
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                     breweriesResponse = JsonConvert.DeserializeObject<List<BreweriesResponse>>(result);
                }
            }
            catch(Exception ex)
            {
                _logger.LogError($"Exceptio:{ex} Class:BreweriesClient Method:GetBreweries");
                throw new Exception("Failed to get Breweries List");
            }

            return breweriesResponse;
        }
    }
}
