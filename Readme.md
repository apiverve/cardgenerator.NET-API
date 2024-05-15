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
var queryOptions = new cardgeneratorQueryOptions {
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
    var jsonResponse = JsonConvert.SerializeObject(response.data, Newtonsoft.Json.Formatting.Indented);
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
        "cvv": 157,
        "issuer": "BANCORP BANK",
        "number": "4267563564424775",
        "expiration": "2029-05-13T03:31:14.312Z",
        "brand": "visa",
        "number_alt": "4267 5635 6442 4775"
      },
      {
        "cvv": 701,
        "issuer": "ALTIER C.U.",
        "number": "4756354919210087",
        "expiration": "2029-05-13T03:31:14.315Z",
        "brand": "visa",
        "number_alt": "4756 3549 1921 0087"
      },
      {
        "cvv": 909,
        "issuer": "UNION BANK OF THE PHILIPPINES",
        "number": "4588247072155889",
        "expiration": "2029-05-13T03:31:14.318Z",
        "brand": "visa",
        "number_alt": "4588 2470 7215 5889"
      },
      {
        "cvv": 746,
        "issuer": "WELLS FARGO BANK, N.A.",
        "number": "4269604751957306",
        "expiration": "2029-05-13T03:31:14.32Z",
        "brand": "visa",
        "number_alt": "4269 6047 5195 7306"
      },
      {
        "cvv": 959,
        "issuer": "RAIFFEISENBANK (BULGARIA) EAD",
        "number": "4321781342457214",
        "expiration": "2029-05-13T03:31:14.322Z",
        "brand": "visa",
        "number_alt": "4321 7813 4245 7214"
      }
    ],
    "owner": {
      "name": "Walter Tillman",
      "address": {
        "street": "5280 Hartmann Plaza",
        "city": "East Feliciaberg",
        "state": "New Hampshire",
        "zipCode": "88590"
      }
    }
  }
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