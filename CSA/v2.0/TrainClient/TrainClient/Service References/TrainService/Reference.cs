﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrainClient.TrainService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="TrainService", ConfigurationName="TrainService.ITrainService")]
    public interface ITrainService {
        
        [System.ServiceModel.OperationContractAttribute(Action="TrainService/ITrainService/MessageBuilder", ReplyAction="TrainService/ITrainService/MessageBuilderResponse")]
        string MessageBuilder(int id, int value, string MessageType);
        
        [System.ServiceModel.OperationContractAttribute(Action="TrainService/ITrainService/MessageBuilder", ReplyAction="TrainService/ITrainService/MessageBuilderResponse")]
        System.Threading.Tasks.Task<string> MessageBuilderAsync(int id, int value, string MessageType);
        
        [System.ServiceModel.OperationContractAttribute(Action="TrainService/ITrainService/MessageCollect", ReplyAction="TrainService/ITrainService/MessageCollectResponse")]
        bool MessageCollect();
        
        [System.ServiceModel.OperationContractAttribute(Action="TrainService/ITrainService/MessageCollect", ReplyAction="TrainService/ITrainService/MessageCollectResponse")]
        System.Threading.Tasks.Task<bool> MessageCollectAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="TrainService/ITrainService/GetSensorValue", ReplyAction="TrainService/ITrainService/GetSensorValueResponse")]
        int GetSensorValue(int actuator);
        
        [System.ServiceModel.OperationContractAttribute(Action="TrainService/ITrainService/GetSensorValue", ReplyAction="TrainService/ITrainService/GetSensorValueResponse")]
        System.Threading.Tasks.Task<int> GetSensorValueAsync(int actuator);
        
        [System.ServiceModel.OperationContractAttribute(Action="TrainService/ITrainService/MessageSendArduino", ReplyAction="TrainService/ITrainService/MessageSendArduinoResponse")]
        void MessageSendArduino(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="TrainService/ITrainService/MessageSendArduino", ReplyAction="TrainService/ITrainService/MessageSendArduinoResponse")]
        System.Threading.Tasks.Task MessageSendArduinoAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="TrainService/ITrainService/MessageSendPLC", ReplyAction="TrainService/ITrainService/MessageSendPLCResponse")]
        void MessageSendPLC(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="TrainService/ITrainService/MessageSendPLC", ReplyAction="TrainService/ITrainService/MessageSendPLCResponse")]
        System.Threading.Tasks.Task MessageSendPLCAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="TrainService/ITrainService/Error", ReplyAction="TrainService/ITrainService/ErrorResponse")]
        void Error();
        
        [System.ServiceModel.OperationContractAttribute(Action="TrainService/ITrainService/Error", ReplyAction="TrainService/ITrainService/ErrorResponse")]
        System.Threading.Tasks.Task ErrorAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITrainServiceChannel : TrainClient.TrainService.ITrainService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TrainServiceClient : System.ServiceModel.ClientBase<TrainClient.TrainService.ITrainService>, TrainClient.TrainService.ITrainService {
        
        public TrainServiceClient() {
        }
        
        public TrainServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TrainServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TrainServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TrainServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string MessageBuilder(int id, int value, string MessageType) {
            return base.Channel.MessageBuilder(id, value, MessageType);
        }
        
        public System.Threading.Tasks.Task<string> MessageBuilderAsync(int id, int value, string MessageType) {
            return base.Channel.MessageBuilderAsync(id, value, MessageType);
        }
        
        public bool MessageCollect() {
            return base.Channel.MessageCollect();
        }
        
        public System.Threading.Tasks.Task<bool> MessageCollectAsync() {
            return base.Channel.MessageCollectAsync();
        }
        
        public int GetSensorValue(int actuator) {
            return base.Channel.GetSensorValue(actuator);
        }
        
        public System.Threading.Tasks.Task<int> GetSensorValueAsync(int actuator) {
            return base.Channel.GetSensorValueAsync(actuator);
        }
        
        public void MessageSendArduino(string message) {
            base.Channel.MessageSendArduino(message);
        }
        
        public System.Threading.Tasks.Task MessageSendArduinoAsync(string message) {
            return base.Channel.MessageSendArduinoAsync(message);
        }
        
        public void MessageSendPLC(string message) {
            base.Channel.MessageSendPLC(message);
        }
        
        public System.Threading.Tasks.Task MessageSendPLCAsync(string message) {
            return base.Channel.MessageSendPLCAsync(message);
        }
        
        public void Error() {
            base.Channel.Error();
        }
        
        public System.Threading.Tasks.Task ErrorAsync() {
            return base.Channel.ErrorAsync();
        }
    }
}
