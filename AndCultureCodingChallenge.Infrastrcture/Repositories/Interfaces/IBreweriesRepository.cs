using AndCultureCodingChallenge.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AndCultureCodingChallenge.Infrastrcture.Repositories.Interfaces
{
    public interface IBreweriesRepository
    {
        Task<List<BreweriesResponse>> GetBreweries();
    }
}
