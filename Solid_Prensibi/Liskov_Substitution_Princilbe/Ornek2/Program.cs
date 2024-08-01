using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Princilbe.Ornek2
{
    // Link : https://www.youtube.com/watch?v=utEpHvQv3ok&ab_channel=MuratY%C3%BCceda%C4%9F


    public class Program
    {
        static void Main(string[] args) 
        {
            //Car car;
            //car = new BMV();
            //Console.WriteLine(car.Start);
            //Console.WriteLine(car.Klima());


            //car = new Mercedes();
            //Console.WriteLine(car.Start);
            //Console.WriteLine(car.Klima());


            //car = new Serce();
            //Console.WriteLine(car.Start);
            //Console.WriteLine(car.Klima()); // Hata dönecek cunku sercenın kliması yok

            //Console.ReadLine();


            //!!!!!! Yukarıdaki kodda Car sınıfındaki " klima " yı ayırmadan önceki nesne uretimiydi


            BMV bMV = new();
            Console.WriteLine(bMV.Start);
            Console.WriteLine(bMV.klima());

            Mercedes mercedes = new();
            Console.WriteLine(mercedes.Start);
            Console.WriteLine(mercedes.klima());


            Serce serce = new();
            Console.WriteLine(serce.Start);
        }


    }
}
