using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainService
{
    interface IPlc
    {
        bool SendMessage(string message);

        string ReceivedMessage();
    }
}
