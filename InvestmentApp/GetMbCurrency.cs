using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InvestmentApp
{
    public class GetMbCurrency
    {
        private static MBData _priceList;
        public static MBData PriceList
        {
            get
            {
                if (_priceList == null)
                {
                    _priceList = AsyncHelper.RunSync(async () => { return await GetUsdCurrency(); });
                }

                var prsed = DateTime.TryParseExact(
                    _priceList.Date,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime date);

                if (!prsed || (date < DateTime.Today.AddDays(-1)))  // || Ilk True geldigi zaman iceri girer
                {
                    _priceList = AsyncHelper.RunSync(async () => { return await GetUsdCurrency(); });
                }

                return _priceList;
            }
        }

        private static async Task<MBData> GetUsdCurrency()
        {
            var todayCurrenciesXml = await new HttpClient().GetStringAsync("https://www.tcmb.gov.tr/kurlar/today.xml");

            var result = Deserialize(todayCurrenciesXml);
            return result;
        }
        public static MBData Deserialize(string input)
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(MBData));

            using (StringReader sr = new StringReader(input))
            {
                return (MBData)ser.Deserialize(sr);
            }
        }
    }
}
