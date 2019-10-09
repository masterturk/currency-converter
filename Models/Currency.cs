using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CurrencyConverter
{
    public class Currency
    {
        public string CurrencyCode { get; set; }
        public int CurrencyNum { get; set; }
        public string CurrencyName { get; set; }
        
        // Constructor
        public Currency()
        {
            this.CurrencyCode = null;
            this.CurrencyNum = 000;
            this.CurrencyName = null;
        }

        // Overloaded Constructor
        public Currency(string currencyCode, int currencyNum, string currencyName)
        {
            this.CurrencyCode = currencyCode;
            this.CurrencyNum = currencyNum;
            this.CurrencyName = currencyName;
        }
    }
}
