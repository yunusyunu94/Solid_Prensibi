using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek3.İdeal_Olmayan_Code
{
    public class AccountPepostory
    {
        public void SaveAccount(Account account) { }

        public Account GetAccount(int accountId)
        {
            return null;
        }
    }
}
