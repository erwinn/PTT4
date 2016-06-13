using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainService
{
    interface IArduino
    {
        bool SendMessage(string message);

        string ReceivedMessage();
    }
}
