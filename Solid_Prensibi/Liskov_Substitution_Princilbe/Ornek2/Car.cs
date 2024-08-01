using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Princilbe.Ornek2
{
    public abstract class Car
    {
        public string Start()
        {
            return "Arabamız çalıstı";
        }


        // Klimayı Interfacede tanımladık

        //public abstract string Klima();
    }
}
