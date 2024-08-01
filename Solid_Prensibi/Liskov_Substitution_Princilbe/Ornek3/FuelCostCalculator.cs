using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle._4.Ornek
{
    public class FuelCostCalculator // Yakit giderini hesaplayan Class
    {
        //public double Calculater(MercedesBenz car)
        //{
        //    return car.TrimKM * 2;
        //}

        // Baska bir araba ekledigimizde ; BMW ile ilgili hesaplama yapicaksak eger yukaridaki MercedesBenz yerine
        // yukaridaki kodu silip assagidaki kodu yazicaz

        public double Calculater(BaseCar car)
        {
            //if (car is MercedesBenz)
            //{
            //    return car.TrimKM * 2;
            //}
            //else if (car is BMW)
            //{
            //    return car.TrimKM * 1.5;
            //}
            //else
            //    return car.TrimKM;

            // Yukaridaki kod open-close prensibine aykiri, Yeni bir arac
            // geldiginde bile bu class icerisinde bir degisiklik yapmamam gerek

            // Bunun icin ; BaseCar bir abstrac clas olmalı ve icinde
            // GetCostPerKm adinda bir metot tanimlamaliyiz

            return car.TrimKM * car.GetCostPerKm();
        
        
        }
    }
}
