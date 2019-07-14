using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CurrencyConverter
{
    class Currency
    {
        public string CurrencyCode { get; set; }
        public int    CurrencyNum { get; set; }
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

        
        // Creates a List of all ISO 4217 Currencies
        // From:    https://en.wikipedia.org/wiki/ISO_4217
        public static List<Currency> ISO4217()
        {
            // Currency XUA = new Currency("XUA", 965, "ADB Unit of Account");
            Currency AFN = new Currency("AFN", 971, "Afghan Afghani");
            Currency ALL = new Currency("ALL", 8, "Albanian Lek");
            Currency DZD = new Currency("DZD", 12, "Algerian Dinar");
            Currency AOA = new Currency("AOA", 973, "Angolan Kwanza");
            Currency ARS = new Currency("ARS", 32, "Argentine Peso");
            Currency AMD = new Currency("AMD", 51, "Armenian Dram");
            Currency AWG = new Currency("AWG", 533, "Aruban Florin");
            Currency AUD = new Currency("AUD", 36, "Australian Dollar");
            Currency AZN = new Currency("AZN", 944, "Azerbaijani Manat");
            Currency BSD = new Currency("BSD", 44, "Bahamian Dollar");
            Currency BHD = new Currency("BHD", 48, "Bahraini Dinar");
            Currency BDT = new Currency("BDT", 50, "Bangladeshi Taka");
            Currency BBD = new Currency("BBD", 52, "Barbados Dollar");
            Currency BYN = new Currency("BYN", 933, "Belarusian Ruble");
            Currency BZD = new Currency("BZD", 84, "Belize Dollar");
            Currency BMD = new Currency("BMD", 60, "Bermudian Dollar");
            Currency BTN = new Currency("BTN", 64, "Bhutanese Ngultrum");
            // Currency BOV = new Currency("BOV", 984, "Bolivian Mvdol (funds code)");
            Currency BOB = new Currency("BOB", 68, "Boliviano");
            Currency BAM = new Currency("BAM", 977, "Bosnia and Herzegovina Convertible Mark");
            Currency BWP = new Currency("BWP", 72, "Botswana Pula");
            Currency BRL = new Currency("BRL", 986, "Brazilian Real");
            Currency BND = new Currency("BND", 96, "Brunei Dollar");
            Currency BGN = new Currency("BGN", 975, "Bulgarian Lev");
            Currency BIF = new Currency("BIF", 108, "Burundian Franc");
            Currency KHR = new Currency("KHR", 116, "Cambodian Riel");
            Currency CAD = new Currency("CAD", 124, "Canadian Dollar");
            Currency CVE = new Currency("CVE", 132, "Cape Verdean Escudo");
            Currency KYD = new Currency("KYD", 136, "Cayman Islands Dollar");
            Currency XOF = new Currency("XOF", 952, "CFA Franc BCEAO");
            Currency XAF = new Currency("XAF", 950, "CFA franc BEAC");
            Currency XPF = new Currency("XPF", 953, "CFP Franc (franc Pacifique)");
            Currency CLP = new Currency("CLP", 152, "Chilean Peso");
            // Currency XTS = new Currency("XTS", 963, "Code reserved for testing");
            Currency COP = new Currency("COP", 170, "Colombian Peso");
            Currency KMF = new Currency("KMF", 174, "Comoro Franc");
            Currency CDF = new Currency("CDF", 976, "Congolese Franc");
            Currency CRC = new Currency("CRC", 188, "Costa Rican Colon");
            Currency HRK = new Currency("HRK", 191, "Croatian Kuna");
            Currency CUC = new Currency("CUC", 931, "Cuban Convertible Peso");
            Currency CUP = new Currency("CUP", 192, "Cuban Peso");
            Currency CZK = new Currency("CZK", 203, "Czech Koruna");
            Currency DKK = new Currency("DKK", 208, "Danish Krone");
            Currency DJF = new Currency("DJF", 262, "Djiboutian Franc");
            Currency DOP = new Currency("DOP", 214, "Dominican Peso");
            Currency XCD = new Currency("XCD", 951, "East Caribbean Dollar");
            Currency EGP = new Currency("EGP", 818, "Egyptian Pound");
            Currency ERN = new Currency("ERN", 232, "Eritrean Nakfa");
            Currency ETB = new Currency("ETB", 230, "Ethiopian Birr");
            Currency EUR = new Currency("EUR", 978, "Euro");
            // Currency XBA = new Currency("XBA", 955, "European Composite Unit (EURCO) (bond market unit)");
            // Currency XBB = new Currency("XBB", 956, "European Monetary Unit (E.M.U.-6) (bond market unit)");
            // Currency XBD = new Currency("XBD", 958, "European Unit of Account 17 (E.U.A.-17) (bond market unit)");
            // Currency XBC = new Currency("XBC", 957, "European Unit of Account 9 (E.U.A.-9) (bond market unit)");
            Currency FKP = new Currency("FKP", 238, "Falkland Islands Pound");
            Currency FJD = new Currency("FJD", 242, "Fiji Dollar");
            Currency GMD = new Currency("GMD", 270, "Gambian Dalasi");
            Currency GEL = new Currency("GEL", 981, "Georgian Lari");
            Currency GHS = new Currency("GHS", 936, "Ghanaian Cedi");
            Currency GIP = new Currency("GIP", 292, "Gibraltar Pound");
            Currency XAU = new Currency("XAU", 959, "Gold (one troy ounce)");
            Currency GTQ = new Currency("GTQ", 320, "Guatemalan Quetzal");
            Currency GNF = new Currency("GNF", 324, "Guinean Franc");
            Currency GYD = new Currency("GYD", 328, "Guyanese Dollar");
            Currency HTG = new Currency("HTG", 332, "Haitian Gourde");
            Currency HNL = new Currency("HNL", 340, "Honduran Lempira");
            Currency HKD = new Currency("HKD", 344, "Hong Kong Dollar");
            Currency HUF = new Currency("HUF", 348, "Hungarian Forint");
            Currency ISK = new Currency("ISK", 352, "Icelandic Króna");
            Currency INR = new Currency("INR", 356, "Indian Rupee");
            Currency IDR = new Currency("IDR", 360, "Indonesian Rupiah");
            Currency IRR = new Currency("IRR", 364, "Iranian Rial");
            Currency IQD = new Currency("IQD", 368, "Iraqi Sinar");
            Currency ILS = new Currency("ILS", 376, "Israeli New Shekel");
            Currency JMD = new Currency("JMD", 388, "Jamaican Dollar");
            Currency JPY = new Currency("JPY", 392, "Japanese Yen");
            Currency JOD = new Currency("JOD", 400, "Jordanian Dinar");
            Currency KZT = new Currency("KZT", 398, "Kazakhstani Tenge");
            Currency KES = new Currency("KES", 404, "Kenyan Shilling");
            Currency KWD = new Currency("KWD", 414, "Kuwaiti Dinar");
            Currency KGS = new Currency("KGS", 417, "Kyrgyzstani Som");
            Currency LAK = new Currency("LAK", 418, "Lao Kip");
            Currency LBP = new Currency("LBP", 422, "Lebanese Pound");
            Currency LSL = new Currency("LSL", 426, "Lesotho Loti");
            Currency LRD = new Currency("LRD", 430, "Liberian Dollar");
            Currency LYD = new Currency("LYD", 434, "Libyan Dinar");
            Currency MOP = new Currency("MOP", 446, "Macanese Pataca");
            Currency MKD = new Currency("MKD", 807, "Macedonian Denar");
            Currency MGA = new Currency("MGA", 969, "Malagasy Ariary");
            Currency MWK = new Currency("MWK", 454, "Malawian Kwacha");
            Currency MYR = new Currency("MYR", 458, "Malaysian Ringgit");
            Currency MVR = new Currency("MVR", 462, "Maldivian Rufiyaa");
            Currency MRU = new Currency("MRU", 929, "Mauritanian Ouguiya");
            Currency MUR = new Currency("MUR", 480, "Mauritian Rupee");
            Currency MXN = new Currency("MXN", 484, "Mexican Peso");
            // Currency MXV = new Currency("MXV", 979, "Mexican Unidad de Inversion (UDI) (funds code)");
            Currency MDL = new Currency("MDL", 498, "Moldovan Leu");
            Currency MNT = new Currency("MNT", 496, "Mongolian Tögrög");
            Currency MAD = new Currency("MAD", 504, "Moroccan Dirham");
            Currency MZN = new Currency("MZN", 943, "Mozambican Metical");
            Currency MMK = new Currency("MMK", 104, "Myanmar Kyat");
            Currency NAD = new Currency("NAD", 516, "Namibian Dollar");
            Currency NPR = new Currency("NPR", 524, "Nepalese Rupee");
            Currency ANG = new Currency("ANG", 532, "Netherlands Antillean Guilder");
            Currency TWD = new Currency("TWD", 901, "New Taiwan Dollar");
            Currency NZD = new Currency("NZD", 554, "New Zealand Dollar");
            Currency NIO = new Currency("NIO", 558, "Nicaraguan Córdoba");
            Currency NGN = new Currency("NGN", 566, "Nigerian Naira");
            // Currency XXX = new Currency("XXX", 999, "No Currency");
            Currency KPW = new Currency("KPW", 408, "North Korean Won");
            Currency NOK = new Currency("NOK", 578, "Norwegian Krone");
            Currency OMR = new Currency("OMR", 512, "Omani Rial");
            Currency PKR = new Currency("PKR", 586, "Pakistani Rupee");
            // Currency XPD = new Currency("XPD", 964, "Palladium (one troy ounce)");
            Currency PAB = new Currency("PAB", 590, "Panamanian Balboa");
            Currency PGK = new Currency("PGK", 598, "Papua New Guinean Kina");
            Currency PYG = new Currency("PYG", 600, "Paraguayan Guaraní");
            Currency PEN = new Currency("PEN", 604, "Peruvian Sol");
            Currency PHP = new Currency("PHP", 608, "Philippine Peso");
            Currency XPT = new Currency("XPT", 962, "Platinum (one troy ounce)");
            Currency PLN = new Currency("PLN", 985, "Polish Zloty");
            Currency GBP = new Currency("GBP", 826, "Pound Sterling");
            Currency QAR = new Currency("QAR", 634, "Qatari Riyal");
            Currency CNY = new Currency("CNY", 156, "Renminbi (Chinese) Yuan");
            Currency RON = new Currency("RON", 946, "Romanian Leu");
            Currency RUB = new Currency("RUB", 643, "Russian Ruble");
            Currency RWF = new Currency("RWF", 646, "Rwandan Franc");
            Currency SHP = new Currency("SHP", 654, "Saint Helena Pound");
            Currency SVC = new Currency("SVC", 222, "Salvadoran Colón");
            Currency WST = new Currency("WST", 882, "Samoan Tala");
            Currency SAR = new Currency("SAR", 682, "Saudi Riyal");
            Currency RSD = new Currency("RSD", 941, "Serbian Dinar");
            Currency SCR = new Currency("SCR", 690, "Seychelles Rupee");
            Currency SLL = new Currency("SLL", 694, "Sierra Leonean Leone");
            Currency XAG = new Currency("XAG", 961, "Silver (one troy ounce)");
            Currency SGD = new Currency("SGD", 702, "Singapore Dollar");
            Currency SBD = new Currency("SBD", 90, "Solomon Islands Dollar");
            Currency SOS = new Currency("SOS", 706, "Somali Shilling");
            Currency ZAR = new Currency("ZAR", 710, "South African Rand");
            Currency KRW = new Currency("KRW", 410, "South Korean Won");
            Currency SSP = new Currency("SSP", 728, "South Sudanese Pound");
            Currency XDR = new Currency("XDR", 960, "Special Drawing Rights");
            Currency LKR = new Currency("LKR", 144, "Sri Lankan Rupee");
            Currency XSU = new Currency("XSU", 994, "SUCRE");
            Currency SDG = new Currency("SDG", 938, "Sudanese Pound");
            Currency SRD = new Currency("SRD", 968, "Surinamese Dollar");
            Currency SZL = new Currency("SZL", 748, "Swazi Lilangeni");
            Currency SEK = new Currency("SEK", 752, "Swedish Krona/Kronor");
            Currency CHF = new Currency("CHF", 756, "Swiss Franc");
            Currency SYP = new Currency("SYP", 760, "Syrian Pound");
            Currency STN = new Currency("STN", 930, "São Tomé and Príncipe Dobra");
            Currency TJS = new Currency("TJS", 972, "Tajikistani Somoni");
            Currency TZS = new Currency("TZS", 834, "Tanzanian Shilling");
            Currency THB = new Currency("THB", 764, "Thai Baht");
            Currency TOP = new Currency("TOP", 776, "Tongan Paanga");
            Currency TTD = new Currency("TTD", 780, "Trinidad and Tobago Dollar");
            Currency TND = new Currency("TND", 788, "Tunisian Dinar");
            Currency TRY = new Currency("TRY", 949, "Turkish Lira");
            Currency TMT = new Currency("TMT", 934, "Turkmenistan Manat");
            Currency UGX = new Currency("UGX", 800, "Ugandan Shilling");
            Currency UAH = new Currency("UAH", 980, "Ukrainian Hryvnia");
            Currency CLF = new Currency("CLF", 990, "Unidad de Fomento (funds code)");
            // Currency COU = new Currency("COU", 970, "Unidad de Valor Real (UVR) (funds code)");
            Currency UYW = new Currency("UYW", 927, "Unidad Previsional");
            Currency AED = new Currency("AED", 784, "United Arab Emirates Dirham");
            Currency USD = new Currency("USD", 840, "United States Dollar");
            // Currency USN = new Currency("USN", 997, "United States dollar (next day) (funds code)");
            // Currency UYI = new Currency("UYI", 940, "Uruguay Peso en Unidades Indexadas (URUIURUI) (funds code)");
            Currency UYU = new Currency("UYU", 858, "Uruguayan Peso");
            Currency UZS = new Currency("UZS", 860, "Uzbekistan Som");
            Currency VUV = new Currency("VUV", 548, "Vanuatu Vatu");
            Currency VES = new Currency("VES", 928, "Venezuelan Bolívar Soberano");
            Currency VND = new Currency("VND", 704, "Vietnamese Dong");
            // Currency CHE = new Currency("CHE", 947, "WIR Euro (complementary currency)");
            // Currency CHW = new Currency("CHW", 948, "WIR Franc (complementary currency)");
            Currency YER = new Currency("YER", 886, "Yemeni Rial");
            Currency ZMW = new Currency("ZMW", 967, "Zambian Kwacha");
            Currency ZWL = new Currency("ZWL", 932, "Zimbabwean Dollar");


            List<Currency> currencyList = new List<Currency>();
            // currencyList.Add(XUA);
            currencyList.Add(AFN);
            currencyList.Add(ALL);
            currencyList.Add(DZD);
            currencyList.Add(AOA);
            currencyList.Add(ARS);
            currencyList.Add(AMD);
            currencyList.Add(AWG);
            currencyList.Add(AUD);
            currencyList.Add(AZN);
            currencyList.Add(BSD);
            currencyList.Add(BHD);
            currencyList.Add(BDT);
            currencyList.Add(BBD);
            currencyList.Add(BYN);
            currencyList.Add(BZD);
            currencyList.Add(BMD);
            currencyList.Add(BTN);
            // currencyList.Add(BOV);
            currencyList.Add(BOB);
            currencyList.Add(BAM);
            currencyList.Add(BWP);
            currencyList.Add(BRL);
            currencyList.Add(BND);
            currencyList.Add(BGN);
            currencyList.Add(BIF);
            currencyList.Add(KHR);
            currencyList.Add(CAD);
            currencyList.Add(CVE);
            currencyList.Add(KYD);
            currencyList.Add(XOF);
            currencyList.Add(XAF);
            currencyList.Add(XPF);
            currencyList.Add(CLP);
            // currencyList.Add(XTS);
            currencyList.Add(COP);
            currencyList.Add(KMF);
            currencyList.Add(CDF);
            currencyList.Add(CRC);
            currencyList.Add(HRK);
            currencyList.Add(CUC);
            currencyList.Add(CUP);
            currencyList.Add(CZK);
            currencyList.Add(DKK);
            currencyList.Add(DJF);
            currencyList.Add(DOP);
            currencyList.Add(XCD);
            currencyList.Add(EGP);
            currencyList.Add(ERN);
            currencyList.Add(ETB);
            currencyList.Add(EUR);
            // currencyList.Add(XBA);
            // currencyList.Add(XBB);
            // currencyList.Add(XBD);
            // currencyList.Add(XBC);
            currencyList.Add(FKP);
            currencyList.Add(FJD);
            currencyList.Add(GMD);
            currencyList.Add(GEL);
            currencyList.Add(GHS);
            currencyList.Add(GIP);
            currencyList.Add(XAU);
            currencyList.Add(GTQ);
            currencyList.Add(GNF);
            currencyList.Add(GYD);
            currencyList.Add(HTG);
            currencyList.Add(HNL);
            currencyList.Add(HKD);
            currencyList.Add(HUF);
            currencyList.Add(ISK);
            currencyList.Add(INR);
            currencyList.Add(IDR);
            currencyList.Add(IRR);
            currencyList.Add(IQD);
            currencyList.Add(ILS);
            currencyList.Add(JMD);
            currencyList.Add(JPY);
            currencyList.Add(JOD);
            currencyList.Add(KZT);
            currencyList.Add(KES);
            currencyList.Add(KWD);
            currencyList.Add(KGS);
            currencyList.Add(LAK);
            currencyList.Add(LBP);
            currencyList.Add(LSL);
            currencyList.Add(LRD);
            currencyList.Add(LYD);
            currencyList.Add(MOP);
            currencyList.Add(MKD);
            currencyList.Add(MGA);
            currencyList.Add(MWK);
            currencyList.Add(MYR);
            currencyList.Add(MVR);
            currencyList.Add(MRU);
            currencyList.Add(MUR);
            currencyList.Add(MXN);
            // currencyList.Add(MXV);
            currencyList.Add(MDL);
            currencyList.Add(MNT);
            currencyList.Add(MAD);
            currencyList.Add(MZN);
            currencyList.Add(MMK);
            currencyList.Add(NAD);
            currencyList.Add(NPR);
            currencyList.Add(ANG);
            currencyList.Add(TWD);
            currencyList.Add(NZD);
            currencyList.Add(NIO);
            currencyList.Add(NGN);
            // currencyList.Add(XXX);
            currencyList.Add(KPW);
            currencyList.Add(NOK);
            currencyList.Add(OMR);
            currencyList.Add(PKR);
            // currencyList.Add(XPD);
            currencyList.Add(PAB);
            currencyList.Add(PGK);
            currencyList.Add(PYG);
            currencyList.Add(PEN);
            currencyList.Add(PHP);
            currencyList.Add(XPT);
            currencyList.Add(PLN);
            currencyList.Add(GBP);
            currencyList.Add(QAR);
            currencyList.Add(CNY);
            currencyList.Add(RON);
            currencyList.Add(RUB);
            currencyList.Add(RWF);
            currencyList.Add(SHP);
            currencyList.Add(SVC);
            currencyList.Add(WST);
            currencyList.Add(SAR);
            currencyList.Add(RSD);
            currencyList.Add(SCR);
            currencyList.Add(SLL);
            currencyList.Add(XAG);
            currencyList.Add(SGD);
            currencyList.Add(SBD);
            currencyList.Add(SOS);
            currencyList.Add(ZAR);
            currencyList.Add(KRW);
            currencyList.Add(SSP);
            currencyList.Add(XDR);
            currencyList.Add(LKR);
            currencyList.Add(XSU);
            currencyList.Add(SDG);
            currencyList.Add(SRD);
            currencyList.Add(SZL);
            currencyList.Add(SEK);
            currencyList.Add(CHF);
            currencyList.Add(SYP);
            currencyList.Add(STN);
            currencyList.Add(TJS);
            currencyList.Add(TZS);
            currencyList.Add(THB);
            currencyList.Add(TOP);
            currencyList.Add(TTD);
            currencyList.Add(TND);
            currencyList.Add(TRY);
            currencyList.Add(TMT);
            currencyList.Add(UGX);
            currencyList.Add(UAH);
            currencyList.Add(CLF);
            // currencyList.Add(COU);
            currencyList.Add(UYW);
            currencyList.Add(AED);
            currencyList.Add(USD);
            // currencyList.Add(USN);
            // currencyList.Add(UYI);
            currencyList.Add(UYU);
            currencyList.Add(UZS);
            currencyList.Add(VUV);
            currencyList.Add(VES);
            currencyList.Add(VND);
            // currencyList.Add(CHE);
            // currencyList.Add(CHW);
            currencyList.Add(YER);
            currencyList.Add(ZMW);
            currencyList.Add(ZWL);

            return currencyList;
        }

        // Prints out Currency Names and Codes
        public static void PrintList()
        {
            List<Currency> currencyList = Currency.ISO4217();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|               Currency Name              | Currency Code |");
            Console.WriteLine("------------------------------------------------------------");

            for (int i = 0; i < 164; i++)
            {
                int nameLength = currencyList[i].CurrencyName.Length;
                string moneyName = currencyList[i].CurrencyName;
                int codeLength = currencyList[i].CurrencyCode.Length;
                string moneyCode = currencyList[i].CurrencyCode;
                if (nameLength <= 39)
                {
                    for (int j = 0; j <= 39 - nameLength; j++)
                    {
                        moneyName = moneyName + " ";
                    }
                    moneyCode = "     " + moneyCode + "     ";
                } else
                {
                    moneyCode = "     " + moneyCode + "     ";
                }
                Console.WriteLine($"| {moneyName} | {moneyCode} |");
                Console.WriteLine("------------------------------------------------------------");
            }
        }

        // Validates an entered code is a legitimate code
        public static bool ValidCurrencyCode(string code)
        {
            bool valid = false;
            List<Currency> currencyList = Currency.ISO4217();
            for (int i = 0; i < 164; i++)
            {
                if (currencyList[i].CurrencyCode == code)
                {
                    valid = true;
                    return valid;
                }
            }
            return valid;
        }

        // Parses a string of latest exchange rates to EUR via fixer.io
        public static double ParseData(Currency Currency)
        {
            try
            {
                double amount = 0.0;
                //Scrapes Web Data to get the rates.
                string jsonOriginal = WebScapper.ReturnWebRateData();
                //Removes the headers
                string[] splitInformation = jsonOriginal.Split('{','}');
                //Our current Data can then be split into "Name : Rate"
                string[] rows = splitInformation[2].Split(',');
                foreach (var row in rows)
                { 
                    //Gets rid of spaces and new line characters
                    string line = row.Trim();
                    //Gets the currency code name
                    string name = line.Substring(1,3);
                    if (name == Currency.CurrencyCode) 
                    {
                        //and extracts the amount
                        amount = Convert.ToDouble(line.Substring(6));
                        return amount;
                    }
                }
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Something went wrong.");
                return 0;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Something went wrong.");
                return 0;
            }
            Console.WriteLine("Something went wrong.");
            return 0;
        }

        // Converts one currency to another via the Euro exchange rate from fixer.io
        public static double ConvertCurrency(double currencyValue1, double currencyValue2)
        {
            double convertedCurrency = (1 / currencyValue1) * currencyValue2;
            return convertedCurrency;
        }

        // Default Currency Not Found Error
        private static string CurrencyNotFound()
        {
            return "The currency you requested could not be found at this time. \nThe code has been entered incorrectly or there is a problem with our API." +
            "\nYou will now be returned to the main menu.";
        }

        // Interfaces with Console to grab user entered codes
        public static string UserInput() {
            Console.Write("Enter the code you will be exchanging from: ");
            string input = Console.ReadLine();
            input = input.ToUpper();
            if (ValidCurrencyCode(input) == false)
            {
                Console.WriteLine(CurrencyNotFound());
                return "-1";
            }
            return input;
        }

        // Leverages other functions to output the exchage rate
        public static void ExchangeProcess() {
            try
            {
                // Creates List of Currency Object
                List<Currency> myList = Currency.ISO4217();
                // Grabs input & validates bad data
                string first = UserInput();
                if (first == "-1")
                {
                    return;
                }
                string second = UserInput();
                if (second == "-1")
                {
                    return;
                }
                // Finds Currency objects matching user input
                double firstRate = Currency.ParseData(myList.Find(x => (x.CurrencyCode == first)));
                double secondRate = Currency.ParseData(myList.Find(x => (x.CurrencyCode == second)));
                //Get the name of the currency
                var firstMoneyName = myList.Find(y => (y.CurrencyCode == first));
                var secondMoneyName = myList.Find(y => (y.CurrencyCode == second));
                //Calculation 
                double exchange = ConvertCurrency(firstRate,secondRate);
                exchange = Math.Round(exchange, 2);
                //Print result
                Console.WriteLine($"The {firstMoneyName.CurrencyCode} to {secondMoneyName.CurrencyCode} exchange rate is: 1 {firstMoneyName.CurrencyName} to {exchange} {secondMoneyName.CurrencyName}s");
                Console.WriteLine("Press Enter to return to the menu");
                Console.ReadLine();
            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine(CurrencyNotFound());
                return;
            }
            catch (System.Exception)
            {
                Console.WriteLine(CurrencyNotFound());
                return;
            }
        }
    }
}