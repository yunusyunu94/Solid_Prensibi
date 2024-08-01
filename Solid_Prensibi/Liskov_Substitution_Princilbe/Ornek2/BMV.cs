using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Princilbe.Ornek2
{
    public class BMV : Car, IKlima
    {
        public string klima()
        {
            return "BMV için klima çalıştı";
        }
    }
}
