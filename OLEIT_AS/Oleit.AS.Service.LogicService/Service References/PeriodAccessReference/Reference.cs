﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oleit.AS.Service.LogicService.PeriodAccessReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PeriodAccessReference.IPeriodAccess")]
    public interface IPeriodAccess {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeriodAccess/Set1", ReplyAction="http://tempuri.org/IPeriodAccess/Set1Response")]
        void Set1(Oleit.AS.Service.DataObject.Period period);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeriodAccess/Set2", ReplyAction="http://tempuri.org/IPeriodAccess/Set2Response")]
        void Set2(Oleit.AS.Service.DataObject.Period[] periodCollection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeriodAccess/Query1", ReplyAction="http://tempuri.org/IPeriodAccess/Query1Response")]
        Oleit.AS.Service.DataObject.Period[] Query1(string periodNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeriodAccess/Query2", ReplyAction="http://tempuri.org/IPeriodAccess/Query2Response")]
        Oleit.AS.Service.DataObject.Period[] Query2(System.DateTime startDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeriodAccess/Query3", ReplyAction="http://tempuri.org/IPeriodAccess/Query3Response")]
        Oleit.AS.Service.DataObject.Period[] Query3(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeriodAccess/QueryAll", ReplyAction="http://tempuri.org/IPeriodAccess/QueryAllResponse")]
        Oleit.AS.Service.DataObject.Period[] QueryAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPeriodAccess/Query4", ReplyAction="http://tempuri.org/IPeriodAccess/Query4Response")]
        Oleit.AS.Service.DataObject.Period[] Query4(string Period, int flag);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPeriodAccessChannel : Oleit.AS.Service.LogicService.PeriodAccessReference.IPeriodAccess, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PeriodAccessClient : System.ServiceModel.ClientBase<Oleit.AS.Service.LogicService.PeriodAccessReference.IPeriodAccess>, Oleit.AS.Service.LogicService.PeriodAccessReference.IPeriodAccess {
        
        public PeriodAccessClient() {
        }
        
        public PeriodAccessClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PeriodAccessClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeriodAccessClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PeriodAccessClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Set1(Oleit.AS.Service.DataObject.Period period) {
            base.Channel.Set1(period);
        }
        
        public void Set2(Oleit.AS.Service.DataObject.Period[] periodCollection) {
            base.Channel.Set2(periodCollection);
        }
        
        public Oleit.AS.Service.DataObject.Period[] Query1(string periodNo) {
            return base.Channel.Query1(periodNo);
        }
        
        public Oleit.AS.Service.DataObject.Period[] Query2(System.DateTime startDate) {
            return base.Channel.Query2(startDate);
        }
        
        public Oleit.AS.Service.DataObject.Period[] Query3(int id) {
            return base.Channel.Query3(id);
        }
        
        public Oleit.AS.Service.DataObject.Period[] QueryAll() {
            return base.Channel.QueryAll();
        }
        
        public Oleit.AS.Service.DataObject.Period[] Query4(string Period, int flag) {
            return base.Channel.Query4(Period, flag);
        }
    }
}
