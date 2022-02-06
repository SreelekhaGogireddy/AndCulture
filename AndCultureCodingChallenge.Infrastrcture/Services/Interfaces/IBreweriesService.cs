using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AndCultureCodingChallenge.Infrastrcture.Services.Interfaces
{
    public interface IBreweriesService
    {
        Task<JsonResult> GetBreweries();
    }
}
