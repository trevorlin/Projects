﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Accounting_System.DataEntryServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataEntryServiceReference.IDataEntryService")]
    public interface IDataEntryService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/InsertRecord", ReplyAction="http://tempuri.org/IDataEntryService/InsertRecordResponse")]
        int InsertRecord(Oleit.AS.Service.DataObject.Record record, Oleit.AS.Service.DataObject.Journal[] jcollection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/SaveRecord", ReplyAction="http://tempuri.org/IDataEntryService/SaveRecordResponse")]
        int SaveRecord(Oleit.AS.Service.DataObject.Record record, Oleit.AS.Service.DataObject.Journal[] jcollection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/InsertTransfer", ReplyAction="http://tempuri.org/IDataEntryService/InsertTransferResponse")]
        int InsertTransfer(Oleit.AS.Service.DataObject.Record record, Oleit.AS.Service.DataObject.Transfer transfer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/UpdateRecord", ReplyAction="http://tempuri.org/IDataEntryService/UpdateRecordResponse")]
        void UpdateRecord(Oleit.AS.Service.DataObject.User user, Oleit.AS.Service.DataObject.Record record, Oleit.AS.Service.DataObject.Journal[] jcollection);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/LoadRecord", ReplyAction="http://tempuri.org/IDataEntryService/LoadRecordResponse")]
        Oleit.AS.Service.DataObject.Record LoadRecord(int recordID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/LoadRecordByPeriodEntityID", ReplyAction="http://tempuri.org/IDataEntryService/LoadRecordByPeriodEntityIDResponse")]
        Oleit.AS.Service.DataObject.Record[] LoadRecordByPeriodEntityID(int entityid, int periodid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/GetRecordList", ReplyAction="http://tempuri.org/IDataEntryService/GetRecordListResponse")]
        Oleit.AS.Service.DataObject.Record[] GetRecordList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/Approve", ReplyAction="http://tempuri.org/IDataEntryService/ApproveResponse")]
        void Approve(int recordID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/Avoid", ReplyAction="http://tempuri.org/IDataEntryService/AvoidResponse")]
        void Avoid(int recordID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/LoadTransaction", ReplyAction="http://tempuri.org/IDataEntryService/LoadTransactionResponse")]
        Oleit.AS.Service.DataObject.Transaction[] LoadTransaction();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/LoadTransactionByID", ReplyAction="http://tempuri.org/IDataEntryService/LoadTransactionByIDResponse")]
        Oleit.AS.Service.DataObject.Transaction[] LoadTransactionByID(int _id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/LoadTransactionByPeriodID", ReplyAction="http://tempuri.org/IDataEntryService/LoadTransactionByPeriodIDResponse")]
        Oleit.AS.Service.DataObject.Transaction[] LoadTransactionByPeriodID(int _periodid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/InsertTransaction", ReplyAction="http://tempuri.org/IDataEntryService/InsertTransactionResponse")]
        void InsertTransaction(Oleit.AS.Service.DataObject.Transaction _transaction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/SetNotices", ReplyAction="http://tempuri.org/IDataEntryService/SetNoticesResponse")]
        void SetNotices(int _id, int _userid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/SetConfirm", ReplyAction="http://tempuri.org/IDataEntryService/SetConfirmResponse")]
        void SetConfirm(Oleit.AS.Service.DataObject.Transaction transaction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/Updatetransaction", ReplyAction="http://tempuri.org/IDataEntryService/UpdatetransactionResponse")]
        void Updatetransaction(Oleit.AS.Service.DataObject.Transaction transaction);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataEntryService/GetjournalSum", ReplyAction="http://tempuri.org/IDataEntryService/GetjournalSumResponse")]
        decimal[] GetjournalSum(int periodId, int typeid, int entityid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataEntryServiceChannel : Accounting_System.DataEntryServiceReference.IDataEntryService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataEntryServiceClient : System.ServiceModel.ClientBase<Accounting_System.DataEntryServiceReference.IDataEntryService>, Accounting_System.DataEntryServiceReference.IDataEntryService {
        
        public DataEntryServiceClient() {
        }
        
        public DataEntryServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataEntryServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataEntryServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataEntryServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int InsertRecord(Oleit.AS.Service.DataObject.Record record, Oleit.AS.Service.DataObject.Journal[] jcollection) {
            return base.Channel.InsertRecord(record, jcollection);
        }
        
        public int SaveRecord(Oleit.AS.Service.DataObject.Record record, Oleit.AS.Service.DataObject.Journal[] jcollection) {
            return base.Channel.SaveRecord(record, jcollection);
        }
        
        public int InsertTransfer(Oleit.AS.Service.DataObject.Record record, Oleit.AS.Service.DataObject.Transfer transfer) {
            return base.Channel.InsertTransfer(record, transfer);
        }
        
        public void UpdateRecord(Oleit.AS.Service.DataObject.User user, Oleit.AS.Service.DataObject.Record record, Oleit.AS.Service.DataObject.Journal[] jcollection) {
            base.Channel.UpdateRecord(user, record, jcollection);
        }
        
        public Oleit.AS.Service.DataObject.Record LoadRecord(int recordID) {
            return base.Channel.LoadRecord(recordID);
        }
        
        public Oleit.AS.Service.DataObject.Record[] LoadRecordByPeriodEntityID(int entityid, int periodid) {
            return base.Channel.LoadRecordByPeriodEntityID(entityid, periodid);
        }
        
        public Oleit.AS.Service.DataObject.Record[] GetRecordList() {
            return base.Channel.GetRecordList();
        }
        
        public void Approve(int recordID) {
            base.Channel.Approve(recordID);
        }
        
        public void Avoid(int recordID) {
            base.Channel.Avoid(recordID);
        }
        
        public Oleit.AS.Service.DataObject.Transaction[] LoadTransaction() {
            return base.Channel.LoadTransaction();
        }
        
        public Oleit.AS.Service.DataObject.Transaction[] LoadTransactionByID(int _id) {
            return base.Channel.LoadTransactionByID(_id);
        }
        
        public Oleit.AS.Service.DataObject.Transaction[] LoadTransactionByPeriodID(int _periodid) {
            return base.Channel.LoadTransactionByPeriodID(_periodid);
        }
        
        public void InsertTransaction(Oleit.AS.Service.DataObject.Transaction _transaction) {
            base.Channel.InsertTransaction(_transaction);
        }
        
        public void SetNotices(int _id, int _userid) {
            base.Channel.SetNotices(_id, _userid);
        }
        
        public void SetConfirm(Oleit.AS.Service.DataObject.Transaction transaction) {
            base.Channel.SetConfirm(transaction);
        }
        
        public void Updatetransaction(Oleit.AS.Service.DataObject.Transaction transaction) {
            base.Channel.Updatetransaction(transaction);
        }
        
        public decimal[] GetjournalSum(int periodId, int typeid, int entityid) {
            return base.Channel.GetjournalSum(periodId, typeid, entityid);
        }
    }
}
