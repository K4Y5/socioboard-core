﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace Socioboard.Api.TwitterFeed {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TwitterFeedSoap", Namespace="http://tempuri.org/")]
    public partial class TwitterFeed : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAllTwitterFeedsByUserIdAndProfileIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAllFeedsByUserIdAndProfileIdUsingLimitOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllTwitterFeedsByUserIdAndProfileId1OperationCompleted;
        
        private System.Threading.SendOrPostCallback getAllTwitterFeedOfUsersOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTwitterFeedByIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback getTwitterFeedByProfileIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TwitterFeed() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_TwitterFeed_TwitterFeed;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetAllTwitterFeedsByUserIdAndProfileIdCompletedEventHandler GetAllTwitterFeedsByUserIdAndProfileIdCompleted;
        
        /// <remarks/>
        public event getAllFeedsByUserIdAndProfileIdUsingLimitCompletedEventHandler getAllFeedsByUserIdAndProfileIdUsingLimitCompleted;
        
        /// <remarks/>
        public event GetAllTwitterFeedsByUserIdAndProfileId1CompletedEventHandler GetAllTwitterFeedsByUserIdAndProfileId1Completed;
        
        /// <remarks/>
        public event getAllTwitterFeedOfUsersCompletedEventHandler getAllTwitterFeedOfUsersCompleted;
        
        /// <remarks/>
        public event GetTwitterFeedByIdCompletedEventHandler GetTwitterFeedByIdCompleted;
        
        /// <remarks/>
        public event getTwitterFeedByProfileIdCompletedEventHandler getTwitterFeedByProfileIdCompleted;
        
        /// <remarks/>
        public event GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordCompletedEventHandler GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllTwitterFeedsByUserIdAndProfileId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllTwitterFeedsByUserIdAndProfileId(string UserId, string ProfileId) {
            object[] results = this.Invoke("GetAllTwitterFeedsByUserIdAndProfileId", new object[] {
                        UserId,
                        ProfileId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllTwitterFeedsByUserIdAndProfileIdAsync(string UserId, string ProfileId) {
            this.GetAllTwitterFeedsByUserIdAndProfileIdAsync(UserId, ProfileId, null);
        }
        
        /// <remarks/>
        public void GetAllTwitterFeedsByUserIdAndProfileIdAsync(string UserId, string ProfileId, object userState) {
            if ((this.GetAllTwitterFeedsByUserIdAndProfileIdOperationCompleted == null)) {
                this.GetAllTwitterFeedsByUserIdAndProfileIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllTwitterFeedsByUserIdAndProfileIdOperationCompleted);
            }
            this.InvokeAsync("GetAllTwitterFeedsByUserIdAndProfileId", new object[] {
                        UserId,
                        ProfileId}, this.GetAllTwitterFeedsByUserIdAndProfileIdOperationCompleted, userState);
        }
        
        private void OnGetAllTwitterFeedsByUserIdAndProfileIdOperationCompleted(object arg) {
            if ((this.GetAllTwitterFeedsByUserIdAndProfileIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllTwitterFeedsByUserIdAndProfileIdCompleted(this, new GetAllTwitterFeedsByUserIdAndProfileIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAllFeedsByUserIdAndProfileIdUsingLimit", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getAllFeedsByUserIdAndProfileIdUsingLimit(string UserId, string ProfileId, string noOfDataToSkip, string noOfResultsFromTop) {
            object[] results = this.Invoke("getAllFeedsByUserIdAndProfileIdUsingLimit", new object[] {
                        UserId,
                        ProfileId,
                        noOfDataToSkip,
                        noOfResultsFromTop});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAllFeedsByUserIdAndProfileIdUsingLimitAsync(string UserId, string ProfileId, string noOfDataToSkip, string noOfResultsFromTop) {
            this.getAllFeedsByUserIdAndProfileIdUsingLimitAsync(UserId, ProfileId, noOfDataToSkip, noOfResultsFromTop, null);
        }
        
        /// <remarks/>
        public void getAllFeedsByUserIdAndProfileIdUsingLimitAsync(string UserId, string ProfileId, string noOfDataToSkip, string noOfResultsFromTop, object userState) {
            if ((this.getAllFeedsByUserIdAndProfileIdUsingLimitOperationCompleted == null)) {
                this.getAllFeedsByUserIdAndProfileIdUsingLimitOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllFeedsByUserIdAndProfileIdUsingLimitOperationCompleted);
            }
            this.InvokeAsync("getAllFeedsByUserIdAndProfileIdUsingLimit", new object[] {
                        UserId,
                        ProfileId,
                        noOfDataToSkip,
                        noOfResultsFromTop}, this.getAllFeedsByUserIdAndProfileIdUsingLimitOperationCompleted, userState);
        }
        
        private void OngetAllFeedsByUserIdAndProfileIdUsingLimitOperationCompleted(object arg) {
            if ((this.getAllFeedsByUserIdAndProfileIdUsingLimitCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllFeedsByUserIdAndProfileIdUsingLimitCompleted(this, new getAllFeedsByUserIdAndProfileIdUsingLimitCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllTwitterFeedsByUserIdAndProfileId1", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllTwitterFeedsByUserIdAndProfileId1(string UserId, string ProfileId, int count) {
            object[] results = this.Invoke("GetAllTwitterFeedsByUserIdAndProfileId1", new object[] {
                        UserId,
                        ProfileId,
                        count});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllTwitterFeedsByUserIdAndProfileId1Async(string UserId, string ProfileId, int count) {
            this.GetAllTwitterFeedsByUserIdAndProfileId1Async(UserId, ProfileId, count, null);
        }
        
        /// <remarks/>
        public void GetAllTwitterFeedsByUserIdAndProfileId1Async(string UserId, string ProfileId, int count, object userState) {
            if ((this.GetAllTwitterFeedsByUserIdAndProfileId1OperationCompleted == null)) {
                this.GetAllTwitterFeedsByUserIdAndProfileId1OperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllTwitterFeedsByUserIdAndProfileId1OperationCompleted);
            }
            this.InvokeAsync("GetAllTwitterFeedsByUserIdAndProfileId1", new object[] {
                        UserId,
                        ProfileId,
                        count}, this.GetAllTwitterFeedsByUserIdAndProfileId1OperationCompleted, userState);
        }
        
        private void OnGetAllTwitterFeedsByUserIdAndProfileId1OperationCompleted(object arg) {
            if ((this.GetAllTwitterFeedsByUserIdAndProfileId1Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllTwitterFeedsByUserIdAndProfileId1Completed(this, new GetAllTwitterFeedsByUserIdAndProfileId1CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getAllTwitterFeedOfUsers", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getAllTwitterFeedOfUsers(string UserId, string ProfileId) {
            object[] results = this.Invoke("getAllTwitterFeedOfUsers", new object[] {
                        UserId,
                        ProfileId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAllTwitterFeedOfUsersAsync(string UserId, string ProfileId) {
            this.getAllTwitterFeedOfUsersAsync(UserId, ProfileId, null);
        }
        
        /// <remarks/>
        public void getAllTwitterFeedOfUsersAsync(string UserId, string ProfileId, object userState) {
            if ((this.getAllTwitterFeedOfUsersOperationCompleted == null)) {
                this.getAllTwitterFeedOfUsersOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAllTwitterFeedOfUsersOperationCompleted);
            }
            this.InvokeAsync("getAllTwitterFeedOfUsers", new object[] {
                        UserId,
                        ProfileId}, this.getAllTwitterFeedOfUsersOperationCompleted, userState);
        }
        
        private void OngetAllTwitterFeedOfUsersOperationCompleted(object arg) {
            if ((this.getAllTwitterFeedOfUsersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAllTwitterFeedOfUsersCompleted(this, new getAllTwitterFeedOfUsersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTwitterFeedById", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTwitterFeedById(string id) {
            object[] results = this.Invoke("GetTwitterFeedById", new object[] {
                        id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTwitterFeedByIdAsync(string id) {
            this.GetTwitterFeedByIdAsync(id, null);
        }
        
        /// <remarks/>
        public void GetTwitterFeedByIdAsync(string id, object userState) {
            if ((this.GetTwitterFeedByIdOperationCompleted == null)) {
                this.GetTwitterFeedByIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTwitterFeedByIdOperationCompleted);
            }
            this.InvokeAsync("GetTwitterFeedById", new object[] {
                        id}, this.GetTwitterFeedByIdOperationCompleted, userState);
        }
        
        private void OnGetTwitterFeedByIdOperationCompleted(object arg) {
            if ((this.GetTwitterFeedByIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTwitterFeedByIdCompleted(this, new GetTwitterFeedByIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/getTwitterFeedByProfileId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getTwitterFeedByProfileId(string ProfileId, string MessageId) {
            object[] results = this.Invoke("getTwitterFeedByProfileId", new object[] {
                        ProfileId,
                        MessageId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getTwitterFeedByProfileIdAsync(string ProfileId, string MessageId) {
            this.getTwitterFeedByProfileIdAsync(ProfileId, MessageId, null);
        }
        
        /// <remarks/>
        public void getTwitterFeedByProfileIdAsync(string ProfileId, string MessageId, object userState) {
            if ((this.getTwitterFeedByProfileIdOperationCompleted == null)) {
                this.getTwitterFeedByProfileIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTwitterFeedByProfileIdOperationCompleted);
            }
            this.InvokeAsync("getTwitterFeedByProfileId", new object[] {
                        ProfileId,
                        MessageId}, this.getTwitterFeedByProfileIdOperationCompleted, userState);
        }
        
        private void OngetTwitterFeedByProfileIdOperationCompleted(object arg) {
            if ((this.getTwitterFeedByProfileIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTwitterFeedByProfileIdCompleted(this, new getTwitterFeedByProfileIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllTwitterFeedsByUserIdAndProfileId1ByKeyword", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllTwitterFeedsByUserIdAndProfileId1ByKeyword(string UserId, string ProfileId, string keyword, int count) {
            object[] results = this.Invoke("GetAllTwitterFeedsByUserIdAndProfileId1ByKeyword", new object[] {
                        UserId,
                        ProfileId,
                        keyword,
                        count});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordAsync(string UserId, string ProfileId, string keyword, int count) {
            this.GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordAsync(UserId, ProfileId, keyword, count, null);
        }
        
        /// <remarks/>
        public void GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordAsync(string UserId, string ProfileId, string keyword, int count, object userState) {
            if ((this.GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordOperationCompleted == null)) {
                this.GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllTwitterFeedsByUserIdAndProfileId1ByKeywordOperationCompleted);
            }
            this.InvokeAsync("GetAllTwitterFeedsByUserIdAndProfileId1ByKeyword", new object[] {
                        UserId,
                        ProfileId,
                        keyword,
                        count}, this.GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordOperationCompleted, userState);
        }
        
        private void OnGetAllTwitterFeedsByUserIdAndProfileId1ByKeywordOperationCompleted(object arg) {
            if ((this.GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordCompleted(this, new GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetAllTwitterFeedsByUserIdAndProfileIdCompletedEventHandler(object sender, GetAllTwitterFeedsByUserIdAndProfileIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllTwitterFeedsByUserIdAndProfileIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllTwitterFeedsByUserIdAndProfileIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getAllFeedsByUserIdAndProfileIdUsingLimitCompletedEventHandler(object sender, getAllFeedsByUserIdAndProfileIdUsingLimitCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllFeedsByUserIdAndProfileIdUsingLimitCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllFeedsByUserIdAndProfileIdUsingLimitCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetAllTwitterFeedsByUserIdAndProfileId1CompletedEventHandler(object sender, GetAllTwitterFeedsByUserIdAndProfileId1CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllTwitterFeedsByUserIdAndProfileId1CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllTwitterFeedsByUserIdAndProfileId1CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getAllTwitterFeedOfUsersCompletedEventHandler(object sender, getAllTwitterFeedOfUsersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAllTwitterFeedOfUsersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAllTwitterFeedOfUsersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetTwitterFeedByIdCompletedEventHandler(object sender, GetTwitterFeedByIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTwitterFeedByIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTwitterFeedByIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void getTwitterFeedByProfileIdCompletedEventHandler(object sender, getTwitterFeedByProfileIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTwitterFeedByProfileIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getTwitterFeedByProfileIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordCompletedEventHandler(object sender, GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllTwitterFeedsByUserIdAndProfileId1ByKeywordCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591