using System;
using System.ServiceModel;
using TrainClient.TrainService;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Net.NetworkInformation;

namespace TrainClient
{
    public enum SIGN
    {
        GO = 0,
        STOP = 1
    };

    public class Client : ITrainServiceCallback
    {
        private TrainServiceClient proxy;
        public bool connectionState;

        /// <summary>
        /// Constructor for the Client class
        /// </summary>
        public Client()
        {
            ITrainServiceCallback callback = this;
            InstanceContext context = new InstanceContext(callback);
            proxy = new TrainServiceClient(context);
            connectionState = false;
            TestConnection();
        }

        /// <summary>
        /// Switch the desired switch to the selected track
        /// </summary>
        /// <param name="switchId"></param>
        /// <param name="switchstate"></param>
        public void SetSwitch(SIGN switchstate)
        {
            if (!connectionState)
            {
                TestConnection();
            }
            else
            {
                proxy.MessageBuilder(1, (int)switchstate, "ArduinoSwitchSign");
            }
        }

        /// <summary>
        /// Stops the train when there is a connection 
        /// </summary>
        public void StopTrain()
        {
            if (!connectionState)
            {
                TestConnection();
            }
            else
            {
                string message = proxy.MessageBuilder(1, 0, "ArduinoStopTrain");
            }
        }

        /// <summary>
        /// Sets trainspeed throws exception when there's no connection
        /// </summary>
        /// <param name="value">sets the speed of the motor to the desired number</param>
        /// <returns>The string that is sent to the arduino</returns>
        public string SetTrainSpeed(int value)
        {
            if (value < 50 || value > 250)
            {
                throw new ArgumentOutOfRangeException("value");
            }

            if (!connectionState)
            {
                TestConnection();
                throw new CommunicationException("connection");
            }
            else
            {
                return proxy.MessageBuilder(1, value, "ArduinoSetSpeed");
            }
        }

        /// <summary>
        /// Reads Sensor data send by the can network
        /// </summary>
        /// <param name="SensorId"></param>
        /// <returns>the data or -1 on error</returns>
        public int ReadSensorState(int SensorId)
        {
            if(!connectionState)
            {
                TestConnection();
                return -1;
            }
            else
            { 
                return proxy.GetSensorValue(SensorId);
            }
        }

        /// <summary>
        /// Event called when the train is stopped because there is an item on the rails
        /// </summary>
        /// <param name="message">Message containing the error</param>
        public void StoppedTrain(string message)
        {
            Thread t = new Thread(() => MessageBox.Show(message));
            t.Start();
        }

        /// <summary>
        /// Subscribes to the event list in the server, doing this will enable you to receive events from the server
        /// </summary>
        /// <returns>false on error, true on success</returns>
        public bool Subscribe()
        {
            if (!connectionState)
            {
                TestConnection();
                return false;
            }
            else
            {
                proxy.Subscribe();
                return true;
            }
        }

        /// <summary>
        /// Unsubscribes to the event list in the server, doing this will disable you to receive events from the server 
        /// </summary>
        /// <returns>false on error, true on success</returns>
        public bool Unsubscribe()
        {
            if (!connectionState)
            {
                TestConnection();
                return false;
            }
            else
            {
                proxy.UnSubscribe();
                return true;
            }
        }

        /// <summary>
        /// Tests connection between client and server
        /// </summary>
        private void TestConnection()
        {
            try
            {
                Ping p = new Ping();
                PingReply reply = p.Send(proxy.Endpoint.Address.ToString());
                if (reply.Status == IPStatus.Success)
                {
                    connectionState = true;
                }
            }
            catch (PingException)
            {
                Debug.WriteLine("There's no connection to te server");
            }
        }
    }
}
