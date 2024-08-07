using Dependency_Inversion_Principle.Ornek3.İdeal_Olmayan_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek3.İdeal_Olan_Code
{
	public class AccountCreator2
	{
		private IAccountRepository _accountPepostory;

		public AccountCreator2(IAccountRepository accountRepository)
		{
			_accountPepostory = accountRepository;
		}

		public void SaveAccount(AccountModel2 accountModel2)
		{
			_accountPepostory.SaveAccount(new Account2(accountModel2));
		}
	}
}
