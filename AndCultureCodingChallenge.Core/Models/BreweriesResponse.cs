using System;

namespace AndCultureCodingChallenge.Core.Models
{
    public class BreweriesResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Brewery_type { get; set; }
        public string Street { get; set; }
        public string Address_2 { get; set; }
        public string Address_3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County_province { get; set; }
        public string Postal_code { get; set; }
        public string Country { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string Phone { get; set; }
        public string Website_url { get; set; }
        public DateTime Updated_at { get; set; }
        public DateTime Created_at { get; set; }
    }
}