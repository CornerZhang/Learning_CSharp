﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version:2.0.40607.16
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace DeclarativeDataDisplay.Properties {
    
    
    sealed partial class Settings : System.Configuration.ApplicationSettingsBase {
        
        private static Settings m_Value;
        
        private static object m_SyncObject = new object();
        
        [System.Diagnostics.DebuggerNonUserCode()]
        public static Settings Value {
            get {
                if ((Settings.m_Value == null)) {
                    System.Threading.Monitor.Enter(Settings.m_SyncObject);
                    if ((Settings.m_Value == null)) {
                        try {
                            Settings.m_Value = new Settings();
                        }
                        finally {
                            System.Threading.Monitor.Exit(Settings.m_SyncObject);
                        }
                    }
                }
                return Settings.m_Value;
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCode()]
        [System.Configuration.SpecialSetting(System.Configuration.SpecialSetting.ConnectionString)]
        [System.Configuration.ApplicationScopedSettingAttribute()]
        [System.Configuration.DefaultSettingValueAttribute("Server=BACH;User ID=sa;Password=oWenmEany;Database=Northwind;Persist Security Inf" +
            "o=True")]
        public string NorthwindConnection {
            get {
                return ((string)(this["NorthwindConnection"]));
            }
        }
    }
}
