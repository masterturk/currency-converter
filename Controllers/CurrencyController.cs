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
            if (currencies == null) return NotFound();
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
            if (code.Length != 3) return BadRequest();
            code =code.ToUpper();
            var currencies = CurrencyService.GetCurrencies();
            if (currencies.ContainsKey(code)) {
                var currency = currencies[code];
                return currency;
            } else {
                return NotFound();
            }
        }

        // GET api/currency/usd/eur
        // Return Conversion Rate (1 unit of code1 is equal to _ units of code2)
        [HttpGet("{code1}/{code2}/{num}")]
        public ActionResult<double> Get(string code1, string code2, int num)
        {
            if (code2.Length != 3) return BadRequest();
            if (code2.Length != 3) return BadRequest();
            code1 =code1.ToUpper();
            code2 =code2.ToUpper();
            var currencies = CurrencyService.GetCurrencies();
            if (currencies.ContainsKey(code1) && currencies.ContainsKey(code2)) {
                var currency1 = currencies[code1];
                var currency2 = currencies[code2];
                double exchange = CurrencyService.ExchangeRate(currency1, currency2);
                if (exchange == 0) return NotFound();
                exchange = Math.Round(exchange, num);
                return exchange;
            } else {
                return NotFound();
            }
        }
    }
}
