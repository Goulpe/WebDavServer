//------------------------------------------------------------------------------
// <auto-generated>
//     This code has been generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FubarDev.WebDavServer.Model {
    using System;
    using System.Collections.Generic;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute("propfind", Namespace="DAV:", IsNullable=false)]
    public partial class Propfind {
        
        private object[] itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("allprop", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("include", typeof(Include))]
        [System.Xml.Serialization.XmlElementAttribute("prop", typeof(Prop))]
        [System.Xml.Serialization.XmlElementAttribute("propname", typeof(object))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("include", Namespace="DAV:")]
    public partial class Include {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("prop", Namespace="DAV:")]
    public partial class Prop {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:", IncludeInSchema=false)]
    public enum ItemsChoiceType {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("allprop")]
        Allprop,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("include")]
        Include,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("prop")]
        Prop,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("propname")]
        Propname,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("multistatus", AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute("multistatus", Namespace="DAV:", IsNullable=false)]
    public partial class Multistatus {
        
        private Response[] responseField;
        
        private string responsedescriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("response")]
        public Response[] Response {
            get {
                return this.responseField;
            }
            set {
                this.responseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("responsedescription")]
        public string Responsedescription {
            get {
                return this.responsedescriptionField;
            }
            set {
                this.responsedescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("response", AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute("response", Namespace="DAV:", IsNullable=false)]
    public partial class Response {
        
        private string hrefField;
        
        private object[] itemsField;
        
        private ItemsChoiceType1[] itemsElementNameField;
        
        private Error errorField;
        
        private string responsedescriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("href", DataType="anyURI", Order=0)]
        public string Href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("href", typeof(string), DataType="anyURI", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("propstat", typeof(Propstat), Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("status", typeof(string), Order=1)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order=2)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("error", Order=3)]
        public Error Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("responsedescription", Order=4)]
        public string Responsedescription {
            get {
                return this.responsedescriptionField;
            }
            set {
                this.responsedescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("propstat", Namespace="DAV:")]
    public partial class Propstat {
        
        private Prop propField;
        
        private string statusField;
        
        private Error errorField;
        
        private string responsedescriptionField;
        
        private Location locationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("prop")]
        public Prop Prop {
            get {
                return this.propField;
            }
            set {
                this.propField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("status")]
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("error")]
        public Error Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("responsedescription")]
        public string Responsedescription {
            get {
                return this.responsedescriptionField;
            }
            set {
                this.responsedescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("location")]
        public Location Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("error", Namespace="DAV:")]
    public partial class Error {
        
        private System.Xml.Linq.XElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.Linq.XElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("location", Namespace="DAV:")]
    public partial class Location {
        
        private string hrefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("href", DataType="anyURI")]
        public string Href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:", IncludeInSchema=false)]
    public enum ItemsChoiceType1 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("href")]
        Href,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("propstat")]
        Propstat,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("status")]
        Status,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("error", AnonymousType=true, Namespace="DAV:")]
    [System.Xml.Serialization.XmlRootAttribute("error", Namespace="DAV:", IsNullable=false)]
    public partial class Error1 {
        
        private object[] itemsField;
        
        private ItemsChoiceType2[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("cannot-modify-protected-property", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("lock-token-matches-request-uri", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("lock-token-submitted", typeof(LockTokenSubmitted))]
        [System.Xml.Serialization.XmlElementAttribute("no-conflicting-lock", typeof(NoConflictingLock))]
        [System.Xml.Serialization.XmlElementAttribute("no-external-entities", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("preserved-live-properties", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("propfind-finite-depth", typeof(object))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName {
            get {
                return this.itemsElementNameField;
            }
            set {
                this.itemsElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    public partial class LockTokenSubmitted {
        
        private string[] hrefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("href", DataType="anyURI")]
        public string[] Href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="DAV:")]
    public partial class NoConflictingLock {
        
        private string[] hrefField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("href", DataType="anyURI")]
        public string[] Href {
            get {
                return this.hrefField;
            }
            set {
                this.hrefField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2", "1.0.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="DAV:", IncludeInSchema=false)]
    public enum ItemsChoiceType2 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Any,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cannot-modify-protected-property")]
        CannotModifyProtectedProperty,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("lock-token-matches-request-uri")]
        LockTokenMatchesRequestUri,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("lock-token-submitted")]
        LockTokenSubmitted,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("no-conflicting-lock")]
        NoConflictingLock,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("no-external-entities")]
        NoExternalEntities,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("preserved-live-properties")]
        PreservedLiveProperties,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("propfind-finite-depth")]
        PropfindFiniteDepth,
    }
}
