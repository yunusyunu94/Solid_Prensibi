using Dependency_Inversion_Principle.Ornek4.İdeal_Olmayan_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dependency_Inversion_Principle.Ornek4.İdeal_Olan_Code.TrimpInfoLogger2;

namespace Dependency_Inversion_Principle.Ornek4.İdeal_Olan_Code
{

	// LİNK ; https://www.youtube.com/watch?v=oLVETlMyJZM


	public class TestClass2
	{
		public void RunCars()
		{
			try
			{
				var mercedes = new MercedesBenzin2();
				mercedes.Go();
				mercedes.Stop();
				mercedes.SendTrimpInfoEmailTDriver2(new DriverInfo());


			}
			catch (ExecutionEngineException ex) // Motor arzası
			{

				new TrimpInfoLogger2(new GermanyLogger2()).Log(ex.Message);
			}
			catch (Exception ex)
			{
				new TrimpInfoLogger2(new LocalStorageLogger2()).Log(ex.Message);
			}
		}
	}
}
