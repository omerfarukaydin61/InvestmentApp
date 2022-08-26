using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InvestmentApp
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", ElementName = "Tarih_Date", IsNullable = false)]
    public partial class MBData
    {

        private List<Currency> _currencies;

        private string tarihField;

        private string dateField;

        private string bulten_NoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Currency")]
        public List<Currency> Currencies
        {
            get
            {
                return this._currencies;
            }
            set
            {
                this._currencies = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tarih
        {
            get
            {
                return this.tarihField;
            }
            set
            {
                this.tarihField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Bulten_No
        {
            get
            {
                return this.bulten_NoField;
            }
            set
            {
                this.bulten_NoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Currency
    {

        private byte unitField;

        private string isimField;

        private string currencyNameField;

        private decimal forexBuyingField;

        private string forexSellingField;

        private string banknoteBuyingField;

        private string banknoteSellingField;

        private string crossRateUSDField;

        private string crossRateOtherField;

        private byte crossOrderField;

        private string kodField;

        private string currencyCodeField;

        /// <remarks/>
        public byte Unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }

        /// <remarks/>
        public string Isim
        {
            get
            {
                return this.isimField;
            }
            set
            {
                this.isimField = value;
            }
        }

        /// <remarks/>
        public string CurrencyName
        {
            get
            {
                return this.currencyNameField;
            }
            set
            {
                this.currencyNameField = value;
            }
        }

        /// <remarks/>
        public decimal ForexBuying
        {
            get
            {
                return this.forexBuyingField;
            }
            set
            {
                this.forexBuyingField = value;
            }
        }

        /// <remarks/>
        public string ForexSelling
        {
            get
            {
                return this.forexSellingField;
            }
            set
            {
                this.forexSellingField = value;
            }
        }

        /// <remarks/>
        public string BanknoteBuying
        {
            get
            {
                return this.banknoteBuyingField;
            }
            set
            {
                this.banknoteBuyingField = value;
            }
        }

        /// <remarks/>
        public string BanknoteSelling
        {
            get
            {
                return this.banknoteSellingField;
            }
            set
            {
                this.banknoteSellingField = value;
            }
        }

        /// <remarks/>
        public string CrossRateUSD
        {
            get
            {
                return this.crossRateUSDField;
            }
            set
            {
                this.crossRateUSDField = value;
            }
        }

        /// <remarks/>
        public string CrossRateOther
        {
            get
            {
                return this.crossRateOtherField;
            }
            set
            {
                this.crossRateOtherField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte CrossOrder
        {
            get
            {
                return this.crossOrderField;
            }
            set
            {
                this.crossOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Kod
        {
            get
            {
                return this.kodField;
            }
            set
            {
                this.kodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }
    }




}
