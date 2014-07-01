﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Accounting_System.InternalUserServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InternalUserServiceReference.IInternalUserService")]
    public interface IInternalUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalUserService/NewUser", ReplyAction="http://tempuri.org/IInternalUserService/NewUserResponse")]
        void NewUser(Oleit.AS.Service.DataObject.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalUserService/NewUserCollection", ReplyAction="http://tempuri.org/IInternalUserService/NewUserCollectionResponse")]
        void NewUserCollection(Oleit.AS.Service.DataObject.User[] collection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalUserService/CheckPassword", ReplyAction="http://tempuri.org/IInternalUserService/CheckPasswordResponse")]
        int CheckPassword(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalUserService/SetRole", ReplyAction="http://tempuri.org/IInternalUserService/SetRoleResponse")]
        void SetRole(string userName, Oleit.AS.Service.DataObject.Role role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalUserService/CheckRole", ReplyAction="http://tempuri.org/IInternalUserService/CheckRoleResponse")]
        bool CheckRole(string userName, Oleit.AS.Service.DataObject.Role role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalUserService/GetAllRoles", ReplyAction="http://tempuri.org/IInternalUserService/GetAllRolesResponse")]
        Oleit.AS.Service.DataObject.Role[] GetAllRoles(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalUserService/DisableUser", ReplyAction="http://tempuri.org/IInternalUserService/DisableUserResponse")]
        bool DisableUser(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalUserService/Disable", ReplyAction="http://tempuri.org/IInternalUserService/DisableResponse")]
        void Disable(Oleit.AS.Service.DataObject.User[] collection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalUserService/SetRelateEntity", ReplyAction="http://tempuri.org/IInternalUserService/SetRelateEntityResponse")]
        void SetRelateEntity(Oleit.AS.Service.DataObject.Relation relation);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalUserService/GetRelateEntity", ReplyAction="http://tempuri.org/IInternalUserService/GetRelateEntityResponse")]
        Oleit.AS.Service.DataObject.Relation[] GetRelateEntity(int entityID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalUserService/GetMenu", ReplyAction="http://tempuri.org/IInternalUserService/GetMenuResponse")]
        Oleit.AS.Service.DataObject.FuncMenu[] GetMenu(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalUserService/QueryADuser", ReplyAction="http://tempuri.org/IInternalUserService/QueryADuserResponse")]
        Oleit.AS.Service.DataObject.User[] QueryADuser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInternalUserService/QueryAlluser", ReplyAction="http://tempuri.org/IInternalUserService/QueryAlluserResponse")]
        Oleit.AS.Service.DataObject.User[] QueryAlluser();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInternalUserServiceChannel : Accounting_System.InternalUserServiceReference.IInternalUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InternalUserServiceClient : System.ServiceModel.ClientBase<Accounting_System.InternalUserServiceReference.IInternalUserService>, Accounting_System.InternalUserServiceReference.IInternalUserService {
        
        public InternalUserServiceClient() {
        }
        
        public InternalUserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InternalUserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InternalUserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InternalUserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void NewUser(Oleit.AS.Service.DataObject.User user) {
            base.Channel.NewUser(user);
        }
        
        public void NewUserCollection(Oleit.AS.Service.DataObject.User[] collection) {
            base.Channel.NewUserCollection(collection);
        }
        
        public int CheckPassword(string userName, string password) {
            return base.Channel.CheckPassword(userName, password);
        }
        
        public void SetRole(string userName, Oleit.AS.Service.DataObject.Role role) {
            base.Channel.SetRole(userName, role);
        }
        
        public bool CheckRole(string userName, Oleit.AS.Service.DataObject.Role role) {
            return base.Channel.CheckRole(userName, role);
        }
        
        public Oleit.AS.Service.DataObject.Role[] GetAllRoles(string userName) {
            return base.Channel.GetAllRoles(userName);
        }
        
        public bool DisableUser(int userID) {
            return base.Channel.DisableUser(userID);
        }
        
        public void Disable(Oleit.AS.Service.DataObject.User[] collection) {
            base.Channel.Disable(collection);
        }
        
        public void SetRelateEntity(Oleit.AS.Service.DataObject.Relation relation) {
            base.Channel.SetRelateEntity(relation);
        }
        
        public Oleit.AS.Service.DataObject.Relation[] GetRelateEntity(int entityID) {
            return base.Channel.GetRelateEntity(entityID);
        }
        
        public Oleit.AS.Service.DataObject.FuncMenu[] GetMenu(string userName) {
            return base.Channel.GetMenu(userName);
        }
        
        public Oleit.AS.Service.DataObject.User[] QueryADuser() {
            return base.Channel.QueryADuser();
        }
        
        public Oleit.AS.Service.DataObject.User[] QueryAlluser() {
            return base.Channel.QueryAlluser();
        }
    }
}