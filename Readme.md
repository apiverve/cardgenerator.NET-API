Card Generator API
============

Card Generator is a simple tool for generating test/sample card numbers. It returns a list of card numbers for testing.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a .NET Wrapper for the [Card Generator API](https://apiverve.com/marketplace/api/cardgenerator)

---

## Installation

Using the .NET CLI:
```
dotnet add package APIVerve.API.CardGenerator
```

Using the Package Manager:
```
nuget install APIVerve.API.CardGenerator
```

Using the Package Manager Console:
```
Install-Package APIVerve.API.CardGenerator
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on Manage NuGet Packages...
4. Click on the Browse tab and search for "APIVerve.API.CardGenerator".
5. Click on the APIVerve.API.CardGenerator package, select the appropriate version in the right-tab and click Install.


---

## Configuration

Before using the cardgenerator API client, you have to setup your account and obtain your API Key.  
You can get it by signing up at [https://apiverve.com](https://apiverve.com)

---

## Usage

The Card Generator API documentation is found here: [https://docs.apiverve.com/api/cardgenerator](https://docs.apiverve.com/api/cardgenerator).  
You can find parameters, example responses, and status codes documented here.

### Setup

###### Authentication
Card Generator API uses API Key-based authentication. When you create an instance of the API client, you can pass your API Key as a parameter.

```
// Create an instance of the API client
var apiClient = new CardGeneratorAPIClient("[YOUR_API_KEY]", true);
```

---


### Perform Request
Using the API client, you can perform requests to the API.

###### Define Query

```
var queryOptions = new CardGeneratorQueryOptions {
  brand = "visa",
  count = 5
};
```

###### Simple Request

```
var response = apiClient.Execute(queryOptions);
if(response.error != null) {
	Console.WriteLine(response.error);
} else {
    var jsonResponse = JsonConvert.SerializeObject(response, Newtonsoft.Json.Formatting.Indented);
    Console.WriteLine(jsonResponse);
}
```

###### Example Response

```
{
  "status": "ok",
  "error": null,
  "data": {
    "brand": "visa",
    "count": 5,
    "cards": [
      {
        "cvv": 781,
        "issuer": "SWEDBANK AB",
        "number": "4581973945415963",
        "expiration": "2029-08-14T06:13:55.186Z",
        "brand": "visa",
        "number_alt": "4581 9739 4541 5963"
      },
      {
        "cvv": 785,
        "issuer": "CAJA LABORAL POPULAR DE MONDRAGON",
        "number": "4548594469310661",
        "expiration": "2029-08-14T06:13:55.189Z",
        "brand": "visa",
        "number_alt": "4548 5944 6931 0661"
      },
      {
        "cvv": 995,
        "issuer": "JSC KOR STANDARD BANK",
        "number": "4244088464600744",
        "expiration": "2029-08-14T06:13:55.192Z",
        "brand": "visa",
        "number_alt": "4244 0884 6460 0744"
      },
      {
        "cvv": 966,
        "issuer": "NEW WINDSOR STATE BANK",
        "number": "4138171569648237",
        "expiration": "2029-08-14T06:13:55.194Z",
        "brand": "visa",
        "number_alt": "4138 1715 6964 8237"
      },
      {
        "cvv": 693,
        "issuer": "OJSC SOCIAL COMMERCIAL BANK OF PRIMORYE PRIMSOTSBANK",
        "number": "4195798981462852",
        "expiration": "2029-08-14T06:13:55.196Z",
        "brand": "visa",
        "number_alt": "4195 7989 8146 2852"
      }
    ],
    "owner": {
      "name": "Shelly Botsford Sr.",
      "address": {
        "street": "83263 Jones Crescent",
        "city": "Bergeland",
        "state": "Maryland",
        "zipCode": "03258"
      }
    }
  },
  "code": 200
}
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms) and all legal documents and agreements.

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2024 APIVerve, and Evlar LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.