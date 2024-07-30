using Interface_Seggregeation_Principle.Ornek11.Ornek1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Seggregeation_Principle.Ornek1.Aykiri_Prensip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kazak k = new();
            k.ID = 1;
            k.Tur = "Erkek Kazak";
            k.Renk = "Mavi";

            k.EnBoy = " "; // Kazagin boyle bir seye ihtiyaci yok o yuzden
                           // SOLİD'DE aykiri bir durum

            Pantolon p = new();

            p.ID = 2;
            p.Size = 'a'; // Pantolon boyle bir seye ihtiyaci yok o yuzden
                          // SOLİD'DE aykiri bir durum
        }
    }
}
