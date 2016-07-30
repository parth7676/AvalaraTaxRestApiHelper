using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZNode.Libraries.AvalaraTax.Entities
{
    public class AvalaraRequestData
    {
        [JsonIgnore]
        public string EndPointURL { get; set; }
        public string CustomerCode { get; set; }
        public string CompanyCode { get; set; }
        public string DocType { get; set; }
        [JsonIgnore]
        public string key { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public List<Addresses> Addresses = new List<Addresses>();
        public List<Lines> Lines = new List<Lines>();
    }

    public class Addresses
    {
        public string AddressCode { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string TaxRegionId { get; set; }

    }

    public class Lines
    {
        public string LineNo { get; set; }
        public string DestinationCode { get; set; }
        public string OriginCode { get; set; }
        public string ItemCode { get; set; }
        public string TaxCode { get; set; }
        public string CustomerUsageType { get; set; }
        public string BusinessIdentificationNo { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public decimal Amount { get; set; }
        public bool Discounted { get; set; }
        public bool TaxIncluded { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
    }
}
