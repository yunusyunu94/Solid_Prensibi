using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek3.İdeal_Olan_Code
{
	public interface IAccountRepository
	{
		void SaveAccount(Account2 account2);

		Account2 GetAccount(int accountid);
	}
}
