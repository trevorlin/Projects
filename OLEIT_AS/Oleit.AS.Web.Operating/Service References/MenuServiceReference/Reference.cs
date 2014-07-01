﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Accounting_System.MenuServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MenuServiceReference.IMenuService")]
    public interface IMenuService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/DoWork", ReplyAction="http://tempuri.org/IMenuService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/QueryAllRole", ReplyAction="http://tempuri.org/IMenuService/QueryAllRoleResponse")]
        Oleit.AS.Service.DataObject.Role[] QueryAllRole();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/QueryRole", ReplyAction="http://tempuri.org/IMenuService/QueryRoleResponse")]
        Oleit.AS.Service.DataObject.Role QueryRole(int roleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/UpdateRole", ReplyAction="http://tempuri.org/IMenuService/UpdateRoleResponse")]
        void UpdateRole(Oleit.AS.Service.DataObject.Role role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/QueryRoleUser", ReplyAction="http://tempuri.org/IMenuService/QueryRoleUserResponse")]
        Oleit.AS.Service.DataObject.User[] QueryRoleUser(int roleID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/QueryUserRole", ReplyAction="http://tempuri.org/IMenuService/QueryUserRoleResponse")]
        Oleit.AS.Service.DataObject.Role[] QueryUserRole(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/DeleteRole", ReplyAction="http://tempuri.org/IMenuService/DeleteRoleResponse")]
        bool DeleteRole(Oleit.AS.Service.DataObject.Role[] roleCollection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/InsertRole", ReplyAction="http://tempuri.org/IMenuService/InsertRoleResponse")]
        bool InsertRole(string roleName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/QueryAllMenu", ReplyAction="http://tempuri.org/IMenuService/QueryAllMenuResponse")]
        Oleit.AS.Service.DataObject.FuncMenu[] QueryAllMenu();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/QueryUserMenu", ReplyAction="http://tempuri.org/IMenuService/QueryUserMenuResponse")]
        Oleit.AS.Service.DataObject.FuncMenu[] QueryUserMenu(int userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/DeleteRoleMenuRelation", ReplyAction="http://tempuri.org/IMenuService/DeleteRoleMenuRelationResponse")]
        void DeleteRoleMenuRelation(int menuID, int roleID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/InsertRoleMenuRelation", ReplyAction="http://tempuri.org/IMenuService/InsertRoleMenuRelationResponse")]
        void InsertRoleMenuRelation(int menuID, int roleID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/DeleteRoleUserRelation", ReplyAction="http://tempuri.org/IMenuService/DeleteRoleUserRelationResponse")]
        void DeleteRoleUserRelation(int userID, int roleID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/InsertRoleUserRelation", ReplyAction="http://tempuri.org/IMenuService/InsertRoleUserRelationResponse")]
        void InsertRoleUserRelation(int userID, int roleID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMenuServiceChannel : Accounting_System.MenuServiceReference.IMenuService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MenuServiceClient : System.ServiceModel.ClientBase<Accounting_System.MenuServiceReference.IMenuService>, Accounting_System.MenuServiceReference.IMenuService {
        
        public MenuServiceClient() {
        }
        
        public MenuServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MenuServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MenuServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MenuServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public Oleit.AS.Service.DataObject.Role[] QueryAllRole() {
            return base.Channel.QueryAllRole();
        }
        
        public Oleit.AS.Service.DataObject.Role QueryRole(int roleId) {
            return base.Channel.QueryRole(roleId);
        }
        
        public void UpdateRole(Oleit.AS.Service.DataObject.Role role) {
            base.Channel.UpdateRole(role);
        }
        
        public Oleit.AS.Service.DataObject.User[] QueryRoleUser(int roleID) {
            return base.Channel.QueryRoleUser(roleID);
        }
        
        public Oleit.AS.Service.DataObject.Role[] QueryUserRole(int userID) {
            return base.Channel.QueryUserRole(userID);
        }
        
        public bool DeleteRole(Oleit.AS.Service.DataObject.Role[] roleCollection) {
            return base.Channel.DeleteRole(roleCollection);
        }
        
        public bool InsertRole(string roleName) {
            return base.Channel.InsertRole(roleName);
        }
        
        public Oleit.AS.Service.DataObject.FuncMenu[] QueryAllMenu() {
            return base.Channel.QueryAllMenu();
        }
        
        public Oleit.AS.Service.DataObject.FuncMenu[] QueryUserMenu(int userID) {
            return base.Channel.QueryUserMenu(userID);
        }
        
        public void DeleteRoleMenuRelation(int menuID, int roleID) {
            base.Channel.DeleteRoleMenuRelation(menuID, roleID);
        }
        
        public void InsertRoleMenuRelation(int menuID, int roleID) {
            base.Channel.InsertRoleMenuRelation(menuID, roleID);
        }
        
        public void DeleteRoleUserRelation(int userID, int roleID) {
            base.Channel.DeleteRoleUserRelation(userID, roleID);
        }
        
        public void InsertRoleUserRelation(int userID, int roleID) {
            base.Channel.InsertRoleUserRelation(userID, roleID);
        }
    }
}
