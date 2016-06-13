using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TrainClient.TrainService;
using System.Windows;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
namespace TrainClient
{
    public class Client:TrainService.ITrainServiceCallback
    {
        private TrainServiceClient proxy;

        public Client()
        {
            ITrainServiceCallback callback = this;
            InstanceContext context = new InstanceContext(callback);
            proxy = new TrainServiceClient(context);
        }

        public void Refresh()
        {

        }

        public void Run(int trainId)
        {
            string message = proxy.MessageBuilder(trainId, 1, "ArduinoStartTrain");
        }

        public bool SwitchTrack(int id, int state)
        {
            string message = proxy.MessageBuilder(id, state, "ArduinoSwitchTrack");
            return true;
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
        public void OnEvent(string message)
        {
            Debug.WriteLine("callback");
            Thread t = new Thread(() => MessageBox.Show(message));
            t.Start();
           
            
        }
        public void Subscribe()
        {
            proxy.Subscribe();
        }
        public void Unsubscribe()
        {
            proxy.UnSubscribe();
        }
    }
}
