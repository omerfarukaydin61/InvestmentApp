using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentApp
{
    internal static class IBANGenerator
    {
        public static string CreateIBAN()
        {
            string IBAN = "TR";
            Random rnd = new Random();
            foreach (int value in Enumerable.Range(1, 24))
            {
                int number = rnd.Next(1, 10);
                IBAN += Convert.ToString(number);
            }
            
            return IBAN;
        }
    }
}
