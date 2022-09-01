using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentApp.Entities.Enums
{
    public enum LogAction
    {
        invalid_login,
        login,
        logout,
        add,
        remove,
        update,
        exception,
        transfer
    }
}
