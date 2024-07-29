using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Princilbe.Ornek1
{
    public class İdeal_Olmayan_Code
    {
        public abstract class Clound // Clound; Bulut
        {
            public abstract void Translate();
            public abstract void MachineLearning();
        }

        public class AWS : Clound
        {

            public override void Translate()
            => Console.WriteLine("AWS Translate");

            public override void MachineLearning()
            => Console.WriteLine("AWS Machine Learning");

        }

        public class Azure : Clound
        {
            public override void Translate()
            => throw new NotImplementedException(); /// <summary>
                                                    /// 
                                                    /// </summary>


            public override void MachineLearning()
            => Console.WriteLine("Azure Machine Learning");

        }

        public class Google : Clound
        {
            public override void Translate()
            => Console.WriteLine("Google Translate");

            public override void MachineLearning()
            => Console.WriteLine("Google Machine Learning");


        }
    }
}
