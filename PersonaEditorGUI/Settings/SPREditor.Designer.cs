﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonaEditorGUI.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0")]
    internal sealed partial class SPREditor : global::System.Configuration.ApplicationSettingsBase {
        
        private static SPREditor defaultInstance = ((SPREditor)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new SPREditor())));
        
        public static SPREditor Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FF909090")]
        public global::System.Windows.Media.Color BackgroundColor {
            get {
                return ((global::System.Windows.Media.Color)(this["BackgroundColor"]));
            }
            set {
                this["BackgroundColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FF000000")]
        public global::System.Windows.Media.Color LineColor {
            get {
                return ((global::System.Windows.Media.Color)(this["LineColor"]));
            }
            set {
                this["LineColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#80FF6600")]
        public global::System.Windows.Media.Color SelectColor {
            get {
                return ((global::System.Windows.Media.Color)(this["SelectColor"]));
            }
            set {
                this["SelectColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int BorderThickness {
            get {
                return ((int)(this["BorderThickness"]));
            }
            set {
                this["BorderThickness"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("P5")]
        public string DefaultEncoding {
            get {
                return ((string)(this["DefaultEncoding"]));
            }
            set {
                this["DefaultEncoding"] = value;
            }
        }
    }
}
