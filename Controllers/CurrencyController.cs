using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConverter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        // // GET api/currency
        // [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        // GET api/currency
        [HttpGet]
        public ActionResult<List<Currency>> Get()
        {
            List<Currency> currencyList = CurrencyService.GetCurrencyList();
            return (currencyList);
        }

        // GET api/currency/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/currency
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/currency/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/currency/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
