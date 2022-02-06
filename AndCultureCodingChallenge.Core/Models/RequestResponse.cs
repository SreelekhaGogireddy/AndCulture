using Newtonsoft.Json;

namespace AndCultureCodingChallenge.Core.Models
{
    public class RequestResponse
    {
        public RequestResponse()
        {
            Data = string.Empty;
            ValidationMessage = string.Empty;
            Error = string.Empty;
        }
        public int Status { get; set; }
        public object Data { get; set; }
        public string ValidationMessage { get; set; }
        public string Error { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}