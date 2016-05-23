using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TrainService
{
    
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class TrainService : ITrainService
    {
        SerialClass serialClass = new SerialClass();
     
        public void Error()
        {
            throw new NotImplementedException();
        }

        public string MessageBuilder(int id, int value, string MessageType)
        {

            throw new NotImplementedException();
        }

        public bool MessageCollect()
        {
            throw new NotImplementedException();
        }

        public void MessageSendArduino(string message)
        {
            serialClass.sendCmd(message);
            
            throw new NotImplementedException();
        }

        public void MessageSendPLC(string message)
        {
            throw new NotImplementedException();
        }
    }
}
