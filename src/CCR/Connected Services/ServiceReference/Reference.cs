﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CCR.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SignRequest", Namespace="http://schemas.datacontract.org/2004/07/Ama.Structures.SCMDService")]
    [System.SerializableAttribute()]
    public partial class SignRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private byte[] ApplicationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocNameField;
        
        private byte[] HashField;
        
        private string PinField;
        
        private string UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public byte[] ApplicationId {
            get {
                return this.ApplicationIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ApplicationIdField, value) != true)) {
                    this.ApplicationIdField = value;
                    this.RaisePropertyChanged("ApplicationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocName {
            get {
                return this.DocNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DocNameField, value) != true)) {
                    this.DocNameField = value;
                    this.RaisePropertyChanged("DocName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public byte[] Hash {
            get {
                return this.HashField;
            }
            set {
                if ((object.ReferenceEquals(this.HashField, value) != true)) {
                    this.HashField = value;
                    this.RaisePropertyChanged("Hash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Pin {
            get {
                return this.PinField;
            }
            set {
                if ((object.ReferenceEquals(this.PinField, value) != true)) {
                    this.PinField = value;
                    this.RaisePropertyChanged("Pin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SignStatus", Namespace="http://schemas.datacontract.org/2004/07/Ama.Structures.SCMDService")]
    [System.SerializableAttribute()]
    public partial class SignStatus : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string CodeField;
        
        private string FieldField;
        
        private string FieldValueField;
        
        private string MessageField;
        
        private string ProcessIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Field {
            get {
                return this.FieldField;
            }
            set {
                if ((object.ReferenceEquals(this.FieldField, value) != true)) {
                    this.FieldField = value;
                    this.RaisePropertyChanged("Field");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string FieldValue {
            get {
                return this.FieldValueField;
            }
            set {
                if ((object.ReferenceEquals(this.FieldValueField, value) != true)) {
                    this.FieldValueField = value;
                    this.RaisePropertyChanged("FieldValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string ProcessId {
            get {
                return this.ProcessIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProcessIdField, value) != true)) {
                    this.ProcessIdField = value;
                    this.RaisePropertyChanged("ProcessId");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SignResponse", Namespace="http://schemas.datacontract.org/2004/07/Ama.Structures.SCMDService")]
    [System.SerializableAttribute()]
    public partial class SignResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private System.Collections.Generic.List<CCR.ServiceReference.HashStructure> ArrayOfHashStructureField;
        
        private byte[] SignatureField;
        
        private CCR.ServiceReference.SignStatus StatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Collections.Generic.List<CCR.ServiceReference.HashStructure> ArrayOfHashStructure {
            get {
                return this.ArrayOfHashStructureField;
            }
            set {
                if ((object.ReferenceEquals(this.ArrayOfHashStructureField, value) != true)) {
                    this.ArrayOfHashStructureField = value;
                    this.RaisePropertyChanged("ArrayOfHashStructure");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public byte[] Signature {
            get {
                return this.SignatureField;
            }
            set {
                if ((object.ReferenceEquals(this.SignatureField, value) != true)) {
                    this.SignatureField = value;
                    this.RaisePropertyChanged("Signature");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public CCR.ServiceReference.SignStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HashStructure", Namespace="http://schemas.datacontract.org/2004/07/Ama.Structures.SCMDService")]
    [System.SerializableAttribute()]
    public partial class HashStructure : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private byte[] HashField;
        
        private string NameField;
        
        private string idField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public byte[] Hash {
            get {
                return this.HashField;
            }
            set {
                if ((object.ReferenceEquals(this.HashField, value) != true)) {
                    this.HashField = value;
                    this.RaisePropertyChanged("Hash");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string id {
            get {
                return this.idField;
            }
            set {
                if ((object.ReferenceEquals(this.idField, value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MultipleSignRequest", Namespace="http://schemas.datacontract.org/2004/07/Ama.Structures.SCMDService")]
    [System.SerializableAttribute()]
    public partial class MultipleSignRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private byte[] ApplicationIdField;
        
        private string PinField;
        
        private string UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public byte[] ApplicationId {
            get {
                return this.ApplicationIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ApplicationIdField, value) != true)) {
                    this.ApplicationIdField = value;
                    this.RaisePropertyChanged("ApplicationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Pin {
            get {
                return this.PinField;
            }
            set {
                if ((object.ReferenceEquals(this.PinField, value) != true)) {
                    this.PinField = value;
                    this.RaisePropertyChanged("Pin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((object.ReferenceEquals(this.UserIdField, value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Ama.Authentication.Service/", ConfigurationName="ServiceReference.SCMDService")]
    public interface SCMDService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Ama.Authentication.Service/SCMDService/SCMDSign", ReplyAction="http://Ama.Authentication.Service/SCMDService/SCMDSignResponse")]
        CCR.ServiceReference.SignStatus SCMDSign(CCR.ServiceReference.SignRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Ama.Authentication.Service/SCMDService/SCMDSign", ReplyAction="http://Ama.Authentication.Service/SCMDService/SCMDSignResponse")]
        System.Threading.Tasks.Task<CCR.ServiceReference.SignStatus> SCMDSignAsync(CCR.ServiceReference.SignRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Ama.Authentication.Service/SCMDService/GetCertificate", ReplyAction="http://Ama.Authentication.Service/SCMDService/GetCertificateResponse")]
        string GetCertificate(byte[] applicationId, string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Ama.Authentication.Service/SCMDService/GetCertificate", ReplyAction="http://Ama.Authentication.Service/SCMDService/GetCertificateResponse")]
        System.Threading.Tasks.Task<string> GetCertificateAsync(byte[] applicationId, string userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Ama.Authentication.Service/SCMDService/ValidateOtp", ReplyAction="http://Ama.Authentication.Service/SCMDService/ValidateOtpResponse")]
        CCR.ServiceReference.SignResponse ValidateOtp(string code, string processId, byte[] applicationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Ama.Authentication.Service/SCMDService/ValidateOtp", ReplyAction="http://Ama.Authentication.Service/SCMDService/ValidateOtpResponse")]
        System.Threading.Tasks.Task<CCR.ServiceReference.SignResponse> ValidateOtpAsync(string code, string processId, byte[] applicationId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Ama.Authentication.Service/SCMDService/SCMDMultipleSign", ReplyAction="http://Ama.Authentication.Service/SCMDService/SCMDMultipleSignResponse")]
        CCR.ServiceReference.SignStatus SCMDMultipleSign(CCR.ServiceReference.MultipleSignRequest request, System.Collections.Generic.List<CCR.ServiceReference.HashStructure> documents);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Ama.Authentication.Service/SCMDService/SCMDMultipleSign", ReplyAction="http://Ama.Authentication.Service/SCMDService/SCMDMultipleSignResponse")]
        System.Threading.Tasks.Task<CCR.ServiceReference.SignStatus> SCMDMultipleSignAsync(CCR.ServiceReference.MultipleSignRequest request, System.Collections.Generic.List<CCR.ServiceReference.HashStructure> documents);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SCMDServiceChannel : CCR.ServiceReference.SCMDService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SCMDServiceClient : System.ServiceModel.ClientBase<CCR.ServiceReference.SCMDService>, CCR.ServiceReference.SCMDService {
        
        public SCMDServiceClient() {
        }
        
        public SCMDServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SCMDServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SCMDServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SCMDServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CCR.ServiceReference.SignStatus SCMDSign(CCR.ServiceReference.SignRequest request) {
            return base.Channel.SCMDSign(request);
        }
        
        public System.Threading.Tasks.Task<CCR.ServiceReference.SignStatus> SCMDSignAsync(CCR.ServiceReference.SignRequest request) {
            return base.Channel.SCMDSignAsync(request);
        }
        
        public string GetCertificate(byte[] applicationId, string userId) {
            return base.Channel.GetCertificate(applicationId, userId);
        }
        
        public System.Threading.Tasks.Task<string> GetCertificateAsync(byte[] applicationId, string userId) {
            return base.Channel.GetCertificateAsync(applicationId, userId);
        }
        
        public CCR.ServiceReference.SignResponse ValidateOtp(string code, string processId, byte[] applicationId) {
            return base.Channel.ValidateOtp(code, processId, applicationId);
        }
        
        public System.Threading.Tasks.Task<CCR.ServiceReference.SignResponse> ValidateOtpAsync(string code, string processId, byte[] applicationId) {
            return base.Channel.ValidateOtpAsync(code, processId, applicationId);
        }
        
        public CCR.ServiceReference.SignStatus SCMDMultipleSign(CCR.ServiceReference.MultipleSignRequest request, System.Collections.Generic.List<CCR.ServiceReference.HashStructure> documents) {
            return base.Channel.SCMDMultipleSign(request, documents);
        }
        
        public System.Threading.Tasks.Task<CCR.ServiceReference.SignStatus> SCMDMultipleSignAsync(CCR.ServiceReference.MultipleSignRequest request, System.Collections.Generic.List<CCR.ServiceReference.HashStructure> documents) {
            return base.Channel.SCMDMultipleSignAsync(request, documents);
        }
    }
}