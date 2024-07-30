using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Seggregeation_Principle.Ornek1.Olmasi_Gereken
{
    public interface IKiyafet2
    {
        // Kazak Pantolon Elbise

        int ID { get; set; }
        string Tur { get; set; }
        string Renk { get; set; }
        double Fiyat { get; set; }
        Char Size { get; set; }
    }
}
