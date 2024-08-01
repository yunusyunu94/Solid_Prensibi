using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Princilbe.Ornek2
{
    public class Mercedes : Car, IKlima
    {
        public string klima()
        {
            return "Mercedesin kliması calıştı";
        }
    }
}
