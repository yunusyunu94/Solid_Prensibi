using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Princilbe.Ornek3
{
    public interface ISmsSendable
    {
        void SendTripInfoSmsToDriver(DriveInfo driver);
    }
}
