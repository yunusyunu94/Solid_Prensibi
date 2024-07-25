using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Prensibi.Open_Closed_Principle.Ornek2
{
    public class Program
    {
        static void Mail(string[] strings)
        {
            CostomerManeger df = new(new BirinciMevzuat());
            df.add();
        }
    }


    public class CostomerManeger
    {
        private readonly IMevzuat _mevzuat;

        public CostomerManeger(IMevzuat mevzuat)
        {
            this._mevzuat = mevzuat;
            mevzuat.IslemYap();
        }
        public void add()
        {
            _mevzuat.IslemYap();
        }
    }

    public interface IMevzuat
    {
        void IslemYap();
    }

    public class BirinciMevzuat : IMevzuat
    {
        public void IslemYap()
        {
            Console.WriteLine("BirinciMevzuat");
        }
    }

    public class İkinciMevzuat : IMevzuat
    {
        public void IslemYap()
        {
            Console.WriteLine("İkinciMevzuat");
        }
    }
}
