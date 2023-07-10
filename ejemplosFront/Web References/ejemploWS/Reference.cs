﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace ejemplosFront.ejemploWS {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebService1Soap", Namespace="http://tempuri.org/")]
    public partial class WebService1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback obtenerPersonaOperationCompleted;
        
        private System.Threading.SendOrPostCallback BuscarPorNombreOperationCompleted;
        
        private System.Threading.SendOrPostCallback personaAltaOperationCompleted;
        
        private System.Threading.SendOrPostCallback modificarPersonaOperationCompleted;
        
        private System.Threading.SendOrPostCallback eliminarPersonaOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService1() {
            this.Url = global::ejemplosFront.Properties.Settings.Default.ejemplosFront_ejemploWS_WebService1;
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
        public event obtenerPersonaCompletedEventHandler obtenerPersonaCompleted;
        
        /// <remarks/>
        public event BuscarPorNombreCompletedEventHandler BuscarPorNombreCompleted;
        
        /// <remarks/>
        public event personaAltaCompletedEventHandler personaAltaCompleted;
        
        /// <remarks/>
        public event modificarPersonaCompletedEventHandler modificarPersonaCompleted;
        
        /// <remarks/>
        public event eliminarPersonaCompletedEventHandler eliminarPersonaCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/obtenerPersona", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Persona[] obtenerPersona(int cuil) {
            object[] results = this.Invoke("obtenerPersona", new object[] {
                        cuil});
            return ((Persona[])(results[0]));
        }
        
        /// <remarks/>
        public void obtenerPersonaAsync(int cuil) {
            this.obtenerPersonaAsync(cuil, null);
        }
        
        /// <remarks/>
        public void obtenerPersonaAsync(int cuil, object userState) {
            if ((this.obtenerPersonaOperationCompleted == null)) {
                this.obtenerPersonaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnobtenerPersonaOperationCompleted);
            }
            this.InvokeAsync("obtenerPersona", new object[] {
                        cuil}, this.obtenerPersonaOperationCompleted, userState);
        }
        
        private void OnobtenerPersonaOperationCompleted(object arg) {
            if ((this.obtenerPersonaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.obtenerPersonaCompleted(this, new obtenerPersonaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BuscarPorNombre", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Persona[] BuscarPorNombre(string nombre) {
            object[] results = this.Invoke("BuscarPorNombre", new object[] {
                        nombre});
            return ((Persona[])(results[0]));
        }
        
        /// <remarks/>
        public void BuscarPorNombreAsync(string nombre) {
            this.BuscarPorNombreAsync(nombre, null);
        }
        
        /// <remarks/>
        public void BuscarPorNombreAsync(string nombre, object userState) {
            if ((this.BuscarPorNombreOperationCompleted == null)) {
                this.BuscarPorNombreOperationCompleted = new System.Threading.SendOrPostCallback(this.OnBuscarPorNombreOperationCompleted);
            }
            this.InvokeAsync("BuscarPorNombre", new object[] {
                        nombre}, this.BuscarPorNombreOperationCompleted, userState);
        }
        
        private void OnBuscarPorNombreOperationCompleted(object arg) {
            if ((this.BuscarPorNombreCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.BuscarPorNombreCompleted(this, new BuscarPorNombreCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/personaAlta", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Persona personaAlta(Persona nuevo) {
            object[] results = this.Invoke("personaAlta", new object[] {
                        nuevo});
            return ((Persona)(results[0]));
        }
        
        /// <remarks/>
        public void personaAltaAsync(Persona nuevo) {
            this.personaAltaAsync(nuevo, null);
        }
        
        /// <remarks/>
        public void personaAltaAsync(Persona nuevo, object userState) {
            if ((this.personaAltaOperationCompleted == null)) {
                this.personaAltaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnpersonaAltaOperationCompleted);
            }
            this.InvokeAsync("personaAlta", new object[] {
                        nuevo}, this.personaAltaOperationCompleted, userState);
        }
        
        private void OnpersonaAltaOperationCompleted(object arg) {
            if ((this.personaAltaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.personaAltaCompleted(this, new personaAltaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/modificarPersona", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Persona modificarPersona(Persona persona) {
            object[] results = this.Invoke("modificarPersona", new object[] {
                        persona});
            return ((Persona)(results[0]));
        }
        
        /// <remarks/>
        public void modificarPersonaAsync(Persona persona) {
            this.modificarPersonaAsync(persona, null);
        }
        
        /// <remarks/>
        public void modificarPersonaAsync(Persona persona, object userState) {
            if ((this.modificarPersonaOperationCompleted == null)) {
                this.modificarPersonaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnmodificarPersonaOperationCompleted);
            }
            this.InvokeAsync("modificarPersona", new object[] {
                        persona}, this.modificarPersonaOperationCompleted, userState);
        }
        
        private void OnmodificarPersonaOperationCompleted(object arg) {
            if ((this.modificarPersonaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.modificarPersonaCompleted(this, new modificarPersonaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/eliminarPersona", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Persona eliminarPersona(Persona id) {
            object[] results = this.Invoke("eliminarPersona", new object[] {
                        id});
            return ((Persona)(results[0]));
        }
        
        /// <remarks/>
        public void eliminarPersonaAsync(Persona id) {
            this.eliminarPersonaAsync(id, null);
        }
        
        /// <remarks/>
        public void eliminarPersonaAsync(Persona id, object userState) {
            if ((this.eliminarPersonaOperationCompleted == null)) {
                this.eliminarPersonaOperationCompleted = new System.Threading.SendOrPostCallback(this.OneliminarPersonaOperationCompleted);
            }
            this.InvokeAsync("eliminarPersona", new object[] {
                        id}, this.eliminarPersonaOperationCompleted, userState);
        }
        
        private void OneliminarPersonaOperationCompleted(object arg) {
            if ((this.eliminarPersonaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.eliminarPersonaCompleted(this, new eliminarPersonaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Persona {
        
        private int idField;
        
        private int cuilField;
        
        private string apellidoYNombreField;
        
        private System.DateTime fechaNacimientoField;
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public int Cuil {
            get {
                return this.cuilField;
            }
            set {
                this.cuilField = value;
            }
        }
        
        /// <remarks/>
        public string ApellidoYNombre {
            get {
                return this.apellidoYNombreField;
            }
            set {
                this.apellidoYNombreField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime fechaNacimiento {
            get {
                return this.fechaNacimientoField;
            }
            set {
                this.fechaNacimientoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void obtenerPersonaCompletedEventHandler(object sender, obtenerPersonaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class obtenerPersonaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal obtenerPersonaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Persona[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Persona[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void BuscarPorNombreCompletedEventHandler(object sender, BuscarPorNombreCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuscarPorNombreCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal BuscarPorNombreCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Persona[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Persona[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void personaAltaCompletedEventHandler(object sender, personaAltaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class personaAltaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal personaAltaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Persona Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Persona)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void modificarPersonaCompletedEventHandler(object sender, modificarPersonaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class modificarPersonaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal modificarPersonaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Persona Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Persona)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void eliminarPersonaCompletedEventHandler(object sender, eliminarPersonaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class eliminarPersonaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal eliminarPersonaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Persona Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Persona)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591