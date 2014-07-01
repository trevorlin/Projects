﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Accounting_System.PeriodServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PeriodServiceReference.IPeriodService")]
    public interface IPeriodService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeriodService/SetPeriod", ReplyAction="http://tempuri.org/IPeriodService/SetPeriodResponse")]
        Oleit.AS.Service.DataObject.Period[] SetPeriod(int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeriodService/GetPeriods", ReplyAction="http://tempuri.org/IPeriodService/GetPeriodsResponse")]
        Oleit.AS.Service.DataObject.Period[] GetPeriods();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeriodService/PeriodByDate", ReplyAction="http://tempuri.org/IPeriodService/PeriodByDateResponse")]
        Oleit.AS.Service.DataObject.Period[] PeriodByDate(System.DateTime dateTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeriodService/DateOfPeriod", ReplyAction="http://tempuri.org/IPeriodService/DateOfPeriodResponse")]
        Oleit.AS.Service.DataObject.Period[] DateOfPeriod(string periodNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeriodService/GetNextorLast", ReplyAction="http://tempuri.org/IPeriodService/GetNextorLastResponse")]
        Oleit.AS.Service.DataObject.Period[] GetNextorLast(string PeriodNo, int flag);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeriodService/GetClosedPeriod", ReplyAction="http://tempuri.org/IPeriodService/GetClosedPeriodResponse")]
        Oleit.AS.Service.DataObject.Period[] GetClosedPeriod();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeriodService/GetCurrentPeriod", ReplyAction="http://tempuri.org/IPeriodService/GetCurrentPeriodResponse")]
        Oleit.AS.Service.DataObject.Period[] GetCurrentPeriod();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPeriodServiceChannel : Accounting_System.PeriodServiceReference.IPeriodService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PeriodServiceClient : System.ServiceModel.ClientBase<Accounting_System.PeriodServiceReference.IPeriodService>, Accounting_System.PeriodServiceReference.IPeriodService {
        
        public PeriodServiceClient() {
        }
        
        public PeriodServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PeriodServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeriodServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeriodServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Oleit.AS.Service.DataObject.Period[] SetPeriod(int year) {
            return base.Channel.SetPeriod(year);
        }
        
        public Oleit.AS.Service.DataObject.Period[] GetPeriods() {
            return base.Channel.GetPeriods();
        }
        
        public Oleit.AS.Service.DataObject.Period[] PeriodByDate(System.DateTime dateTime) {
            return base.Channel.PeriodByDate(dateTime);
        }
        
        public Oleit.AS.Service.DataObject.Period[] DateOfPeriod(string periodNo) {
            return base.Channel.DateOfPeriod(periodNo);
        }
        
        public Oleit.AS.Service.DataObject.Period[] GetNextorLast(string PeriodNo, int flag) {
            return base.Channel.GetNextorLast(PeriodNo, flag);
        }
        
        public Oleit.AS.Service.DataObject.Period[] GetClosedPeriod() {
            return base.Channel.GetClosedPeriod();
        }
        
        public Oleit.AS.Service.DataObject.Period[] GetCurrentPeriod() {
            return base.Channel.GetCurrentPeriod();
        }
    }
}
