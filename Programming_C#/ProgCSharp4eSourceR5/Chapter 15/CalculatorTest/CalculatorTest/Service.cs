﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version:2.0.40607.16
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=2.0.40607.16.
// 


/// <remarks/>
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="ServiceSoap", Namespace="http://tempuri.org/")]
public class Service : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback AddOperationCompleted;
    
    private System.Threading.SendOrPostCallback SubOperationCompleted;
    
    private System.Threading.SendOrPostCallback MultOperationCompleted;
    
    private System.Threading.SendOrPostCallback DivOperationCompleted;
    
    private System.Threading.SendOrPostCallback PowOperationCompleted;
    
    /// <remarks/>
    public Service() {
        this.Url = "http://localhost:19975/CalculatorWS/Service.asmx";
    }
    
    /// <remarks/>
    public event AddCompletedEventHandler AddCompleted;
    
    /// <remarks/>
    public event SubCompletedEventHandler SubCompleted;
    
    /// <remarks/>
    public event MultCompletedEventHandler MultCompleted;
    
    /// <remarks/>
    public event DivCompletedEventHandler DivCompleted;
    
    /// <remarks/>
    public event PowCompletedEventHandler PowCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Add", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public double Add(double x, double y) {
        object[] results = this.Invoke("Add", new object[] {
                    x,
                    y});
        return ((double)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginAdd(double x, double y, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("Add", new object[] {
                    x,
                    y}, callback, asyncState);
    }
    
    /// <remarks/>
    public double EndAdd(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((double)(results[0]));
    }
    
    /// <remarks/>
    public void AddAsync(double x, double y) {
        this.AddAsync(x, y, null);
    }
    
    /// <remarks/>
    public void AddAsync(double x, double y, object userState) {
        if ((this.AddOperationCompleted == null)) {
            this.AddOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddOperationCompleted);
        }
        this.InvokeAsync("Add", new object[] {
                    x,
                    y}, this.AddOperationCompleted, userState);
    }
    
    private void OnAddOperationCompleted(object arg) {
        if ((this.AddCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.AddCompleted(this, new AddCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Sub", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public double Sub(double x, double y) {
        object[] results = this.Invoke("Sub", new object[] {
                    x,
                    y});
        return ((double)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginSub(double x, double y, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("Sub", new object[] {
                    x,
                    y}, callback, asyncState);
    }
    
    /// <remarks/>
    public double EndSub(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((double)(results[0]));
    }
    
    /// <remarks/>
    public void SubAsync(double x, double y) {
        this.SubAsync(x, y, null);
    }
    
    /// <remarks/>
    public void SubAsync(double x, double y, object userState) {
        if ((this.SubOperationCompleted == null)) {
            this.SubOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSubOperationCompleted);
        }
        this.InvokeAsync("Sub", new object[] {
                    x,
                    y}, this.SubOperationCompleted, userState);
    }
    
    private void OnSubOperationCompleted(object arg) {
        if ((this.SubCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.SubCompleted(this, new SubCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Mult", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public double Mult(double x, double y) {
        object[] results = this.Invoke("Mult", new object[] {
                    x,
                    y});
        return ((double)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginMult(double x, double y, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("Mult", new object[] {
                    x,
                    y}, callback, asyncState);
    }
    
    /// <remarks/>
    public double EndMult(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((double)(results[0]));
    }
    
    /// <remarks/>
    public void MultAsync(double x, double y) {
        this.MultAsync(x, y, null);
    }
    
    /// <remarks/>
    public void MultAsync(double x, double y, object userState) {
        if ((this.MultOperationCompleted == null)) {
            this.MultOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMultOperationCompleted);
        }
        this.InvokeAsync("Mult", new object[] {
                    x,
                    y}, this.MultOperationCompleted, userState);
    }
    
    private void OnMultOperationCompleted(object arg) {
        if ((this.MultCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.MultCompleted(this, new MultCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Div", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public double Div(double x, double y) {
        object[] results = this.Invoke("Div", new object[] {
                    x,
                    y});
        return ((double)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginDiv(double x, double y, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("Div", new object[] {
                    x,
                    y}, callback, asyncState);
    }
    
    /// <remarks/>
    public double EndDiv(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((double)(results[0]));
    }
    
    /// <remarks/>
    public void DivAsync(double x, double y) {
        this.DivAsync(x, y, null);
    }
    
    /// <remarks/>
    public void DivAsync(double x, double y, object userState) {
        if ((this.DivOperationCompleted == null)) {
            this.DivOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDivOperationCompleted);
        }
        this.InvokeAsync("Div", new object[] {
                    x,
                    y}, this.DivOperationCompleted, userState);
    }
    
    private void OnDivOperationCompleted(object arg) {
        if ((this.DivCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.DivCompleted(this, new DivCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Pow", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    public double Pow(double x, double y) {
        object[] results = this.Invoke("Pow", new object[] {
                    x,
                    y});
        return ((double)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult BeginPow(double x, double y, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("Pow", new object[] {
                    x,
                    y}, callback, asyncState);
    }
    
    /// <remarks/>
    public double EndPow(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((double)(results[0]));
    }
    
    /// <remarks/>
    public void PowAsync(double x, double y) {
        this.PowAsync(x, y, null);
    }
    
    /// <remarks/>
    public void PowAsync(double x, double y, object userState) {
        if ((this.PowOperationCompleted == null)) {
            this.PowOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPowOperationCompleted);
        }
        this.InvokeAsync("Pow", new object[] {
                    x,
                    y}, this.PowOperationCompleted, userState);
    }
    
    private void OnPowOperationCompleted(object arg) {
        if ((this.PowCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.PowCompleted(this, new PowCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
public delegate void AddCompletedEventHandler(object sender, AddCompletedEventArgs args);

/// <remarks/>
public class AddCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal AddCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public double Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((double)(this.results[0]));
        }
    }
}

/// <remarks/>
public delegate void SubCompletedEventHandler(object sender, SubCompletedEventArgs args);

/// <remarks/>
public class SubCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal SubCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public double Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((double)(this.results[0]));
        }
    }
}

/// <remarks/>
public delegate void MultCompletedEventHandler(object sender, MultCompletedEventArgs args);

/// <remarks/>
public class MultCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal MultCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public double Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((double)(this.results[0]));
        }
    }
}

/// <remarks/>
public delegate void DivCompletedEventHandler(object sender, DivCompletedEventArgs args);

/// <remarks/>
public class DivCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal DivCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public double Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((double)(this.results[0]));
        }
    }
}

/// <remarks/>
public delegate void PowCompletedEventHandler(object sender, PowCompletedEventArgs args);

/// <remarks/>
public class PowCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal PowCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public double Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((double)(this.results[0]));
        }
    }
}
