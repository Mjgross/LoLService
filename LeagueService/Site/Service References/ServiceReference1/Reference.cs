﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Site.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Summoner", Namespace="http://schemas.datacontract.org/2004/07/GetChamps")]
    [System.SerializableAttribute()]
    public partial class Summoner : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string iconURLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int profileIconIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long revisionDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long summonerLevelField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string iconURL {
            get {
                return this.iconURLField;
            }
            set {
                if ((object.ReferenceEquals(this.iconURLField, value) != true)) {
                    this.iconURLField = value;
                    this.RaisePropertyChanged("iconURL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int profileIconId {
            get {
                return this.profileIconIdField;
            }
            set {
                if ((this.profileIconIdField.Equals(value) != true)) {
                    this.profileIconIdField = value;
                    this.RaisePropertyChanged("profileIconId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long revisionDate {
            get {
                return this.revisionDateField;
            }
            set {
                if ((this.revisionDateField.Equals(value) != true)) {
                    this.revisionDateField = value;
                    this.RaisePropertyChanged("revisionDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long summonerLevel {
            get {
                return this.summonerLevelField;
            }
            set {
                if ((this.summonerLevelField.Equals(value) != true)) {
                    this.summonerLevelField = value;
                    this.RaisePropertyChanged("summonerLevel");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/update", ReplyAction="http://tempuri.org/IService1/updateResponse")]
        Site.ServiceReference1.Summoner update(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/update", ReplyAction="http://tempuri.org/IService1/updateResponse")]
        System.Threading.Tasks.Task<Site.ServiceReference1.Summoner> updateAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Site.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Site.ServiceReference1.IService1>, Site.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Site.ServiceReference1.Summoner update(string username) {
            return base.Channel.update(username);
        }
        
        public System.Threading.Tasks.Task<Site.ServiceReference1.Summoner> updateAsync(string username) {
            return base.Channel.updateAsync(username);
        }
    }
}
