using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Numberalt data
    /// </summary>
    public class Numberalt
    {
        [JsonProperty("masked")]
        public string Masked { get; set; }

        [JsonProperty("unmasked")]
        public string Unmasked { get; set; }

        [JsonProperty("last4")]
        public string Last4 { get; set; }

    }
    /// <summary>
    /// Cards data
    /// </summary>
    public class Cards
    {
        [JsonProperty("cvv")]
        public int Cvv { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("number_alt")]
        public Numberalt Numberalt { get; set; }

    }
    /// <summary>
    /// Address data
    /// </summary>
    public class Address
    {
        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

    }
    /// <summary>
    /// Owner data
    /// </summary>
    public class Owner
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("cards")]
        public Cards[] Cards { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
