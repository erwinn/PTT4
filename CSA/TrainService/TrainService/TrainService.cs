using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TrainService
{

    public class TrainService : ITrainService
    {
        public void Error()
        {
            throw new NotImplementedException();
        }

        public string MessageBuilder(int value, string MessageType)
        {
            throw new NotImplementedException();
        }

        public bool MessageCollect()
        {
            throw new NotImplementedException();
        }

        public void MessageSendArduino(string message)
        {
            throw new NotImplementedException();
        }

        public void MessageSendPLC(string message)
        {
            throw new NotImplementedException();
        }
    }
}
