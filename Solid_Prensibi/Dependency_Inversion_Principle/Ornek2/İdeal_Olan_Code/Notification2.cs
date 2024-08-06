using Dependency_Inversion_Principle.Ornek2.İdeal_Olan_Code;
using Dependency_Inversion_Principle.Ornek2.İdeal_Olmayan_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Ornek2
{
    // Burada bir sinif daha eklersek Notification'da
    // degisiklik yapmamiz gerek

    public class Notification2
    {
        private ICollection<IMessage> _messages;

        public Notification2(ICollection<IMessage> messages)
        {
            this._messages = messages;
        }
        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
}
