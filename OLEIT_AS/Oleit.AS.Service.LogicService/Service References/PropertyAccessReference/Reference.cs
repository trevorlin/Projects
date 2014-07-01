﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oleit.AS.Service.LogicService.PropertyAccessReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PropertyAccessReference.IPropertyAccess")]
    public interface IPropertyAccess {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyAccess/Insert1", ReplyAction="http://tempuri.org/IPropertyAccess/Insert1Response")]
        void Insert1(Oleit.AS.Service.DataObject.Property property);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyAccess/Insert2", ReplyAction="http://tempuri.org/IPropertyAccess/Insert2Response")]
        void Insert2(Oleit.AS.Service.DataObject.Property[] propertyCollection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyAccess/Query1", ReplyAction="http://tempuri.org/IPropertyAccess/Query1Response")]
        Oleit.AS.Service.DataObject.Property[] Query1(int propertyID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyAccess/Query2", ReplyAction="http://tempuri.org/IPropertyAccess/Query2Response")]
        Oleit.AS.Service.DataObject.Property[] Query2(string propertyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyAccess/QueryAll", ReplyAction="http://tempuri.org/IPropertyAccess/QueryAllResponse")]
        Oleit.AS.Service.DataObject.Property[] QueryAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyAccess/Update1", ReplyAction="http://tempuri.org/IPropertyAccess/Update1Response")]
        void Update1(string propertyKey, Oleit.AS.Service.DataObject.Property property);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPropertyAccess/Update2", ReplyAction="http://tempuri.org/IPropertyAccess/Update2Response")]
        void Update2(Oleit.AS.Service.DataObject.Property[] propertyCollection);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPropertyAccessChannel : Oleit.AS.Service.LogicService.PropertyAccessReference.IPropertyAccess, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PropertyAccessClient : System.ServiceModel.ClientBase<Oleit.AS.Service.LogicService.PropertyAccessReference.IPropertyAccess>, Oleit.AS.Service.LogicService.PropertyAccessReference.IPropertyAccess {
        
        public PropertyAccessClient() {
        }
        
        public PropertyAccessClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PropertyAccessClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PropertyAccessClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PropertyAccessClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Insert1(Oleit.AS.Service.DataObject.Property property) {
            base.Channel.Insert1(property);
        }
        
        public void Insert2(Oleit.AS.Service.DataObject.Property[] propertyCollection) {
            base.Channel.Insert2(propertyCollection);
        }
        
        public Oleit.AS.Service.DataObject.Property[] Query1(int propertyID) {
            return base.Channel.Query1(propertyID);
        }
        
        public Oleit.AS.Service.DataObject.Property[] Query2(string propertyName) {
            return base.Channel.Query2(propertyName);
        }
        
        public Oleit.AS.Service.DataObject.Property[] QueryAll() {
            return base.Channel.QueryAll();
        }
        
        public void Update1(string propertyKey, Oleit.AS.Service.DataObject.Property property) {
            base.Channel.Update1(propertyKey, property);
        }
        
        public void Update2(Oleit.AS.Service.DataObject.Property[] propertyCollection) {
            base.Channel.Update2(propertyCollection);
        }
    }
}
