﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shop.UserServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceRef.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Create", ReplyAction="http://tempuri.org/IUserService/CreateResponse")]
        DBs.Infrastructure.OperationDetails Create(WCFContracts.DataContracts.UserData userDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Create", ReplyAction="http://tempuri.org/IUserService/CreateResponse")]
        System.Threading.Tasks.Task<DBs.Infrastructure.OperationDetails> CreateAsync(WCFContracts.DataContracts.UserData userDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Authenticate", ReplyAction="http://tempuri.org/IUserService/AuthenticateResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(WCFContracts.DataContracts.UserData))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(string[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DBs.Infrastructure.OperationDetails))]
        WCFContracts.DataContracts.ClaimsIdentityData Authenticate(WCFContracts.DataContracts.UserData userDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/Authenticate", ReplyAction="http://tempuri.org/IUserService/AuthenticateResponse")]
        System.Threading.Tasks.Task<WCFContracts.DataContracts.ClaimsIdentityData> AuthenticateAsync(WCFContracts.DataContracts.UserData userDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/SetInitialData", ReplyAction="http://tempuri.org/IUserService/SetInitialDataResponse")]
        void SetInitialData(WCFContracts.DataContracts.UserData adminDto, string[] roles);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/SetInitialData", ReplyAction="http://tempuri.org/IUserService/SetInitialDataResponse")]
        System.Threading.Tasks.Task SetInitialDataAsync(WCFContracts.DataContracts.UserData adminDto, string[] roles);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : Shop.UserServiceRef.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<Shop.UserServiceRef.IUserService>, Shop.UserServiceRef.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DBs.Infrastructure.OperationDetails Create(WCFContracts.DataContracts.UserData userDto) {
            return base.Channel.Create(userDto);
        }
        
        public System.Threading.Tasks.Task<DBs.Infrastructure.OperationDetails> CreateAsync(WCFContracts.DataContracts.UserData userDto) {
            return base.Channel.CreateAsync(userDto);
        }
        
        public WCFContracts.DataContracts.ClaimsIdentityData Authenticate(WCFContracts.DataContracts.UserData userDto) {
            return base.Channel.Authenticate(userDto);
        }
        
        public System.Threading.Tasks.Task<WCFContracts.DataContracts.ClaimsIdentityData> AuthenticateAsync(WCFContracts.DataContracts.UserData userDto) {
            return base.Channel.AuthenticateAsync(userDto);
        }
        
        public void SetInitialData(WCFContracts.DataContracts.UserData adminDto, string[] roles) {
            base.Channel.SetInitialData(adminDto, roles);
        }
        
        public System.Threading.Tasks.Task SetInitialDataAsync(WCFContracts.DataContracts.UserData adminDto, string[] roles) {
            return base.Channel.SetInitialDataAsync(adminDto, roles);
        }
    }
}