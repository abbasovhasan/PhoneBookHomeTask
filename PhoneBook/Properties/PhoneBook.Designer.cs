﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhoneBook.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.11.0.0")]
    internal sealed partial class PhoneBook : global::System.Configuration.ApplicationSettingsBase {
        
        private static PhoneBook defaultInstance = ((PhoneBook)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new PhoneBook())));
        
        public static PhoneBook Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("server=localhost;database=PhoneBook;Trusted_Connection=True;")]
        public string Connection {
            get {
                return ((string)(this["Connection"]));
            }
        }
    }
}
