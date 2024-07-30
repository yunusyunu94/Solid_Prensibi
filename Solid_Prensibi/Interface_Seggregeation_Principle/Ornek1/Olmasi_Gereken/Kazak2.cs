using Interface_Seggregeation_Principle.Ornek1;
using Interface_Seggregeation_Principle.Ornek1.Olmasi_Gereken;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Seggregeation_Principle.Ornek11.Ornek1
{
    class Kazak2 : IKiyafet2
    {
        public int ID { get; set; }
        public string Tur { get; set; }
        public string Renk { get; set; }
        public double Fiyat { get; set; }
        public char Size { get; set; }
        public string Yaka { get; set; }

        public string Ozellik1 { get; set; }
    }
}
