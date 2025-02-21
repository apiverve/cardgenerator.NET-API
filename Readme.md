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
3. Click on Manage NuGet Packages..
4. Click on the Browse tab and search for "APIVerve.API.CardGenerator".
5. Click on the APIVerve.API.CardGenerator package, click Install.


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
        "cvv": 186,
        "issuer": "COOPERATIVE EMPLOYEE'S C.U.",
        "number": "4373147897184685",
        "expiration": "2030-02-20T21:29:17.166Z",
        "brand": "visa",
        "number_alt": "4373 1478 9718 4685"
      },
      {
        "cvv": 428,
        "issuer": "SCOTIABANK DE COSTA RICA, S.A.",
        "number": "4411783532951999",
        "expiration": "2030-02-20T21:29:17.176Z",
        "brand": "visa",
        "number_alt": "4411 7835 3295 1999"
      },
      {
        "cvv": 389,
        "issuer": "MBNA AMERICA BANK, N.A.",
        "number": "4607118472526663",
        "expiration": "2030-02-20T21:29:17.179Z",
        "brand": "visa",
        "number_alt": "4607 1184 7252 6663"
      },
      {
        "cvv": 751,
        "issuer": "ING BANK (AUSTRALIA), LTD.",
        "number": "4622635158951106",
        "expiration": "2030-02-20T21:29:17.181Z",
        "brand": "visa",
        "number_alt": "4622 6351 5895 1106"
      },
      {
        "cvv": 600,
        "issuer": "EVANSVILLE TEACHERS F.C.U.",
        "number": "4690679884272137",
        "expiration": "2030-02-20T21:29:17.184Z",
        "brand": "visa",
        "number_alt": "4690 6798 8427 2137"
      }
    ],
    "owner": {
      "name": "Hugo Batz",
      "address": {
        "street": "2335 Augusta Vista",
        "city": "Zboncakside",
        "state": "New Hampshire",
        "zipCode": "11458"
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

Copyright (&copy;) 2025 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.