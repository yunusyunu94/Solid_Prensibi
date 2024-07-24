using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Prensibi.Open_Closed_Principle.Ornek1
{
    public class İdeal_Olmayan_Code
    {
        public class ParaGonderici
        {
            public void Gonder(int tutar)
            {
                Garanti garanti = new();
                garanti.HesapNo = "...";
                garanti.ParaGonder(tutar);

                Halkban halkban = new();
                halkban.GonderilecekHesapNo("123");
                halkban.Gonder(tutar);

                Ahmet ahmet =new();
                ahmet.HesapNo = "asdfdsa";
            }

            class Garanti
            {
                public string HesapNo { get; set; }
                public void ParaGonder(int tutar)
                {
                    //...
                }
            }
            class Halkban
            {
                string _hesapNo;
                public void GonderilecekHesapNo(string hesapNo)
                {
                    //...
                }
                public void Gonder(int tutar)
                {
                    //...
                }
            }

            class Ahmet
            {
                public string HesapNo { get; set; }
        }
    }
}
