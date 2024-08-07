using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek3.İdeal_Olmayan_Code
{
    public class AccountVerifier2
    {
        private AccountPepostory2 _accountPepostory = new();

        public bool VerifyAccount(int accountId)
        {
            return _accountPepostory.GetAccount(accountId) == null;
        }
    }
}
