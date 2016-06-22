using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TrainClient.TrainService;

namespace TrainClient
{
    public enum Switch
    {
        Left = 1, Right = 2
    };
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

        public void Run(int trainId)
        {
            string message = proxy.MessageBuilder(trainId, 1, "ArduinoStartTrain");
        }

        public void StopTrain(int trainId)
        {
            string message = proxy.MessageBuilder(trainId, 0, "ArduinoStopTrain");
        }

        public string WriteActuatorValue(int actuator, int value)
        {
            return proxy.MessageBuilder(actuator, value, "ArduinoSetSpeed");
        }

        public int ReadSensorState(int SensorId)
        {
            return proxy.GetSensorValue(SensorId);
        }
        public void SetSwitch(int switchId, Switch switchstate)
        {
            proxy.MessageBuilder(switchId, (int)switchstate, "ArduinoSwitchTrack");
        }

    }
}
