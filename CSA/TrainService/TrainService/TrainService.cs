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
            if (serialClass.getSensorArray().Length >= ldrId)
            {
                return serialClass.getSensorArray()[ldrId + 1];
            }
            else
            {
                throw new ArgumentOutOfRangeException("LdrId", ldrId, "You looked outside the array, returned error");
            }
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
