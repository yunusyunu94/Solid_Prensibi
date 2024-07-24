using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Prensibi.Open_Closed_Principle.Ornek1
{
    public class İdeal_Code
    {
        public class ParaGonderici2
        {
            public void Gonder(IBanka banka, int tutar, string hesapNo)
            {
                banka.ParaTransferi(tutar, hesapNo);
            }
        }

        public interface IBanka
        {
            bool ParaTransferi(int tutar, string hesapNo);
        }

        public class Garanti : IBanka
        {
            public string HesapNo { get; set; }
            public void ParaGonder(int tutar)
            {
                //...
            }

            public bool ParaTransferi(int tutar, string hesapNo)
            {
                try
                {

                    HesapNo = hesapNo;
                    ParaGonder(tutar);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        class Halkbank : IBanka
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

            public bool ParaTransferi(int tutar, string hesapNo)
            {
                try
                {
                    GonderilecekHesapNo(hesapNo);
                    Gonder(tutar);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        class AhmetBank : IBanka
        {
            public bool ParaTransferi(int tutar, string hesapNo)
            {
                throw new NotImplementedException();
            }
        }
    }
}
