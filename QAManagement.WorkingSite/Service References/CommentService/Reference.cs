﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QAManagement.WorkingSite.CommentService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Comment", Namespace="http://schemas.datacontract.org/2004/07/QAManagement.Data.Services.DataContracts")]
    [System.SerializableAttribute()]
    public partial class Comment : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long RequirementIDField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long RequirementID {
            get {
                return this.RequirementIDField;
            }
            set {
                if ((this.RequirementIDField.Equals(value) != true)) {
                    this.RequirementIDField = value;
                    this.RaisePropertyChanged("RequirementID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CommentService.ICommentService")]
    public interface ICommentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommentService/GetCommentById", ReplyAction="http://tempuri.org/ICommentService/GetCommentByIdResponse")]
        QAManagement.WorkingSite.CommentService.GetCommentByIdResponse GetCommentById(QAManagement.WorkingSite.CommentService.GetCommentByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ICommentService/GetCommentById", ReplyAction="http://tempuri.org/ICommentService/GetCommentByIdResponse")]
        System.IAsyncResult BeginGetCommentById(QAManagement.WorkingSite.CommentService.GetCommentByIdRequest request, System.AsyncCallback callback, object asyncState);
        
        QAManagement.WorkingSite.CommentService.GetCommentByIdResponse EndGetCommentById(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommentService/GetAllComments", ReplyAction="http://tempuri.org/ICommentService/GetAllCommentsResponse")]
        QAManagement.WorkingSite.CommentService.GetAllCommentsResponse GetAllComments(QAManagement.WorkingSite.CommentService.GetAllCommentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ICommentService/GetAllComments", ReplyAction="http://tempuri.org/ICommentService/GetAllCommentsResponse")]
        System.IAsyncResult BeginGetAllComments(QAManagement.WorkingSite.CommentService.GetAllCommentsRequest request, System.AsyncCallback callback, object asyncState);
        
        QAManagement.WorkingSite.CommentService.GetAllCommentsResponse EndGetAllComments(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICommentService/UpdateComment", ReplyAction="http://tempuri.org/ICommentService/UpdateCommentResponse")]
        QAManagement.WorkingSite.CommentService.UpdateCommentResponse UpdateComment(QAManagement.WorkingSite.CommentService.UpdateCommentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ICommentService/UpdateComment", ReplyAction="http://tempuri.org/ICommentService/UpdateCommentResponse")]
        System.IAsyncResult BeginUpdateComment(QAManagement.WorkingSite.CommentService.UpdateCommentRequest request, System.AsyncCallback callback, object asyncState);
        
        QAManagement.WorkingSite.CommentService.UpdateCommentResponse EndUpdateComment(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCommentById", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCommentByIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int id;
        
        public GetCommentByIdRequest() {
        }
        
        public GetCommentByIdRequest(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCommentByIdResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCommentByIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public QAManagement.WorkingSite.CommentService.Comment GetCommentByIdResult;
        
        public GetCommentByIdResponse() {
        }
        
        public GetCommentByIdResponse(QAManagement.WorkingSite.CommentService.Comment GetCommentByIdResult) {
            this.GetCommentByIdResult = GetCommentByIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllComments", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllCommentsRequest {
        
        public GetAllCommentsRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetAllCommentsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetAllCommentsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Collections.ObjectModel.ObservableCollection<QAManagement.WorkingSite.CommentService.Comment> GetAllCommentsResult;
        
        public GetAllCommentsResponse() {
        }
        
        public GetAllCommentsResponse(System.Collections.ObjectModel.ObservableCollection<QAManagement.WorkingSite.CommentService.Comment> GetAllCommentsResult) {
            this.GetAllCommentsResult = GetAllCommentsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateComment", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateCommentRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public QAManagement.WorkingSite.CommentService.Comment item;
        
        public UpdateCommentRequest() {
        }
        
        public UpdateCommentRequest(QAManagement.WorkingSite.CommentService.Comment item) {
            this.item = item;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateCommentResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateCommentResponse {
        
        public UpdateCommentResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICommentServiceChannel : QAManagement.WorkingSite.CommentService.ICommentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetCommentByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetCommentByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public QAManagement.WorkingSite.CommentService.GetCommentByIdResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((QAManagement.WorkingSite.CommentService.GetCommentByIdResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllCommentsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllCommentsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public QAManagement.WorkingSite.CommentService.GetAllCommentsResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((QAManagement.WorkingSite.CommentService.GetAllCommentsResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UpdateCommentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public UpdateCommentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public QAManagement.WorkingSite.CommentService.UpdateCommentResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((QAManagement.WorkingSite.CommentService.UpdateCommentResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CommentServiceClient : System.ServiceModel.ClientBase<QAManagement.WorkingSite.CommentService.ICommentService>, QAManagement.WorkingSite.CommentService.ICommentService {
        
        private BeginOperationDelegate onBeginGetCommentByIdDelegate;
        
        private EndOperationDelegate onEndGetCommentByIdDelegate;
        
        private System.Threading.SendOrPostCallback onGetCommentByIdCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetAllCommentsDelegate;
        
        private EndOperationDelegate onEndGetAllCommentsDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllCommentsCompletedDelegate;
        
        private BeginOperationDelegate onBeginUpdateCommentDelegate;
        
        private EndOperationDelegate onEndUpdateCommentDelegate;
        
        private System.Threading.SendOrPostCallback onUpdateCommentCompletedDelegate;
        
        public CommentServiceClient() {
        }
        
        public CommentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CommentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetCommentByIdCompletedEventArgs> GetCommentByIdCompleted;
        
        public event System.EventHandler<GetAllCommentsCompletedEventArgs> GetAllCommentsCompleted;
        
        public event System.EventHandler<UpdateCommentCompletedEventArgs> UpdateCommentCompleted;
        
        public QAManagement.WorkingSite.CommentService.GetCommentByIdResponse GetCommentById(QAManagement.WorkingSite.CommentService.GetCommentByIdRequest request) {
            return base.Channel.GetCommentById(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetCommentById(QAManagement.WorkingSite.CommentService.GetCommentByIdRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetCommentById(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public QAManagement.WorkingSite.CommentService.GetCommentByIdResponse EndGetCommentById(System.IAsyncResult result) {
            return base.Channel.EndGetCommentById(result);
        }
        
        private System.IAsyncResult OnBeginGetCommentById(object[] inValues, System.AsyncCallback callback, object asyncState) {
            QAManagement.WorkingSite.CommentService.GetCommentByIdRequest request = ((QAManagement.WorkingSite.CommentService.GetCommentByIdRequest)(inValues[0]));
            return this.BeginGetCommentById(request, callback, asyncState);
        }
        
        private object[] OnEndGetCommentById(System.IAsyncResult result) {
            QAManagement.WorkingSite.CommentService.GetCommentByIdResponse retVal = this.EndGetCommentById(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetCommentByIdCompleted(object state) {
            if ((this.GetCommentByIdCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetCommentByIdCompleted(this, new GetCommentByIdCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetCommentByIdAsync(QAManagement.WorkingSite.CommentService.GetCommentByIdRequest request) {
            this.GetCommentByIdAsync(request, null);
        }
        
        public void GetCommentByIdAsync(QAManagement.WorkingSite.CommentService.GetCommentByIdRequest request, object userState) {
            if ((this.onBeginGetCommentByIdDelegate == null)) {
                this.onBeginGetCommentByIdDelegate = new BeginOperationDelegate(this.OnBeginGetCommentById);
            }
            if ((this.onEndGetCommentByIdDelegate == null)) {
                this.onEndGetCommentByIdDelegate = new EndOperationDelegate(this.OnEndGetCommentById);
            }
            if ((this.onGetCommentByIdCompletedDelegate == null)) {
                this.onGetCommentByIdCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetCommentByIdCompleted);
            }
            base.InvokeAsync(this.onBeginGetCommentByIdDelegate, new object[] {
                        request}, this.onEndGetCommentByIdDelegate, this.onGetCommentByIdCompletedDelegate, userState);
        }
        
        public QAManagement.WorkingSite.CommentService.GetAllCommentsResponse GetAllComments(QAManagement.WorkingSite.CommentService.GetAllCommentsRequest request) {
            return base.Channel.GetAllComments(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAllComments(QAManagement.WorkingSite.CommentService.GetAllCommentsRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllComments(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public QAManagement.WorkingSite.CommentService.GetAllCommentsResponse EndGetAllComments(System.IAsyncResult result) {
            return base.Channel.EndGetAllComments(result);
        }
        
        private System.IAsyncResult OnBeginGetAllComments(object[] inValues, System.AsyncCallback callback, object asyncState) {
            QAManagement.WorkingSite.CommentService.GetAllCommentsRequest request = ((QAManagement.WorkingSite.CommentService.GetAllCommentsRequest)(inValues[0]));
            return this.BeginGetAllComments(request, callback, asyncState);
        }
        
        private object[] OnEndGetAllComments(System.IAsyncResult result) {
            QAManagement.WorkingSite.CommentService.GetAllCommentsResponse retVal = this.EndGetAllComments(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllCommentsCompleted(object state) {
            if ((this.GetAllCommentsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllCommentsCompleted(this, new GetAllCommentsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllCommentsAsync(QAManagement.WorkingSite.CommentService.GetAllCommentsRequest request) {
            this.GetAllCommentsAsync(request, null);
        }
        
        public void GetAllCommentsAsync(QAManagement.WorkingSite.CommentService.GetAllCommentsRequest request, object userState) {
            if ((this.onBeginGetAllCommentsDelegate == null)) {
                this.onBeginGetAllCommentsDelegate = new BeginOperationDelegate(this.OnBeginGetAllComments);
            }
            if ((this.onEndGetAllCommentsDelegate == null)) {
                this.onEndGetAllCommentsDelegate = new EndOperationDelegate(this.OnEndGetAllComments);
            }
            if ((this.onGetAllCommentsCompletedDelegate == null)) {
                this.onGetAllCommentsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllCommentsCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllCommentsDelegate, new object[] {
                        request}, this.onEndGetAllCommentsDelegate, this.onGetAllCommentsCompletedDelegate, userState);
        }
        
        public QAManagement.WorkingSite.CommentService.UpdateCommentResponse UpdateComment(QAManagement.WorkingSite.CommentService.UpdateCommentRequest request) {
            return base.Channel.UpdateComment(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginUpdateComment(QAManagement.WorkingSite.CommentService.UpdateCommentRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUpdateComment(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public QAManagement.WorkingSite.CommentService.UpdateCommentResponse EndUpdateComment(System.IAsyncResult result) {
            return base.Channel.EndUpdateComment(result);
        }
        
        private System.IAsyncResult OnBeginUpdateComment(object[] inValues, System.AsyncCallback callback, object asyncState) {
            QAManagement.WorkingSite.CommentService.UpdateCommentRequest request = ((QAManagement.WorkingSite.CommentService.UpdateCommentRequest)(inValues[0]));
            return this.BeginUpdateComment(request, callback, asyncState);
        }
        
        private object[] OnEndUpdateComment(System.IAsyncResult result) {
            QAManagement.WorkingSite.CommentService.UpdateCommentResponse retVal = this.EndUpdateComment(result);
            return new object[] {
                    retVal};
        }
        
        private void OnUpdateCommentCompleted(object state) {
            if ((this.UpdateCommentCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UpdateCommentCompleted(this, new UpdateCommentCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UpdateCommentAsync(QAManagement.WorkingSite.CommentService.UpdateCommentRequest request) {
            this.UpdateCommentAsync(request, null);
        }
        
        public void UpdateCommentAsync(QAManagement.WorkingSite.CommentService.UpdateCommentRequest request, object userState) {
            if ((this.onBeginUpdateCommentDelegate == null)) {
                this.onBeginUpdateCommentDelegate = new BeginOperationDelegate(this.OnBeginUpdateComment);
            }
            if ((this.onEndUpdateCommentDelegate == null)) {
                this.onEndUpdateCommentDelegate = new EndOperationDelegate(this.OnEndUpdateComment);
            }
            if ((this.onUpdateCommentCompletedDelegate == null)) {
                this.onUpdateCommentCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUpdateCommentCompleted);
            }
            base.InvokeAsync(this.onBeginUpdateCommentDelegate, new object[] {
                        request}, this.onEndUpdateCommentDelegate, this.onUpdateCommentCompletedDelegate, userState);
        }
    }
}
