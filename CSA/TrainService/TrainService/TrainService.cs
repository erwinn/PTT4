using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Diagnostics;
namespace TrainService
{
    
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class TrainService : ITrainService
    {
        SerialClass serialClass = new SerialClass();
     
        public TrainService()
        {
            Debug.WriteLine("constructor TrainService() ");
            serialClass.Connect();
        }
        public void Error()
        {
            throw new NotImplementedException();
        }
        public int getLrdValue(int ldrId)
        {
            if(ldrId==1)
            {
                return serialClass.getSensorArray()[0];
            }
            else if (ldrId == 2)
            {
                return serialClass.getSensorArray()[1];
            }
            return 0;
        }
        public string MessageBuilder(int id, int value, string MessageType)
        {
            MessageSendArduino(MessageType + IntToLetters(id) + value);
            return MessageType + IntToLetters(id) + value;
            //throw new NotImplementedException();
        }

        public bool MessageCollect()
        {
            throw new NotImplementedException();
        }

        public void MessageSendArduino(string message)
        {
            serialClass.sendCmd(message);
          
          //  throw new NotImplementedException();
        }
        public void MessageSendPLC(string message)
        {
            throw new NotImplementedException();
        }
        private string IntToLetters(int value)
        {
            string result = string.Empty;
            while (--value >= 0)
            {
                result = (char)('A' + value % 26) + result;
                value /= 26;
            }
            return result;
        }
    }
}
