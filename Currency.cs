using System.Collections;
using System.Collections.Generic;
using System.Text;
using System;

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
        // From: https://en.wikipedia.org/wiki/ISO_4217
        public static List<Currency> ISO4217()
        {
            Currency XUA = new Currency("XUA", 965, "ADB Unit of Account");
            Currency AFN = new Currency("AFN", 971, "Afghan afghani");
            Currency ALL = new Currency("ALL", 8, "Albanian lek");
            Currency DZD = new Currency("DZD", 12, "Algerian dinar");
            Currency AOA = new Currency("AOA", 973, "Angolan kwanza");
            Currency ARS = new Currency("ARS", 32, "Argentine peso");
            Currency AMD = new Currency("AMD", 51, "Armenian dram");
            Currency AWG = new Currency("AWG", 533, "Aruban florin");
            Currency AUD = new Currency("AUD", 36, "Australian dollar");
            Currency AZN = new Currency("AZN", 944, "Azerbaijani manat");
            Currency BSD = new Currency("BSD", 44, "Bahamian dollar");
            Currency BHD = new Currency("BHD", 48, "Bahraini dinar");
            Currency BDT = new Currency("BDT", 50, "Bangladeshi taka");
            Currency BBD = new Currency("BBD", 52, "Barbados dollar");
            Currency BYN = new Currency("BYN", 933, "Belarusian ruble");
            Currency BZD = new Currency("BZD", 84, "Belize dollar");
            Currency BMD = new Currency("BMD", 60, "Bermudian dollar");
            Currency BTN = new Currency("BTN", 64, "Bhutanese ngultrum");
            Currency BOV = new Currency("BOV", 984, "Bolivian Mvdol (funds code)");
            Currency BOB = new Currency("BOB", 68, "Boliviano");
            Currency BAM = new Currency("BAM", 977, "Bosnia and Herzegovina convertible mark");
            Currency BWP = new Currency("BWP", 72, "Botswana pula");
            Currency BRL = new Currency("BRL", 986, "Brazilian real");
            Currency BND = new Currency("BND", 96, "Brunei dollar");
            Currency BGN = new Currency("BGN", 975, "Bulgarian lev");
            Currency BIF = new Currency("BIF", 108, "Burundian franc");
            Currency KHR = new Currency("KHR", 116, "Cambodian riel");
            Currency CAD = new Currency("CAD", 124, "Canadian dollar");
            Currency CVE = new Currency("CVE", 132, "Cape Verdean escudo");
            Currency KYD = new Currency("KYD", 136, "Cayman Islands dollar");
            Currency XOF = new Currency("XOF", 952, "CFA franc BCEAO");
            Currency XAF = new Currency("XAF", 950, "CFA franc BEAC");
            Currency XPF = new Currency("XPF", 953, "CFP franc (franc Pacifique)");
            Currency CLP = new Currency("CLP", 152, "Chilean peso");
            Currency XTS = new Currency("XTS", 963, "Code reserved for testing");
            Currency COP = new Currency("COP", 170, "Colombian peso");
            Currency KMF = new Currency("KMF", 174, "Comoro franc");
            Currency CDF = new Currency("CDF", 976, "Congolese franc");
            Currency CRC = new Currency("CRC", 188, "Costa Rican colon");
            Currency HRK = new Currency("HRK", 191, "Croatian kuna");
            Currency CUC = new Currency("CUC", 931, "Cuban convertible peso");
            Currency CUP = new Currency("CUP", 192, "Cuban peso");
            Currency CZK = new Currency("CZK", 203, "Czech koruna");
            Currency DKK = new Currency("DKK", 208, "Danish krone");
            Currency DJF = new Currency("DJF", 262, "Djiboutian franc");
            Currency DOP = new Currency("DOP", 214, "Dominican peso");
            Currency XCD = new Currency("XCD", 951, "East Caribbean dollar");
            Currency EGP = new Currency("EGP", 818, "Egyptian pound");
            Currency ERN = new Currency("ERN", 232, "Eritrean nakfa");
            Currency ETB = new Currency("ETB", 230, "Ethiopian birr");
            Currency EUR = new Currency("EUR", 978, "Euro");
            Currency XBA = new Currency("XBA", 955, "European Composite Unit (EURCO) (bond market unit)");
            Currency XBB = new Currency("XBB", 956, "European Monetary Unit (E.M.U.-6) (bond market unit)");
            Currency XBD = new Currency("XBD", 958, "European Unit of Account 17 (E.U.A.-17) (bond market unit)");
            Currency XBC = new Currency("XBC", 957, "European Unit of Account 9 (E.U.A.-9) (bond market unit)");
            Currency FKP = new Currency("FKP", 238, "Falkland Islands pound");
            Currency FJD = new Currency("FJD", 242, "Fiji dollar");
            Currency GMD = new Currency("GMD", 270, "Gambian dalasi");
            Currency GEL = new Currency("GEL", 981, "Georgian lari");
            Currency GHS = new Currency("GHS", 936, "Ghanaian cedi");
            Currency GIP = new Currency("GIP", 292, "Gibraltar pound");
            Currency XAU = new Currency("XAU", 959, "Gold (one troy ounce)");
            Currency GTQ = new Currency("GTQ", 320, "Guatemalan quetzal");
            Currency GNF = new Currency("GNF", 324, "Guinean franc");
            Currency GYD = new Currency("GYD", 328, "Guyanese dollar");
            Currency HTG = new Currency("HTG", 332, "Haitian gourde");
            Currency HNL = new Currency("HNL", 340, "Honduran lempira");
            Currency HKD = new Currency("HKD", 344, "Hong Kong dollar");
            Currency HUF = new Currency("HUF", 348, "Hungarian forint");
            Currency ISK = new Currency("ISK", 352, "Icelandic króna");
            Currency INR = new Currency("INR", 356, "Indian rupee");
            Currency IDR = new Currency("IDR", 360, "Indonesian rupiah");
            Currency IRR = new Currency("IRR", 364, "Iranian rial");
            Currency IQD = new Currency("IQD", 368, "Iraqi dinar");
            Currency ILS = new Currency("ILS", 376, "Israeli new shekel");
            Currency JMD = new Currency("JMD", 388, "Jamaican dollar");
            Currency JPY = new Currency("JPY", 392, "Japanese yen");
            Currency JOD = new Currency("JOD", 400, "Jordanian dinar");
            Currency KZT = new Currency("KZT", 398, "Kazakhstani tenge");
            Currency KES = new Currency("KES", 404, "Kenyan shilling");
            Currency KWD = new Currency("KWD", 414, "Kuwaiti dinar");
            Currency KGS = new Currency("KGS", 417, "Kyrgyzstani som");
            Currency LAK = new Currency("LAK", 418, "Lao kip");
            Currency LBP = new Currency("LBP", 422, "Lebanese pound");
            Currency LSL = new Currency("LSL", 426, "Lesotho loti");
            Currency LRD = new Currency("LRD", 430, "Liberian dollar");
            Currency LYD = new Currency("LYD", 434, "Libyan dinar");
            Currency MOP = new Currency("MOP", 446, "Macanese pataca");
            Currency MKD = new Currency("MKD", 807, "Macedonian denar");
            Currency MGA = new Currency("MGA", 969, "Malagasy ariary");
            Currency MWK = new Currency("MWK", 454, "Malawian kwacha");
            Currency MYR = new Currency("MYR", 458, "Malaysian ringgit");
            Currency MVR = new Currency("MVR", 462, "Maldivian rufiyaa");
            Currency MRU = new Currency("MRU", 929, "Mauritanian ouguiya");
            Currency MUR = new Currency("MUR", 480, "Mauritian rupee");
            Currency MXN = new Currency("MXN", 484, "Mexican peso");
            Currency MXV = new Currency("MXV", 979, "Mexican Unidad de Inversion (UDI) (funds code)");
            Currency MDL = new Currency("MDL", 498, "Moldovan leu");
            Currency MNT = new Currency("MNT", 496, "Mongolian tögrög");
            Currency MAD = new Currency("MAD", 504, "Moroccan dirham");
            Currency MZN = new Currency("MZN", 943, "Mozambican metical");
            Currency MMK = new Currency("MMK", 104, "Myanmar kyat");
            Currency NAD = new Currency("NAD", 516, "Namibian dollar");
            Currency NPR = new Currency("NPR", 524, "Nepalese rupee");
            Currency ANG = new Currency("ANG", 532, "Netherlands Antillean guilder");
            Currency TWD = new Currency("TWD", 901, "New Taiwan dollar");
            Currency NZD = new Currency("NZD", 554, "New Zealand dollar");
            Currency NIO = new Currency("NIO", 558, "Nicaraguan córdoba");
            Currency NGN = new Currency("NGN", 566, "Nigerian naira");
            Currency XXX = new Currency("XXX", 999, "No currency");
            Currency KPW = new Currency("KPW", 408, "North Korean won");
            Currency NOK = new Currency("NOK", 578, "Norwegian krone");
            Currency OMR = new Currency("OMR", 512, "Omani rial");
            Currency PKR = new Currency("PKR", 586, "Pakistani rupee");
            Currency XPD = new Currency("XPD", 964, "Palladium (one troy ounce)");
            Currency PAB = new Currency("PAB", 590, "Panamanian balboa");
            Currency PGK = new Currency("PGK", 598, "Papua New Guinean kina");
            Currency PYG = new Currency("PYG", 600, "Paraguayan guaraní");
            Currency PEN = new Currency("PEN", 604, "Peruvian sol");
            Currency PHP = new Currency("PHP", 608, "Philippine peso");
            Currency XPT = new Currency("XPT", 962, "Platinum (one troy ounce)");
            Currency PLN = new Currency("PLN", 985, "Polish z?oty");
            Currency GBP = new Currency("GBP", 826, "Pound sterling");
            Currency QAR = new Currency("QAR", 634, "Qatari riyal");
            Currency CNY = new Currency("CNY", 156, "Renminbi (Chinese) yuan");
            Currency RON = new Currency("RON", 946, "Romanian leu");
            Currency RUB = new Currency("RUB", 643, "Russian ruble");
            Currency RWF = new Currency("RWF", 646, "Rwandan franc");
            Currency SHP = new Currency("SHP", 654, "Saint Helena pound");
            Currency SVC = new Currency("SVC", 222, "Salvadoran colón");
            Currency WST = new Currency("WST", 882, "Samoan tala");
            Currency SAR = new Currency("SAR", 682, "Saudi riyal");
            Currency RSD = new Currency("RSD", 941, "Serbian dinar");
            Currency SCR = new Currency("SCR", 690, "Seychelles rupee");
            Currency SLL = new Currency("SLL", 694, "Sierra Leonean leone");
            Currency XAG = new Currency("XAG", 961, "Silver (one troy ounce)");
            Currency SGD = new Currency("SGD", 702, "Singapore dollar");
            Currency SBD = new Currency("SBD", 90, "Solomon Islands dollar");
            Currency SOS = new Currency("SOS", 706, "Somali shilling");
            Currency ZAR = new Currency("ZAR", 710, "South African rand");
            Currency KRW = new Currency("KRW", 410, "South Korean won");
            Currency SSP = new Currency("SSP", 728, "South Sudanese pound");
            Currency XDR = new Currency("XDR", 960, "Special drawing rights");
            Currency LKR = new Currency("LKR", 144, "Sri Lankan rupee");
            Currency XSU = new Currency("XSU", 994, "SUCRE");
            Currency SDG = new Currency("SDG", 938, "Sudanese pound");
            Currency SRD = new Currency("SRD", 968, "Surinamese dollar");
            Currency SZL = new Currency("SZL", 748, "Swazi lilangeni");
            Currency SEK = new Currency("SEK", 752, "Swedish krona/kronor");
            Currency CHF = new Currency("CHF", 756, "Swiss franc");
            Currency SYP = new Currency("SYP", 760, "Syrian pound");
            Currency STN = new Currency("STN", 930, "São Tomé and Príncipe dobra");
            Currency TJS = new Currency("TJS", 972, "Tajikistani somoni");
            Currency TZS = new Currency("TZS", 834, "Tanzanian shilling");
            Currency THB = new Currency("THB", 764, "Thai baht");
            Currency TOP = new Currency("TOP", 776, "Tongan pa?anga");
            Currency TTD = new Currency("TTD", 780, "Trinidad and Tobago dollar");
            Currency TND = new Currency("TND", 788, "Tunisian dinar");
            Currency TRY = new Currency("TRY", 949, "Turkish lira");
            Currency TMT = new Currency("TMT", 934, "Turkmenistan manat");
            Currency UGX = new Currency("UGX", 800, "Ugandan shilling");
            Currency UAH = new Currency("UAH", 980, "Ukrainian hryvnia");
            Currency CLF = new Currency("CLF", 990, "Unidad de Fomento (funds code)");
            Currency COU = new Currency("COU", 970, "Unidad de Valor Real (UVR) (funds code)");
            Currency UYW = new Currency("UYW", 927, "Unidad previsional");
            Currency AED = new Currency("AED", 784, "United Arab Emirates dirham");
            Currency USD = new Currency("USD", 840, "United States dollar");
            Currency USN = new Currency("USN", 997, "United States dollar (next day) (funds code)");
            Currency UYI = new Currency("UYI", 940, "Uruguay Peso en Unidades Indexadas (URUIURUI) (funds code)");
            Currency UYU = new Currency("UYU", 858, "Uruguayan peso");
            Currency UZS = new Currency("UZS", 860, "Uzbekistan som");
            Currency VUV = new Currency("VUV", 548, "Vanuatu vatu");
            Currency VES = new Currency("VES", 928, "Venezuelan bolívar soberano");
            Currency VND = new Currency("VND", 704, "Vietnamese ??ng");
            Currency CHE = new Currency("CHE", 947, "WIR Euro (complementary currency)");
            Currency CHW = new Currency("CHW", 948, "WIR Franc (complementary currency)");
            Currency YER = new Currency("YER", 886, "Yemeni rial");
            Currency ZMW = new Currency("ZMW", 967, "Zambian kwacha");
            Currency ZWL = new Currency("ZWL", 932, "Zimbabwean dollar");


            List<Currency> currencyList = new List<Currency>();
            currencyList.Add(XUA);
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
            currencyList.Add(BOV);
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
            currencyList.Add(XTS);
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
            currencyList.Add(XBA);
            currencyList.Add(XBB);
            currencyList.Add(XBD);
            currencyList.Add(XBC);
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
            currencyList.Add(MXV);
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
            currencyList.Add(XXX);
            currencyList.Add(KPW);
            currencyList.Add(NOK);
            currencyList.Add(OMR);
            currencyList.Add(PKR);
            currencyList.Add(XPD);
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
            currencyList.Add(COU);
            currencyList.Add(UYW);
            currencyList.Add(AED);
            currencyList.Add(USD);
            currencyList.Add(USN);
            currencyList.Add(UYI);
            currencyList.Add(UYU);
            currencyList.Add(UZS);
            currencyList.Add(VUV);
            currencyList.Add(VES);
            currencyList.Add(VND);
            currencyList.Add(CHE);
            currencyList.Add(CHW);
            currencyList.Add(YER);
            currencyList.Add(ZMW);
            currencyList.Add(ZWL);

            return currencyList;
        }

        			
        public static double parseData(Currency Currency)
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
                string line = row.Trim();
                string name = line.Substring(1,3);
                if (name == Currency.CurrencyCode) {
                    amount = Convert.ToDouble(line.Substring(6));
                
                }
            }
            return amount;   
                
        }
            

        /*
        // Returns the exchange rate from Yahoo
        public static var YahooRate(Currency currency1, Currency currency2)
        {
            
        }

        // Converts one currency to another via the exchange rate from Yahoo
        public static double YahooConvert(Currency currency1, Currency currency2)
        {

        }

        // Returns the exchange rate from Google
        public static double GoogleRate(Currency currency1, Currency currency2)
        {

        }
        */

        // Converts one currency to another via the Euro exchange rate from fixer.io
        public static double ConvertCurrency(double currencyValue1, double currencyValue2)
        {
            double convertedCurrency = (1 / currencyValue1) * currencyValue2;
            return convertedCurrency;
        }

        // Default Currency Not Found Error
        public static string CurrencyNotFound(string message)
        {
            return "The currency you requested could not be found at this time.";
        }
        

    }
}