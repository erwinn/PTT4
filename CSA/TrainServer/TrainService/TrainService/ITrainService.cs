using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TrainService
{
    [ServiceContract(Namespace = "TrainService", CallbackContract = typeof(ICallback))]
    public interface ITrainService
    {
        /// <summary>
        /// Builds and sends a message to an arduino
        /// </summary>
        /// <param name="id">The ID of the arduino where a message is send to</param>
        /// <param name="value">The value of the Message, for instance speed of a motor</param>
        /// <param name="MessageType">The Message that needs to be send</param>
        /// <returns>The String Send to the arduino</returns>
        [OperationContract]
        string MessageBuilder(int id, int value, string MessageType);

        /// <summary>
        /// Not implemented
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        bool MessageCollect();

        /// <summary>
        /// Gets the current value of a sensor
        /// </summary>
        /// <param name="SensorID">the id of the requisted sensor</param>
        /// <returns>The value of the sensor requisted</returns>
        [OperationContract]
        int GetSensorValue(int SensorID);

        /// <summary>
        /// Sends the message to an arduino
        /// </summary>
        /// <param name="message">The String needed to be send to the arduino</param>
        [OperationContract]
        void MessageSendArduino(string message);

        /// <summary>
        /// Not implemented
        /// </summary>
        /// <param name="message"></param>
        [OperationContract]
        void MessageSendPLC(string message);

        /// <summary>
        /// Not implemented
        /// </summary>
        [OperationContract]
        void Error();

        /// <summary>
        /// Subscribes to the Event list
        /// </summary>
        [OperationContract]
        void Subscribe();

        /// <summary>
        /// UnSubscribes to the event list
        /// </summary>
        [OperationContract]
        void UnSubscribe();

    }
    public interface ICallback
    {
        /// <summary>
        /// Event Used when the train is stopped because of danger.
        /// </summary>
        /// <param name="message">message Explaining the event in greater detail</param>
        [OperationContract(IsOneWay = true)]
        void StoppedTrain(string message);
    }
}
