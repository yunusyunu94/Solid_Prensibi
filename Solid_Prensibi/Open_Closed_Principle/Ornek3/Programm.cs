using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle._3.Örnek
{
    public class Programm
    {
        static void Main(string[] arg)
        {
            Rectangle rc = new Rectangle(12,2);

            Console.WriteLine(rc.Area());



            Circle c = new(44.5);

            Console.WriteLine(c.Area());



            Console.ReadLine();
        }

    }
}
