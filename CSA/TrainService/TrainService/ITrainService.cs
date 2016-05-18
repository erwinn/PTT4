using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TrainService
{
    [ServiceContract]
    public interface ITrainService
    {
        string MessageBuilder(int value, string MessageType);

        bool MessageCollect();

        void MessageSendArduino(string message);

        void MessageSendPLC(string message);

        void Error();
    }
}
