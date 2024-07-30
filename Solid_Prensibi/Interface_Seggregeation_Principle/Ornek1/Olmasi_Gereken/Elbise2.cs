using Interface_Seggregeation_Principle.Ornek1.Olmasi_Gereken;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Seggregeation_Principle.Ornek1.Aykiri_Prensip
{
    public class Elbise2 : IKiyafet2
    {
        public int ID { get; set; }
        public string Tur { get; set; }
        public string Renk { get; set; }
        public double Fiyat { get; set; }
        public string EnBoy { get; set; }
        public char Size { get; set; }
        public string Desen { get; set; }
        public string Kumas { get; set; }

    }
}
