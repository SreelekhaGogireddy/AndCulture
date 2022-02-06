using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AndCultureCodingChallenge.Core.Models
{
    public static class RequestResponseFactory
    {
        public static JsonResult CreateSuccessfulResponse(object data)
        {
            return new JsonResult(new RequestResponse
            {
                Status = StatusCodes.Status200OK,
                Data = data
            });
        }
        public static JsonResult CreateErrorResponse(string error, int status = StatusCodes.Status500InternalServerError)
        {
            return new JsonResult(new RequestResponse
            {
                Status = status,
                Error = error
            });
        }
        //public static JsonResult CreateValidationResponse(string error, int status = StatusCodes.Status400BadRequest)
        //{
        //    return new JsonResult(new ModelValidationResponse
        //    {
        //        Status = status,
        //        Error = error
        //    });
        //}
    }
}
