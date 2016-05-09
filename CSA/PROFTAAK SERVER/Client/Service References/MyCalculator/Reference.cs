﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.MyCalculator {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="MyCalculatorContract", ConfigurationName="MyCalculator.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="MyCalculatorContract/ICalculator/Add", ReplyAction="MyCalculatorContract/ICalculator/AddResponse")]
        double Add(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyCalculatorContract/ICalculator/Add", ReplyAction="MyCalculatorContract/ICalculator/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyCalculatorContract/ICalculator/Substract", ReplyAction="MyCalculatorContract/ICalculator/SubstractResponse")]
        double Substract(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyCalculatorContract/ICalculator/Substract", ReplyAction="MyCalculatorContract/ICalculator/SubstractResponse")]
        System.Threading.Tasks.Task<double> SubstractAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyCalculatorContract/ICalculator/Multiply", ReplyAction="MyCalculatorContract/ICalculator/MultiplyResponse")]
        double Multiply(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyCalculatorContract/ICalculator/Multiply", ReplyAction="MyCalculatorContract/ICalculator/MultiplyResponse")]
        System.Threading.Tasks.Task<double> MultiplyAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyCalculatorContract/ICalculator/Divide", ReplyAction="MyCalculatorContract/ICalculator/DivideResponse")]
        double Divide(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyCalculatorContract/ICalculator/Divide", ReplyAction="MyCalculatorContract/ICalculator/DivideResponse")]
        System.Threading.Tasks.Task<double> DivideAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="MyCalculatorContract/ICalculator/getNrOfCalculations", ReplyAction="MyCalculatorContract/ICalculator/getNrOfCalculationsResponse")]
        int getNrOfCalculations();
        
        [System.ServiceModel.OperationContractAttribute(Action="MyCalculatorContract/ICalculator/getNrOfCalculations", ReplyAction="MyCalculatorContract/ICalculator/getNrOfCalculationsResponse")]
        System.Threading.Tasks.Task<int> getNrOfCalculationsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : Client.MyCalculator.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<Client.MyCalculator.ICalculator>, Client.MyCalculator.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double n1, double n2) {
            return base.Channel.Add(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double n1, double n2) {
            return base.Channel.AddAsync(n1, n2);
        }
        
        public double Substract(double n1, double n2) {
            return base.Channel.Substract(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> SubstractAsync(double n1, double n2) {
            return base.Channel.SubstractAsync(n1, n2);
        }
        
        public double Multiply(double n1, double n2) {
            return base.Channel.Multiply(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplyAsync(double n1, double n2) {
            return base.Channel.MultiplyAsync(n1, n2);
        }
        
        public double Divide(double n1, double n2) {
            return base.Channel.Divide(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> DivideAsync(double n1, double n2) {
            return base.Channel.DivideAsync(n1, n2);
        }
        
        public int getNrOfCalculations() {
            return base.Channel.getNrOfCalculations();
        }
        
        public System.Threading.Tasks.Task<int> getNrOfCalculationsAsync() {
            return base.Channel.getNrOfCalculationsAsync();
        }
    }
}