using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class cards
{
    [JsonProperty("cvv")]
    public int cvv { get; set; }

    [JsonProperty("issuer")]
    public string issuer { get; set; }

    [JsonProperty("number")]
    public string number { get; set; }

    [JsonProperty("expiration")]
    public DateTime expiration { get; set; }

    [JsonProperty("brand")]
    public string brand { get; set; }

    [JsonProperty("number_alt")]
    public string numberalt { get; set; }

}

public class address
{
    [JsonProperty("street")]
    public string street { get; set; }

    [JsonProperty("city")]
    public string city { get; set; }

    [JsonProperty("state")]
    public string state { get; set; }

    [JsonProperty("zipCode")]
    public string zipCode { get; set; }

}

public class owner
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("address")]
    public address address { get; set; }

}

public class data
{
    [JsonProperty("brand")]
    public string brand { get; set; }

    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("cards")]
    public cards[] cards { get; set; }

    [JsonProperty("owner")]
    public owner owner { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
