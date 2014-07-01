﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oleit.AS.Service.LogicService.LimitControlAccessReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LimitControlAccessReference.ILimitControl")]
    public interface ILimitControl {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILimitControl/GetEntities", ReplyAction="http://tempuri.org/ILimitControl/GetEntitiesResponse")]
        Oleit.AS.Service.DataObject.Entity[] GetEntities(Oleit.AS.Service.DataObject.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILimitControl/GetAccounts", ReplyAction="http://tempuri.org/ILimitControl/GetAccountsResponse")]
        Oleit.AS.Service.DataObject.Account[] GetAccounts(Oleit.AS.Service.DataObject.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILimitControl/GetMenu", ReplyAction="http://tempuri.org/ILimitControl/GetMenuResponse")]
        Oleit.AS.Service.DataObject.FuncMenu[] GetMenu(Oleit.AS.Service.DataObject.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILimitControl/GetMenuByUserID", ReplyAction="http://tempuri.org/ILimitControl/GetMenuByUserIDResponse")]
        Oleit.AS.Service.DataObject.FuncMenu[] GetMenuByUserID(string UserID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILimitControl/getUserFunctions", ReplyAction="http://tempuri.org/ILimitControl/getUserFunctionsResponse")]
        System.Collections.Generic.Dictionary<int, string> getUserFunctions(string UserID, string MenuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILimitControl/getUserFunctionByMenuID", ReplyAction="http://tempuri.org/ILimitControl/getUserFunctionByMenuIDResponse")]
        System.Collections.Generic.Dictionary<int, string> getUserFunctionByMenuID(string MenuID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILimitControl/insertUserFunction", ReplyAction="http://tempuri.org/ILimitControl/insertUserFunctionResponse")]
        bool insertUserFunction(string UserID, string FunctionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILimitControl/insertMenuToRole", ReplyAction="http://tempuri.org/ILimitControl/insertMenuToRoleResponse")]
        bool insertMenuToRole(string MenuID, string RoleID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILimitControl/insertRoleToUser", ReplyAction="http://tempuri.org/ILimitControl/insertRoleToUserResponse")]
        bool insertRoleToUser(string UserID, string RoleID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILimitControl/deleteUserFunction", ReplyAction="http://tempuri.org/ILimitControl/deleteUserFunctionResponse")]
        bool deleteUserFunction(string UserID, string FunctionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILimitControl/getUserRole", ReplyAction="http://tempuri.org/ILimitControl/getUserRoleResponse")]
        string[] getUserRole(string userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILimitControl/isFunctionAuthorized", ReplyAction="http://tempuri.org/ILimitControl/isFunctionAuthorizedResponse")]
        bool isFunctionAuthorized(string UserID, string FunctionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILimitControl/CheckLimit", ReplyAction="http://tempuri.org/ILimitControl/CheckLimitResponse")]
        bool CheckLimit(Oleit.AS.Service.DataObject.User user, int itemID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILimitControlChannel : Oleit.AS.Service.LogicService.LimitControlAccessReference.ILimitControl, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LimitControlClient : System.ServiceModel.ClientBase<Oleit.AS.Service.LogicService.LimitControlAccessReference.ILimitControl>, Oleit.AS.Service.LogicService.LimitControlAccessReference.ILimitControl {
        
        public LimitControlClient() {
        }
        
        public LimitControlClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LimitControlClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LimitControlClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LimitControlClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Oleit.AS.Service.DataObject.Entity[] GetEntities(Oleit.AS.Service.DataObject.User user) {
            return base.Channel.GetEntities(user);
        }
        
        public Oleit.AS.Service.DataObject.Account[] GetAccounts(Oleit.AS.Service.DataObject.User user) {
            return base.Channel.GetAccounts(user);
        }
        
        public Oleit.AS.Service.DataObject.FuncMenu[] GetMenu(Oleit.AS.Service.DataObject.User user) {
            return base.Channel.GetMenu(user);
        }
        
        public Oleit.AS.Service.DataObject.FuncMenu[] GetMenuByUserID(string UserID) {
            return base.Channel.GetMenuByUserID(UserID);
        }
        
        public System.Collections.Generic.Dictionary<int, string> getUserFunctions(string UserID, string MenuID) {
            return base.Channel.getUserFunctions(UserID, MenuID);
        }
        
        public System.Collections.Generic.Dictionary<int, string> getUserFunctionByMenuID(string MenuID) {
            return base.Channel.getUserFunctionByMenuID(MenuID);
        }
        
        public bool insertUserFunction(string UserID, string FunctionID) {
            return base.Channel.insertUserFunction(UserID, FunctionID);
        }
        
        public bool insertMenuToRole(string MenuID, string RoleID) {
            return base.Channel.insertMenuToRole(MenuID, RoleID);
        }
        
        public bool insertRoleToUser(string UserID, string RoleID) {
            return base.Channel.insertRoleToUser(UserID, RoleID);
        }
        
        public bool deleteUserFunction(string UserID, string FunctionID) {
            return base.Channel.deleteUserFunction(UserID, FunctionID);
        }
        
        public string[] getUserRole(string userID) {
            return base.Channel.getUserRole(userID);
        }
        
        public bool isFunctionAuthorized(string UserID, string FunctionID) {
            return base.Channel.isFunctionAuthorized(UserID, FunctionID);
        }
        
        public bool CheckLimit(Oleit.AS.Service.DataObject.User user, int itemID) {
            return base.Channel.CheckLimit(user, itemID);
        }
    }
}