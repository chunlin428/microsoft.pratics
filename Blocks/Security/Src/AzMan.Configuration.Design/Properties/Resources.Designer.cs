﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.EnterpriseLibrary.Security.AzMan.Configuration.Design.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.EnterpriseLibrary.Security.AzMan.Configuration.Design.Propert" +
                            "ies.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gets or sets the Authorization Manager application name..
        /// </summary>
        internal static string ApplicationDescription {
            get {
                return ResourceManager.GetString("ApplicationDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gets or sets the prefix to append to each audit identifier.  Audit identifier will be the &quot;&lt;prefix&gt; &lt;username&gt;:&lt;operation&gt;&quot;.  Optional..
        /// </summary>
        internal static string AuditIdentiferPrefixDescription {
            get {
                return ResourceManager.GetString("AuditIdentiferPrefixDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gets or sets the audit identifier prefix to append to the generated audit identifer.The audit identifier is generated to be &quot;prefix username:operation&quot;..
        /// </summary>
        internal static string AuditIdentifierPrefixDescription {
            get {
                return ResourceManager.GetString("AuditIdentifierPrefixDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AzMan Provider.
        /// </summary>
        internal static string AzManProvider {
            get {
                return ResourceManager.GetString("AzManProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to General.
        /// </summary>
        internal static string CategoryGeneral {
            get {
                return ResourceManager.GetString("CategoryGeneral", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create a new {0}.
        /// </summary>
        internal static string GenericCreateStatusText {
            get {
                return ResourceManager.GetString("GenericCreateStatusText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gets or sets the Application scope name.  Optional..
        /// </summary>
        internal static string ScopeDescription {
            get {
                return ResourceManager.GetString("ScopeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Gets or sets the authorization store location Active Directory or xml file.  For xml file storage - msxml://c:/temp/authstore.xml.  For Active Directory storage - msldap://myserver/CN=MyStore,OU=AzMan,DC=MyDomain,DC=Com.
        /// </summary>
        internal static string StoreLocationDescription {
            get {
                return ResourceManager.GetString("StoreLocationDescription", resourceCulture);
            }
        }
    }
}
