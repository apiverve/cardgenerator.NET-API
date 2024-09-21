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
        "cvv": 379,
        "issuer": "BENSENVILLE COMMUNITY C.U.",
        "number": "4476094366847366",
        "expiration": "2029-09-01T09:27:23.332Z",
        "brand": "visa",
        "number_alt": "4476 0943 6684 7366"
      },
      {
        "cvv": 990,
        "issuer": "FIRST NATIONAL BANK AND TRUST COMPANY",
        "number": "4454093186848436",
        "expiration": "2029-09-01T09:27:23.336Z",
        "brand": "visa",
        "number_alt": "4454 0931 8684 8436"
      },
      {
        "cvv": 499,
        "issuer": "MOUNTAIN VALLEY BANK, N.A.",
        "number": "4869307661362617",
        "expiration": "2029-09-01T09:27:23.338Z",
        "brand": "visa",
        "number_alt": "4869 3076 6136 2617"
      },
      {
        "cvv": 123,
        "issuer": "BOC CREDIT CARD (INTERNATIONAL), LTD.",
        "number": "4336478909204179",
        "expiration": "2029-09-01T09:27:23.34Z",
        "brand": "visa",
        "number_alt": "4336 4789 0920 4179"
      },
      {
        "cvv": 176,
        "issuer": "FOUNDATION BANK",
        "number": "4080598892262831",
        "expiration": "2029-09-01T09:27:23.343Z",
        "brand": "visa",
        "number_alt": "4080 5988 9226 2831"
      }
    ],
    "owner": {
      "name": "June Marks",
      "address": {
        "street": "46303 Schmitt Flats",
        "city": "North Frida",
        "state": "Arkansas",
        "zipCode": "53481-0640"
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