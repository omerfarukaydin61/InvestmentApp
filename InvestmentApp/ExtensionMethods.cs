using InvestmentApp.Entities.Classes;
using InvestmentApp.Entities.EntityData;
using InvestmentApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentApp
{
    public static class ExtensionMethods
    {
        public static UserDto CastUserTableToDto(this UserTable user)
        {
            return new UserDto
            {
                ID = user.ID,
                Name = user.Name,
                Surname = user.Surname,
                Username = user.Username,
                Password = user.Password,
                RegisterDate = user.RegisterDate,
                Permission = (Permissions)user.Permission,
            };
        }
        public static UserTable CastDtoToUserTable(this UserDto user)
        {
            return new UserTable
            {
                ID = user.ID,
                Name = user.Name,
                Surname = user.Surname,
                Username = user.Username,
                Password = user.Password,
                RegisterDate = user.RegisterDate,
                Permission = (int)user.Permission
            };
        }
        public static BankAccountDto CastBankAccountToDto(this BankAccount bankAccount)
        {
            return new BankAccountDto
            {
                ID = bankAccount.ID,
                UserId = bankAccount.UserId,
                AccountName = bankAccount.AccountName,
                IBAN = bankAccount.IBAN,
                Currency = (CurrencyTypes)bankAccount.Currency,
                Balance = bankAccount.Balance
            };
        }
        public static BankAccount CastDtoToBankAccount(this BankAccountDto bankAccountDto)
        {
            return new BankAccount
            {
                ID = bankAccountDto.ID,
                UserId = bankAccountDto.UserId,
                AccountName = bankAccountDto.AccountName,
                IBAN = bankAccountDto.IBAN,
                Currency = (int)bankAccountDto.Currency,
                Balance = bankAccountDto.Balance
            };
        }
        public static LogDto CastLogToDto(this Log log)
        {
            return new LogDto
            {
                ID = log.ID,
                EffecterID = log.EffecterID,
                AffectedID = log.AffectedID,
                Date = log.Date,
                Action = (LogAction)log.Action,
                Explanation = log.Explanation,
            };
        }
        public static Log CastDtoTolog(this LogDto logDto)
        {
            return new Log
            {
                ID = logDto.ID,
                EffecterID = logDto.EffecterID,
                AffectedID = logDto.AffectedID,
                Date = logDto.Date,
                Action = (int)logDto.Action,
                Explanation = logDto.Explanation,
            };
        }
        public static UserInvestmentDto CastUserInvestmentToDto(this UserInvestment userInvestment)
        {
            return new UserInvestmentDto
            {
                ID = userInvestment.ID,
                EffecterID = userInvestment.EffecterID,
                AffectedID = userInvestment.AffectedID,
                Date = userInvestment.Date,
                Action = (LogAction)userInvestment.Action,
                Explanation = userInvestment.Explanation,
                Currency = (CurrencyTypes)userInvestment.Currency,
                Amount = userInvestment.Amount,
                SenderBankAccountId = userInvestment.SenderBankAccountId,
                TargetBankAccountId = userInvestment.TargetBankAccountId
            };
        }
        public static UserInvestment CastDtoToUserInvestment(this UserInvestmentDto userInvestmentDto)
        {
            return new UserInvestment
            {
                ID = userInvestmentDto.ID,
                EffecterID = userInvestmentDto.EffecterID,
                AffectedID = userInvestmentDto.AffectedID,
                Date = userInvestmentDto.Date,
                Action = (int)userInvestmentDto.Action,
                Explanation = userInvestmentDto.Explanation,
                Currency = (int)userInvestmentDto.Currency,
                Amount = userInvestmentDto.Amount,
                SenderBankAccountId = userInvestmentDto.SenderBankAccountId,
                TargetBankAccountId = userInvestmentDto.TargetBankAccountId
            };
        }
    }
}
