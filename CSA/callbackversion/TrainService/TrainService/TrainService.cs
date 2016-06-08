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
        SerialClass serialClass;
        List<ICallback> subscribers = new List<ICallback>();
        public TrainService()
        {
            serialClass = new SerialClass(this);
            Debug.WriteLine("constructor TrainService() ");
            serialClass.Connect();
        }
        public void Error()
        {
            throw new NotImplementedException();
        }
        public int GetSensorValue(int sensor)
        {
            if (serialClass.getSensorArray().Length >= sensor)
            {
                return serialClass.getSensorArray()[sensor - 1];
            }
            else
            {
                throw new ArgumentOutOfRangeException("LdrId", sensor, "You looked outside the array, returned error");
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

        public void Subscribe()
        {
            subscribers.Add(OperationContext.Current.GetCallbackChannel<ICallback>());
        }
        public void UnSubscribe()
        {
            subscribers.Remove(OperationContext.Current.GetCallbackChannel<ICallback>());
        }

        public void Callback()
        {
            Debug.WriteLine("callback");
            for (int i = 0; i < subscribers.Count; i++)
            {
                subscribers[i].OnEvent("danger detected");
            }
        }
    }
}
