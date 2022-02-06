using AndCultureCodingChallenge.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AndCultureCodingChallenge.Infrastrcture.Clients.Interfaces
{
    public interface IBreweriesClient
    {
        Task<List<BreweriesResponse>> GetBreweries();
    }
}
