using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Seggregeation_Principle.Ornek1
{
    public interface IKiyafet
    {
        // Kazak Pantolon Elbise

        int ID  { get; set; }
        string Tur  { get; set; }
        string Renk  { get; set; }
        double Fiyat  { get; set; }
        string Yaka  { get; set; }
        string EnBoy  { get; set; }
        string Kesim  { get; set; }
        Char Size  { get; set; }
        string Desen  { get; set; }
    }
}
