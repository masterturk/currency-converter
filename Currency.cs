namespace CurrencyConverter
{
    class Currency
    {
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }


        public Currency() 
        {
            this.CurrencyCode = null;
            this.CurrencyName = null;
        }

        public Currency(string currencyCode, string currencyName) 
        {
            this.CurrencyCode = currencyCode;
            this.CurrencyName = currencyName;
        }
    }
}