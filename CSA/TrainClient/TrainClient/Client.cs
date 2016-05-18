using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TrainClient.TrainService;

namespace TrainClient
{
    public class Client
    {
        private TrainServiceClient proxy;

        public Client()
        {
            proxy = new TrainServiceClient();
        }

        public void Refresh()
        {

        }

        public void Run(bool state)
        {

        }

        public bool SwitchTrack(int id, bool state)
        {
           string message = proxy.MessageBuilder();
        }

        public void StopTrain(int trainId)
        {
           string message = proxy.MessageBuilder(trainId, "stop");
        }

        public bool WriteSensorState(bool state, int sensor)
        {
            return false;
        }
    }
}
