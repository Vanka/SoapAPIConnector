﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapAPIConnector.ExiteSoapService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://soap.edi.exite.org/", ConfigurationName="ExiteSoapService.EdiServer")]
    public interface EdiServer {
        
        // CODEGEN: Параметр "result" требует дополнительной информации о схеме, которую невозможно получить в режиме параметров. Указан атрибут "System.Xml.Serialization.XmlElementAttribute".
        [System.ServiceModel.OperationContractAttribute(Action="http://soap.edi.exite.org/EdiServer/getDocRequest", ReplyAction="http://soap.edi.exite.org/EdiServer/getDocResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="result")]
        SoapAPIConnector.ExiteSoapService.getDocResponse getDoc(SoapAPIConnector.ExiteSoapService.getDocRequest request);
        
        // CODEGEN: Параметр "result" требует дополнительной информации о схеме, которую невозможно получить в режиме параметров. Указан атрибут "System.Xml.Serialization.XmlElementAttribute".
        [System.ServiceModel.OperationContractAttribute(Action="http://soap.edi.exite.org/EdiServer/getListRequest", ReplyAction="http://soap.edi.exite.org/EdiServer/getListResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="result")]
        SoapAPIConnector.ExiteSoapService.getListResponse getList(SoapAPIConnector.ExiteSoapService.getListRequest request);
        
        // CODEGEN: Параметр "result" требует дополнительной информации о схеме, которую невозможно получить в режиме параметров. Указан атрибут "System.Xml.Serialization.XmlElementAttribute".
        [System.ServiceModel.OperationContractAttribute(Action="http://soap.edi.exite.org/EdiServer/sendDocRequest", ReplyAction="http://soap.edi.exite.org/EdiServer/sendDocResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="result")]
        SoapAPIConnector.ExiteSoapService.sendDocResponse sendDoc(SoapAPIConnector.ExiteSoapService.sendDocRequest request);
        
        // CODEGEN: Параметр "result" требует дополнительной информации о схеме, которую невозможно получить в режиме параметров. Указан атрибут "System.Xml.Serialization.XmlElementAttribute".
        [System.ServiceModel.OperationContractAttribute(Action="http://soap.edi.exite.org/EdiServer/archiveDocRequest", ReplyAction="http://soap.edi.exite.org/EdiServer/archiveDocResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="result")]
        SoapAPIConnector.ExiteSoapService.archiveDocResponse archiveDoc(SoapAPIConnector.ExiteSoapService.archiveDocRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.edi.exite.org/")]
    public partial class ediLogin : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string loginField;
        
        private string passField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string login {
            get {
                return this.loginField;
            }
            set {
                this.loginField = value;
                this.RaisePropertyChanged("login");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string pass {
            get {
                return this.passField;
            }
            set {
                this.passField = value;
                this.RaisePropertyChanged("pass");
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ediFileList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ediFile))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.edi.exite.org/")]
    public partial class ediResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int errorCodeField;
        
        private string errorMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int errorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
                this.RaisePropertyChanged("errorCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string errorMessage {
            get {
                return this.errorMessageField;
            }
            set {
                this.errorMessageField = value;
                this.RaisePropertyChanged("errorMessage");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.edi.exite.org/")]
    public partial class ediFileList : ediResponse {
        
        private string[] listField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("list", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public string[] list {
            get {
                return this.listField;
            }
            set {
                this.listField = value;
                this.RaisePropertyChanged("list");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.edi.exite.org/")]
    public partial class ediFile : ediResponse {
        
        private byte[] contentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=0)]
        public byte[] content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
                this.RaisePropertyChanged("content");
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getDoc", WrapperNamespace="http://soap.edi.exite.org/", IsWrapped=true)]
    public partial class getDocRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.edi.exite.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SoapAPIConnector.ExiteSoapService.ediLogin user;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.edi.exite.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fileName;
        
        public getDocRequest() {
        }
        
        public getDocRequest(SoapAPIConnector.ExiteSoapService.ediLogin user, string fileName) {
            this.user = user;
            this.fileName = fileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getDocResponse", WrapperNamespace="http://soap.edi.exite.org/", IsWrapped=true)]
    public partial class getDocResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.edi.exite.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SoapAPIConnector.ExiteSoapService.ediFile result;
        
        public getDocResponse() {
        }
        
        public getDocResponse(SoapAPIConnector.ExiteSoapService.ediFile result) {
            this.result = result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getList", WrapperNamespace="http://soap.edi.exite.org/", IsWrapped=true)]
    public partial class getListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.edi.exite.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SoapAPIConnector.ExiteSoapService.ediLogin user;
        
        public getListRequest() {
        }
        
        public getListRequest(SoapAPIConnector.ExiteSoapService.ediLogin user) {
            this.user = user;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getListResponse", WrapperNamespace="http://soap.edi.exite.org/", IsWrapped=true)]
    public partial class getListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.edi.exite.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SoapAPIConnector.ExiteSoapService.ediFileList result;
        
        public getListResponse() {
        }
        
        public getListResponse(SoapAPIConnector.ExiteSoapService.ediFileList result) {
            this.result = result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendDoc", WrapperNamespace="http://soap.edi.exite.org/", IsWrapped=true)]
    public partial class sendDocRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.edi.exite.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SoapAPIConnector.ExiteSoapService.ediLogin user;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.edi.exite.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fileName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.edi.exite.org/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", IsNullable=true)]
        public byte[] content;
        
        public sendDocRequest() {
        }
        
        public sendDocRequest(SoapAPIConnector.ExiteSoapService.ediLogin user, string fileName, byte[] content) {
            this.user = user;
            this.fileName = fileName;
            this.content = content;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendDocResponse", WrapperNamespace="http://soap.edi.exite.org/", IsWrapped=true)]
    public partial class sendDocResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.edi.exite.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SoapAPIConnector.ExiteSoapService.ediResponse result;
        
        public sendDocResponse() {
        }
        
        public sendDocResponse(SoapAPIConnector.ExiteSoapService.ediResponse result) {
            this.result = result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="archiveDoc", WrapperNamespace="http://soap.edi.exite.org/", IsWrapped=true)]
    public partial class archiveDocRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.edi.exite.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SoapAPIConnector.ExiteSoapService.ediLogin user;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.edi.exite.org/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fileName;
        
        public archiveDocRequest() {
        }
        
        public archiveDocRequest(SoapAPIConnector.ExiteSoapService.ediLogin user, string fileName) {
            this.user = user;
            this.fileName = fileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="archiveDocResponse", WrapperNamespace="http://soap.edi.exite.org/", IsWrapped=true)]
    public partial class archiveDocResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://soap.edi.exite.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SoapAPIConnector.ExiteSoapService.ediResponse result;
        
        public archiveDocResponse() {
        }
        
        public archiveDocResponse(SoapAPIConnector.ExiteSoapService.ediResponse result) {
            this.result = result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface EdiServerChannel : SoapAPIConnector.ExiteSoapService.EdiServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EdiServerClient : System.ServiceModel.ClientBase<SoapAPIConnector.ExiteSoapService.EdiServer>, SoapAPIConnector.ExiteSoapService.EdiServer {
        
        public EdiServerClient() {
        }
        
        public EdiServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EdiServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EdiServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EdiServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoapAPIConnector.ExiteSoapService.getDocResponse SoapAPIConnector.ExiteSoapService.EdiServer.getDoc(SoapAPIConnector.ExiteSoapService.getDocRequest request) {
            return base.Channel.getDoc(request);
        }
        
        public SoapAPIConnector.ExiteSoapService.ediFile getDoc(SoapAPIConnector.ExiteSoapService.ediLogin user, string fileName) {
            SoapAPIConnector.ExiteSoapService.getDocRequest inValue = new SoapAPIConnector.ExiteSoapService.getDocRequest();
            inValue.user = user;
            inValue.fileName = fileName;
            SoapAPIConnector.ExiteSoapService.getDocResponse retVal = ((SoapAPIConnector.ExiteSoapService.EdiServer)(this)).getDoc(inValue);
            return retVal.result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoapAPIConnector.ExiteSoapService.getListResponse SoapAPIConnector.ExiteSoapService.EdiServer.getList(SoapAPIConnector.ExiteSoapService.getListRequest request) {
            return base.Channel.getList(request);
        }
        
        public SoapAPIConnector.ExiteSoapService.ediFileList getList(SoapAPIConnector.ExiteSoapService.ediLogin user) {
            SoapAPIConnector.ExiteSoapService.getListRequest inValue = new SoapAPIConnector.ExiteSoapService.getListRequest();
            inValue.user = user;
            SoapAPIConnector.ExiteSoapService.getListResponse retVal = ((SoapAPIConnector.ExiteSoapService.EdiServer)(this)).getList(inValue);
            return retVal.result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoapAPIConnector.ExiteSoapService.sendDocResponse SoapAPIConnector.ExiteSoapService.EdiServer.sendDoc(SoapAPIConnector.ExiteSoapService.sendDocRequest request) {
            return base.Channel.sendDoc(request);
        }
        
        public SoapAPIConnector.ExiteSoapService.ediResponse sendDoc(SoapAPIConnector.ExiteSoapService.ediLogin user, string fileName, byte[] content) {
            SoapAPIConnector.ExiteSoapService.sendDocRequest inValue = new SoapAPIConnector.ExiteSoapService.sendDocRequest();
            inValue.user = user;
            inValue.fileName = fileName;
            inValue.content = content;
            SoapAPIConnector.ExiteSoapService.sendDocResponse retVal = ((SoapAPIConnector.ExiteSoapService.EdiServer)(this)).sendDoc(inValue);
            return retVal.result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoapAPIConnector.ExiteSoapService.archiveDocResponse SoapAPIConnector.ExiteSoapService.EdiServer.archiveDoc(SoapAPIConnector.ExiteSoapService.archiveDocRequest request) {
            return base.Channel.archiveDoc(request);
        }
        
        public SoapAPIConnector.ExiteSoapService.ediResponse archiveDoc(SoapAPIConnector.ExiteSoapService.ediLogin user, string fileName) {
            SoapAPIConnector.ExiteSoapService.archiveDocRequest inValue = new SoapAPIConnector.ExiteSoapService.archiveDocRequest();
            inValue.user = user;
            inValue.fileName = fileName;
            SoapAPIConnector.ExiteSoapService.archiveDocResponse retVal = ((SoapAPIConnector.ExiteSoapService.EdiServer)(this)).archiveDoc(inValue);
            return retVal.result;
        }
    }
}