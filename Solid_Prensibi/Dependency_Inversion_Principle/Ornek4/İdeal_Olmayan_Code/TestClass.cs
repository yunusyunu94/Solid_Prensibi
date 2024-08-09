using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek4.İdeal_Olmayan_Code
{
    public class TestClass
    {
        public void RunCars()
        {
            try
            {
                var mercedes = new MercedesBenzin();
                mercedes.Go();
                mercedes.Stop();
                mercedes.SendTrimpInfoEmailToDriver(new DriverInfo());


            }
            catch (ExecutionEngineException ex) // Motor arzası
            {

                new TrimpInfoLogger().LogToGermany(ex.Message);
            }
            catch (Exception ex)
            {
                new TrimpInfoLogger().LogToLocalStorage(ex.Message);
            }
        }
    }
}
