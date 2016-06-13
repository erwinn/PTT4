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
    public enum Switch
    {
        Left = 0, Right = 1
    };
    public class Client:TrainService.ITrainServiceCallback
    {
        private TrainServiceClient proxy;

        /// <summary>
        /// Constructor for the Client class
        /// </summary>
        public Client()
        {
            ITrainServiceCallback callback = this;
            InstanceContext context = new InstanceContext(callback);
            proxy = new TrainServiceClient(context);
        }

        /// <summary>
        /// Switch the desired switch to the selected track
        /// </summary>
        /// <param name="switchId"></param>
        /// <param name="switchstate"></param>
        public void SetSwitch(int switchId, Switch switchstate)
        {
            proxy.MessageBuilder(switchId, (int)switchstate, "ArduinoSwitchTrack");
        }

        /// <summary>
        /// Stops the train  
        /// </summary>
        public void StopTrain()
        {
            string message = proxy.MessageBuilder(1, 0, "ArduinoStopTrain");
        }

        /// <summary>
        /// Return
        /// </summary>
        /// <param name="value">sets the speed of the motor to the desired number</param>
        /// <returns>The string that is sended to the arduino</returns>
        public string SetTrainSpeed(int value)
        {
            if (value < 50 || value > 250)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            return proxy.MessageBuilder(1, value, "ArduinoSetSpeed");
        }

        /// <summary>
        /// Reads Sensor data send by the can network
        /// </summary>
        /// <param name="SensorId"></param>
        /// <returns>the data</returns>
        public int ReadSensorState(int SensorId)
        {
            return proxy.GetSensorValue(SensorId);
        }

        /// <summary>
        /// Event called when the train is stopped because there is an item on the rails
        /// </summary>
        /// <param name="message">Message containing the error</param>
        public void StoppedTrain(string message)
        {
            Debug.WriteLine("callback");
            Thread t = new Thread(() => MessageBox.Show(message));
            t.Start();
        }

        /// <summary>
        /// Subscribes to the event list in the server, doing this will enable you to recieve events from the server
        /// </summary>
        public void Subscribe()
        {
            proxy.Subscribe();
        }

        /// <summary>
        /// Unsubscribes to the event list in the server, doing this will disable you to recieve events from the server 
        /// </summary>
        public void Unsubscribe()
        {
            proxy.UnSubscribe();
        }
    }
}
