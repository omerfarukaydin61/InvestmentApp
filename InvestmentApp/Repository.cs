using InvestmentApp.Entities;
using InvestmentApp.Entities.Classes;
using InvestmentApp.Entities.EntityData;
using InvestmentApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentApp
{
    public class Repository
    {
        InvestmentDbContext _context;

        public Repository()
        {
            _context = new InvestmentDbContext();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // GetBool();GetBool();GetBool();GetBool();GetBool();GetBool();GetBool();GetBool();GetBool();GetBool();GetBool();GetBool();GetBool();GetBool();
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public async Task<bool> Login(string username, string password)
        {
            try
            {
                UserTable userTable = await _context.UserTables.FirstOrDefaultAsync(x => x.Username == username && x.Password == password);
                if (userTable != null)
                {
                    ConfigModel.RegisteredUser = userTable.CastUserTableToDto();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                await Logger.ExeptionLog(ex);
                return false;
            }
        }
        public async Task<(bool, string)> Add(UserDto user)
        {
            try
            {
                if (!_context.UserTables.Any(x => x.Username == user.Username))
                {
                    _context.UserTables.Add(user.CastDtoToUserTable());
                    await _context.SaveChangesAsync();
                    return (true, "User added successfully");
                }
                else
                {
                    return (false, "These username has been taken");
                }
            }
            catch (Exception ex)
            {
                await Logger.ExeptionLog(ex);
                return (false, ex.Message);
            }
        }
        public async Task<(bool, string)> Delete(UserDto user)
        {
            try
            {
                if (ConfigModel.RegisteredUser.ID != user.ID)
                {
                    var entity = _context.Entry(user.CastDtoToUserTable());
                    entity.State = EntityState.Deleted;
                    await _context.SaveChangesAsync();
                    return (true, "User deleted");
                }
                else
                {
                    return (false, "You can not delete yourself");
                }
            }
            catch (Exception ex)
            {
                await Logger.ExeptionLog(ex);
                return (false, ex.Message);
            }
        }
        public async Task<(bool, string)> Update(UserDto user)
        {
            try
            {
                var entity = _context.Entry(user.CastDtoToUserTable());
                entity.State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return (true, "User's informations updated successfully");
            }
            catch (Exception ex)
            {
                await Logger.ExeptionLog(ex);
                return (false, ex.Message);
            }
        }
        public async Task<(bool, string)> Transfer(BankAccountDto senderBankAccount, BankAccountDto targetBankAccount, string explanation, decimal amount)
        {
            using (InvestmentDbContext context = new InvestmentDbContext())
            {
                try
                {
                    if (senderBankAccount.ID != targetBankAccount.ID)
                    {
                        if (senderBankAccount.Currency == targetBankAccount.Currency)
                        {
                            if (senderBankAccount.Balance >= amount)
                            {
                                await TransferLog(senderBankAccount, targetBankAccount, explanation, senderBankAccount.Currency, amount);

                                return (true, "Transfer successful");
                            }
                            return (false, "Insufficient balance");
                        }
                        return (false, "Your account' s currency type and target account' s currency type does not match");
                    }
                    return (false, "You can not send money to yourself");
                }
                catch (Exception ex)
                {
                    return (false, ex.Message);
                }
            }  
        }
        public async Task<(bool, string)> BackTransfer(UserInvestmentDto userInvestmentDto)
        {
            using (InvestmentDbContext context = new InvestmentDbContext())
            {
                try
                {
                    var entity = context.Entry(userInvestmentDto.CastDtoToUserInvestment());
                    entity.State = EntityState.Modified;
                    await context.SaveChangesAsync();
                    return (true, "Process completed successfully.");
                }
                catch (Exception ex)
                {
                    return (false, ex.Message);
                }
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // GetObject();GetObject();GetObject();GetObject();GetObject();GetObject();GetObject();GetObject();GetObject();GetObject();GetObject();GetObjec
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public async Task<UserDto> GetUserFromID(int id)
        {
            var user = await _context.UserTables.FirstOrDefaultAsync(t => t.ID == id);

            if (user == null)
                return null;

            return user.CastUserTableToDto();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // GetTable();GetTable();GetTable();GetTable();GetTable();GetTable();GetTable();GetTable();GetTable();GetTable();GetTable();GetTable();GetTable
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public List<CurrencyModel> GetCurrencyTable()
        {
            MBData mBData = GetMbCurrency.PriceList;
            List<CurrencyModel> list = new List<CurrencyModel>();
            foreach (var currency in mBData.Currencies)
            {
                CurrencyModel currencyModel = new CurrencyModel
                {
                    CurrencyCode = currency.CurrencyName,
                    BanknoteBuying = currency.BanknoteBuying,
                    BanknoteSelling = currency.BanknoteSelling,
                };
                if (currencyModel.BanknoteBuying != "" || currencyModel.BanknoteSelling != "")
                {
                    list.Add(currencyModel);
                }
            }
            return list;
        }
        public Task<List<BankAccountDto>> GetUserBankAccounts(int id)
        {
            return _context.BankAccounts
                .Select(x => new BankAccountDto { ID = x.ID, UserId = x.UserId, AccountName = x.AccountName, IBAN = x.IBAN, Currency = (CurrencyTypes)x.Currency, Balance = x.Balance })
                .Where(x => x.UserId == id)
                .ToListAsync();
        }
        public Task<List<UserInvestmentDto>> GetUserInvestmentLog(int id)
        {
            return _context.UserInvestments
                .Select(x => new UserInvestmentDto { ID = x.ID, EffecterID = x.EffecterID, AffectedID = x.AffectedID, Date = x.Date, Action = (LogAction)x.Action, Explanation = x.Explanation, Currency = (CurrencyTypes)x.Currency, Amount = x.Amount, SenderBankAccountId = x.SenderBankAccountId, TargetBankAccountId = x.TargetBankAccountId })
                .Where(x => (x.EffecterID == id || x.AffectedID == id) && x.Action != LogAction.transferDelete)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
        public Task<List<LogDto>> GetLogTable()
        {
            return _context.Logs
                .Select(x => new LogDto { ID = x.ID, EffecterID = x.EffecterID, AffectedID = x.AffectedID, Date = x.Date, Action = (LogAction)x.Action, Explanation = x.Explanation })
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
        public Task<List<UserDto>> GetUserTable()
        {
            return _context.UserTables
                .Select(x => new UserDto { ID = x.ID, Name = x.Name, Surname = x.Surname, Username = x.Username, Password = x.Password, RegisterDate = x.RegisterDate, Permission = (Permissions)x.Permission })
                .ToListAsync();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Lo
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public async Task Log(LogAction action, string explanation, int? effecterID = null, int? affecterID = null)
        {
            _context.Logs.Add(new LogDto
            {
                Action = action,
                Explanation = explanation,
                EffecterID = effecterID,
                AffectedID = affecterID,
                Date = DateTime.Now,
            }.CastDtoTolog());
            await _context.SaveChangesAsync();
        }
        public async Task TransferLog(BankAccountDto senderBankAccount, BankAccountDto targetBankAccount, string explanation, CurrencyTypes currency, decimal amount)
        {
            string logMessage = $"{senderBankAccount.Currency}{Convert.ToString(amount)} tranfered from {senderBankAccount.UserId} ({senderBankAccount.AccountName}) to {targetBankAccount.UserId} ({targetBankAccount.AccountName}) ===>" + Environment.NewLine + explanation;

            _context.UserInvestments.Add(new UserInvestmentDto
            {
                Action = LogAction.transfer,
                EffecterID = senderBankAccount.UserId,
                SenderBankAccountId = senderBankAccount.ID,
                AffectedID = targetBankAccount.UserId,
                TargetBankAccountId = targetBankAccount.ID,
                Date = DateTime.Now,
                Explanation = logMessage,
                Currency = currency,
                Amount = amount 
            }.CastDtoToUserInvestment());
            await _context.SaveChangesAsync();
        }
    }
}