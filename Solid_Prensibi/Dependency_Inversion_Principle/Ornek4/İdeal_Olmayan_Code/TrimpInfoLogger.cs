using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek4.İdeal_Olmayan_Code
{
    // Aracta olusan bazi problemleri veya seyahat bilgilerini logluyoruz

    public class TrimpInfoLogger
    {
        public void LogToGermany(string tripInfo)
        {
            //var d = new GermanyLogger();
            //d.Log(tripInfo);

            new GermanyLogger().Log(tripInfo);

        }

        public void LogToLocalStorage(string loginfo)
        {
            new LocalStorageLogger().Log(loginfo);
        }

        public class GermanyLogger
        {
            public void Log(string logStr)
            {
                // Send the date to the Germeny
            }
        }

        public class LocalStorageLogger
        {
            public void Log(string logStr)
            {
                // Send the date to the Germeny
            }
        }

    }
}
