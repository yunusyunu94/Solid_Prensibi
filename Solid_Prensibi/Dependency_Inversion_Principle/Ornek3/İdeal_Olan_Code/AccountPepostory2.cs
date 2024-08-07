using Dependency_Inversion_Principle.Ornek3.İdeal_Olan_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek3.İdeal_Olmayan_Code
{
    public class AccountPepostory2
    {
        public void SaveAccount(Account2 account) { }

        public Account2 GetAccount(int accountId)
        {
            return null;
        }
    }
}
