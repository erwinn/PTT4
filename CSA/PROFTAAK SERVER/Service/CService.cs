using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyServiceContract;
using System.ServiceModel;

namespace Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CService : IArduino, IPLC
    {
        public string RecieveMessage()
        {
            throw new NotImplementedException();
        }

        public string SendMessage(string message)
        {
            throw new NotImplementedException();
        }

        public string MessageBuilder(int value, string messageType)
        {
            return "erwin is een flikkertje";
        }

        public bool MessageCollect()
        {
            return true;
        }

        public void MessageSendArduino(string message)
        {

        }

        public void MessageSendPLC(string message)
        {

        }

        public void Error()
        {

        }
    }
}
