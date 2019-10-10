using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        // GET api/currency
        // Return List of Supported Currencies
        /* 
            {
                "USD": {
                    "currencyCode": "USD",
                    "currencyNum": 840,
                    "currencyName": "United States Dollar"
                },
                ...
            }
         */
        [HttpGet]
        public ActionResult<Dictionary<string, Currency>> Get()
        {
            var currencies = CurrencyService.GetCurrencies();
            if (currencies == null) return NotFound("404 Error (Not Found): List of Supported Currencies could not be retrieved.");
            return (currencies);
        }

        // GET api/currency/usd
        // Return Currency Info
        /*
            {
                "currencyCode": "USD",
                "currencyNum": 840,
                "currencyName": "United States Dollar"
            }
         */
        [HttpGet("{code}")]
        public ActionResult<Currency> Get(string code)
        {
            if (code.Length != 3) return BadRequest($"400 Error (Bad Request): Currency Code \"{code}\" not valid.");
            code =code.ToUpper();
            var currencies = CurrencyService.GetCurrencies();
            if (currencies.ContainsKey(code)) {
                var currency = currencies[code];
                return currency;
            } else {
                return NotFound($"404 Error (Not Found): Currency Code \"{code}\" could not be found.");
            }
        }

        // GET api/currency/usd/eur
        // Return Conversion Rate (1 unit of code1 is equal to _ units of code2)
        [HttpGet("{code1}/{code2}/{num}")]
        public ActionResult<double> Get(string code1, string code2, int num)
        {
            if (code1.Length != 3) return BadRequest($"400 Error (Bad Request): Currency Code \"{code1}\" not valid.");
            if (code2.Length != 3) return BadRequest($"400 Error (Bad Request): Currency Code \"{code2}\" not valid.");
            if (num < 0 || num > 15) return BadRequest("400 Error (Bad Request): Precision must be from 0 to 15.");
            code1 =code1.ToUpper();
            code2 =code2.ToUpper();
            var currencies = CurrencyService.GetCurrencies();
            if (currencies.ContainsKey(code1) && currencies.ContainsKey(code2)) {
                var currency1 = currencies[code1];
                var currency2 = currencies[code2];
                double exchange = CurrencyService.ExchangeRate(currency1, currency2);
                if (exchange == 0) return NotFound("404 Error (Not Found): Currency Conversion Rate could not be found.");
                exchange = Math.Round(exchange, num);
                return exchange;
            } else if (currencies.ContainsKey(code1) && !currencies.ContainsKey(code2)){
                return NotFound($"404 Error (Not Found): Currency Code \"{code2}\" could not be found.");
            } else if (!currencies.ContainsKey(code1) && currencies.ContainsKey(code2)){
                return NotFound($"404 Error (Not Found): Currency Code \"{code1}\" could not be found.");
            } else {
                return NotFound($"404 Error (Not Found): Currency Code \"{code1}\" & \"{code2}\" could not be found.");
            }
        }
    }
}
