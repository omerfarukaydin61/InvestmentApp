using InvestmentApp.Entities;
using InvestmentApp.Entities.Classes;
using InvestmentApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentApp.Business
{
    public class BusinessInvest
    {
        Repository _repository;
        MBData mBData = GetMbCurrency.PriceList;
        public BusinessInvest()
        {
            _repository = new Repository();
        }
        public Task<List<UserDto>> GetUserTable()
        {
            return _repository.GetUserTable();
        }
        public List<CurrencyModel> GetCurrencies()
        {
            return _repository.GetCurrencyTable();
        }
        public Task<List<BankAccountDto>> GetUserBankAccounts(int id)
        {
            return _repository.GetUserBankAccounts(id);
        }
        public Task<List<UserInvestmentDto>> GetUserInvestmentLog(int id)
        {
            return _repository.GetUserInvestmentLog(id);
        }
        public Task<UserDto> GetUserFromID(int id)
        {
            return _repository.GetUserFromID(id);
        }
        public decimal CalculateExchange(CurrencyTypes hand, CurrencyTypes to, decimal amount)
        {
            try
            {
                decimal result = 0;
                if (hand == CurrencyTypes.TL && to == CurrencyTypes.TL)
                {
                    return amount;
                }
                if (hand == CurrencyTypes.TL)
                {
                    Currency toCurrency = mBData.Currencies.FirstOrDefault(x => x.CurrencyCode == Convert.ToString(to));
                    result += amount / (Convert.ToDecimal(toCurrency.BanknoteSelling));
                    return result;
                }

                if (to == CurrencyTypes.TL)
                {
                    Currency handCurrency = mBData.Currencies.FirstOrDefault(x => x.CurrencyCode == Convert.ToString(hand));
                    result += amount * (Convert.ToDecimal(handCurrency.BanknoteSelling));
                    return result;
                }

                if (hand != CurrencyTypes.TL && to != CurrencyTypes.TL)
                {
                    Currency handCurrency = mBData.Currencies.FirstOrDefault(x => x.CurrencyCode == Convert.ToString(hand));
                    Currency toCurrency = mBData.Currencies.FirstOrDefault(x => x.CurrencyCode == Convert.ToString(to));
                    decimal rate = (Convert.ToDecimal(handCurrency.BanknoteSelling)) / (Convert.ToDecimal(toCurrency.BanknoteSelling));
                    result += amount * rate;
                    return result;
                }
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public decimal CalculateTotalBalance(List<BankAccountDto> bankAccounts, CurrencyTypes to)
        {
            decimal result = 0;
            if (bankAccounts != null)
            {
                foreach (var account in bankAccounts)
                {
                    decimal amount = CalculateExchange(account.Currency, to, account.Balance);
                    result += amount;
                }
                return result;
            }
            return result;
        }
    }
}
