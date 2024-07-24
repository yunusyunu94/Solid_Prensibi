using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Solid_Prensibi.Open_Closed_Principle.Ornek1.İdeal_Code;

namespace Solid_Prensibi.Open_Closed_Principle.Ornek1
{
    public class From
    {
        public void Mail(string[] strings)
        {
            ParaGonderici2 paraGonderici = new();


            paraGonderici.Gonder(new Garanti(), 100, "dfsdf");





            // Gın geldı gereksinim degisti Halkbank'kı kullanacaksın
            // tek yapman gerek ;

            paraGonderici.Gonder(new Halkbank(), 100, "dfsdf");
        }
    }
}
