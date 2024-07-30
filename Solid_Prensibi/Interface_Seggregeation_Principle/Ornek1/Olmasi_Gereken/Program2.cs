using Interface_Seggregeation_Principle.Ornek11.Ornek1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Seggregeation_Principle.Ornek1.Olmasi_Gereken
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Kazak k = new();
            k.ID = 1;
            k.Tur = "Erkek Kazak";
            k.Renk = "Mavi";

            Pantolon p = new();

            p.ID = 2;
            p.Tur = "Kadın Pantolon";
            p.Renk = "Mavi";

            Console.WriteLine(k.ID);
            Console.WriteLine(k.Tur);
            Console.WriteLine(k.Renk);

            Console.ReadLine();
        }
    }
}
