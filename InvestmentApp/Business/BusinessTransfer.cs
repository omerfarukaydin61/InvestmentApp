using InvestmentApp.Entities.Classes;
using InvestmentApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentApp.Business
{
    public class BusinessTransfer
    {
        Repository _repository;
        public BusinessTransfer()
        {
            _repository = new Repository();
        }
        public async Task<List<BankAccount>> GetUserBankAccounts(UserDto targetUser, CurrencyTypes CurrencyType)
        {
            if (targetUser == null)
                return null;

            List<BankAccount> targetBankAccounts = await _repository.GetUserBankAccounts(targetUser.ID);
            return targetBankAccounts.Where(x => x.Currency == CurrencyType).ToList();
        }
        public Task<List<BankAccount>> GetUserBankAccounts(int senderUserID)
        {
            return _repository.GetUserBankAccounts(senderUserID);
        }
        public Task<List<UserDto>> GetUserTable()
        {
            return _repository.GetUserTable();
        }
    }
}
