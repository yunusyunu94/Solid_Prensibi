using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek3.İdeal_Olmayan_Code
{
    public class AccountCreator // Heaap olusturan sınıf
    {
        private AccountPepostory _accountPepostory = new();

        public void SaveAccount(AccountModel accountModel)
        {
            _accountPepostory.SaveAccount(new Account(accountModel));
        }
    }
}
