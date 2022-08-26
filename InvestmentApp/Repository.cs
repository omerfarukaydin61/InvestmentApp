using InvestmentApp.Entities;
using InvestmentApp.Entities.Classes;
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
        public bool Login(string username, string password)
        {
            try
            {
                UserTable userTable = _context.UserTables.FirstOrDefault(x => x.Username == username && x.Password == password);
                if (userTable != null)
                {
                    ConfigModel.RegisteredUser = userTable.CastUserTableToUserDto();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Logger.ExeptionLog(ex);
                return false;
            }
        }
        public (bool, string) Add(UserDto user)
        {
            try
            {
                if (!_context.UserTables.Any(x => x.Username == user.Username))
                {
                    _context.UserTables.Add(user.CastUserDtoToUserTable());
                    _context.SaveChanges();
                    return (true, "User added successfully");
                }
                else
                {
                    return (false, "These username has been taken");
                }
            }
            catch (Exception ex)
            {
                Logger.ExeptionLog(ex);
                return (false, ex.Message);
            }
        }
        public (bool, string) Delete(UserDto user)
        {
            try
            {
                if (ConfigModel.RegisteredUser.ID != user.ID)
                {
                    var entity = _context.Entry(user.CastUserDtoToUserTable());
                    entity.State = EntityState.Deleted;
                    _context.SaveChanges();
                    return (true, "User deleted");
                }
                else
                {
                    return (false, "You can not delete yourself");
                }
            }
            catch (Exception ex)
            {
                Logger.ExeptionLog(ex);
                return (false, ex.Message);
            }
        }
        public (bool, string) Update(UserDto user)
        {
            try
            {
                var entity = _context.Entry(user.CastUserDtoToUserTable());
                entity.State = EntityState.Modified;
                _context.SaveChanges();
                return (true, "User's informations updated successfully");
            }
            catch (Exception ex)
            {
                Logger.ExeptionLog(ex);
                return (false, ex.Message);
            }
        }
        public (bool, string) ttTransfer(BankAccount senderBankAccount, BankAccount targetBankAccount, decimal amount)
        {
            try
            {
                if (senderBankAccount.Currency == targetBankAccount.Currency)
                {
                    if (senderBankAccount.Balance >= amount)
                    {
                        senderBankAccount.Balance -= amount;
                        targetBankAccount.Balance += amount;

                        _context.Entry(senderBankAccount).State = EntityState.Modified;
                        _context.Entry(targetBankAccount).State = EntityState.Modified;
                        _context.SaveChanges();

                        return (true, "Transfer successful");
                    }
                    return (false, "Insufficient balance");
                }
                return (false, "Your account' s currency type and target account' s currency type does not match");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public (bool, string) Transfer(int senderId, string senderIBAN, int targetId, string targetIBAN, CurrencyTypes currencyType, decimal amount)
        {
            try
            {
                BankAccount senderBankAccount = _context.BankAccounts.FirstOrDefault(x => x.UserId == senderId && x.IBAN == senderIBAN);
                if (senderBankAccount != null)
                {
                    if (senderBankAccount.Currency == currencyType)
                    {
                        BankAccount targetBankAccount = _context.BankAccounts.FirstOrDefault(x => x.UserId == targetId && x.IBAN == targetIBAN);
                        if (targetBankAccount != null)
                        {
                            if (senderBankAccount.Balance >= amount)
                            {
                                senderBankAccount.Balance -= amount;
                                targetBankAccount.Balance += amount;

                                _context.Entry(senderBankAccount).State = EntityState.Modified;
                                _context.Entry(targetBankAccount).State = EntityState.Modified;
                                _context.SaveChanges();

                                return (true, "Transfer successful");
                            }
                            return (false, "Insufficient balance");
                        }
                        return (false, "Wrong target user");
                    }
                    return (false, "Wrong currency type");
                }
                return (false, "Invalid user");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        //public bool Validation(string username, string password)
        //{
        //    try
        //    {
        //        ConnectionControl();
        //        string cmd = $"SELECT TOP (1) [ID],[UserName],[Password] FROM [InvestmentDb].[dbo].[UserTable] where [UserName]='{username}' and [Password]='{password}'";
        //        SqlCommand command = new SqlCommand(cmd, _connection);
        //        SqlDataReader reader = command.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            reader.Close();
        //            return true;
        //        }
        //        return false;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        _connection.Close();
        //    }
        //}
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // GetObject();GetObject();GetObject();GetObject();GetObject();GetObject();GetObject();GetObject();GetObject();GetObject();GetObject();GetObjec
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public async Task<UserDto> GetUserFromID(int id)
        {
            var user = await _context.UserTables.FirstOrDefaultAsync(t => t.ID == id);

            if (user == null)
                return null;

            return user.CastUserTableToUserDto();
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
        public  Task<List<BankAccount>> GetUserBankAccounts(int id)
        {
            return  _context.BankAccounts.Where(x => x.UserId == id).ToListAsync();
        }
        public Task<List<UserInvestment>> GetUserInvestmentLog(int id)
        {
            return _context.UserInvestments.Where(x => x.EffecterID == id).ToListAsync();
        }
        public Task<List<Log>> GetLogTable()
        {
            return _context.Logs.OrderByDescending(x => x.Date).ToListAsync();
        }
        public Task<List<UserDto>> GetUserTable()
        {
            return _context.UserTables.Select(x => new UserDto { ID = x.ID, Name = x.Name, Surname = x.Surname, Username = x.Username, Password = x.Password, RegisterDate = x.RegisterDate, Permission = x.Permission }).ToListAsync();
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Log();Lo
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public async void Log(LogAction action, string explanation, int? effecterID = null, int? affecterID = null)
        {
            _context.Logs.Add(new Log
            {
                Action = action,
                Explanation = explanation,
                EffecterID = effecterID,
                AffectedID = affecterID,
                Date = DateTime.Now,
            });
            await _context.SaveChangesAsync();
        }
        public async void TransferLog(LogAction action, string explanation, int effecterID, int affectedID, CurrencyTypes currency, decimal amount)
        {
            _context.UserInvestments.Add(new UserInvestment
            {
                Action = action,
                Explanation = explanation,
                EffecterID = effecterID,
                AffectedID = affectedID,
                Currency = currency,
                Amount = amount,
                Date = DateTime.Now, 
            });
            await _context.SaveChangesAsync();
        }
    }
}