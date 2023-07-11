Application
1. Visual Studio

Framework Used
- .NET 6.0 (Long Term Support)

Project Type
- NUnit Test Project

Packages Used
- Selenium.WebDriver
- NUnit
- RestSharp
- Newtonsoft.Json

How to use
1.  Open Visual Studio and Click Clone a repository
2. Insert https://github.com/madbon/RestShartNunitTestApi.git to repository location
3. Click Clone button
4. Click Test Menu > Run All Tests

API Source:
- https://automationexercise.com/api/brandsList
- https://automationexercise.com/api/


Available Tests
- TestGet: return All Brands
- SearchProductTest: Search and return tshirt products using Post Method

API RESULTS:

- API 5

{
  "json_obj": {
    "responseCode": 200,
    "products": [
      {
        "id": 2,
        "name": "Men Tshirt",
        "price": "Rs. 400",
        "brand": "H&M",
        "category": {
          "usertype": {
            "usertype": "Men"
          },
          "category": "Tshirts"
        }
      },
      {
        "id": 28,
        "name": "Pure Cotton V-Neck T-Shirt",
        "price": "Rs. 1299",
        "brand": "H&M",
        "category": {
          "usertype": {
            "usertype": "Men"
          },
          "category": "Tshirts"
        }
      },
      {
        "id": 29,
        "name": "Green Side Placket Detail T-Shirt",
        "price": "Rs. 1000",
        "brand": "Polo",
        "category": {
          "usertype": {
            "usertype": "Men"
          },
          "category": "Tshirts"
        }
      },
      {
        "id": 30,
        "name": "Premium Polo T-Shirts",
        "price": "Rs. 1500",
        "brand": "Polo",
        "category": {
          "usertype": {
            "usertype": "Men"
          },
          "category": "Tshirts"
        }
      },
      {
        "id": 31,
        "name": "Pure Cotton Neon Green Tshirt",
        "price": "Rs. 850",
        "brand": "H&M",
        "category": {
          "usertype": {
            "usertype": "Men"
          },
          "category": "Tshirts"
        }
      },
      {
        "id": 43,
        "name": "GRAPHIC DESIGN MEN T SHIRT - BLUE",
        "price": "Rs. 1389",
        "brand": "Mast & Harbour",
        "category": {
          "usertype": {
            "usertype": "Men"
          },
          "category": "Tshirts"
        }
      }
    ]
  },





