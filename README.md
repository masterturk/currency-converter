# CurrencyConverter
ASP.NET Core web API that provides real time currency conversions <br />
Currently supports 157 currencies <br />

## To Use 
Download/clone repository to desktop
Using preferred CLI
- cd into the repository
- dotnet build
- dotnet run

The api will be available on your ***localhost:5001*** 

Note: the api has a Self Signed Certificate so here is the solution:
  1. If using a web browser, just agree to the warning
  2. If using Postman go to File -> Settings -> SSL Certificate verification -> Off

# Endpoints
**/api/currency/ <br />**
*-> Returns Full Dictionary of Supported Currencies <br />*

**/api/currency/{code} <br />**
*-> Returns Specified Currency Object (example code: USD)<br />*

**/api/currency/{code}/{code}/{num}<br />**
*-> Returns Conversion Rate(example: USD, EUR, 2 (Convert USD to EUR and round the exchange rate to 2 decimals)) <br />*
