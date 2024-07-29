using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Princilbe.Ornek1
{


    // Link : https://www.youtube.com/watch?v=URpeK0eiANU&ab_channel=Gen%C3%A7ayY%C4%B1ld%C4%B1z




    public class İdeal_Code
    {
        public abstract class Clound
        {
            public abstract void MachineLearning();
        }

        public interface ITranslatable
        {
            void Translate();
        }



        public class AWS : Clound, ITranslatable
        {

            public void Translate()
            => Console.WriteLine("AWS Translate");

            public override void MachineLearning()
            => Console.WriteLine("AWS Machine Learning");

        }

        public class Azure : Clound
        {

            public override void MachineLearning()
            => Console.WriteLine("Azure Machine Learning");

        }

        public class Google : Clound, ITranslatable
        {
            public void Translate()
            => Console.WriteLine("Google Translate");

            public override void MachineLearning()
            => Console.WriteLine("Google Machine Learning");


        }
    }
}
