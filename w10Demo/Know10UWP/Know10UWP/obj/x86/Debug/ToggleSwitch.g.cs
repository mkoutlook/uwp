﻿#pragma checksum "F:\Mayurdhvajsinh\practice\w10Demo\Know10UWP\Know10UWP\ToggleSwitch.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D36D014CEDBBAB182697AC02622C7871"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Know10UWP
{
    partial class ToggleSwitch : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.tgswtch = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    #line 15 "..\..\..\ToggleSwitch.xaml"
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.tgswtch).Toggled += this.ToggleSwitch_Toggled;
                    #line default
                }
                break;
            case 2:
                {
                    this.progress1 = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
