using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek4.İdeal_Olan_Code
{
	public class TrimpInfoLogger2
	{
		private readonly ILogger _logger;

		public TrimpInfoLogger2(ILogger logger)
		{
			this._logger = logger;
		}

		
		public void Log(string loginfo)
		{
			_logger.Log(loginfo);
		}





		public interface ILogger
		{
			void Log(string logStr);
		}



		public class GermanyLogger2 : ILogger
		{
			public void Log(string logStr)
			{
				// Send the date to the Germeny
			}
		}

		public class LocalStorageLogger2 : ILogger
		{
			public void Log(string logStr)
			{
				// Send the date to the Germeny
			}
		}
	}
}
