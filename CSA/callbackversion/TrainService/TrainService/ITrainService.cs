﻿using System;
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
        [OperationContract]
        string MessageBuilder(int id, int value, string MessageType);

        [OperationContract]
        bool MessageCollect();

        [OperationContract]
        int GetSensorValue(int actuator);

        [OperationContract]
        void MessageSendArduino(string message);

        [OperationContract]
        void MessageSendPLC(string message);

        [OperationContract]
        void Error();

        [OperationContract]
        void Subscribe();
        [OperationContract]
        void UnSubscribe();

    }
    public interface ICallback
    {
        
        [OperationContract(IsOneWay = true)]
        void OnEvent(string message);
    }
}
