﻿#pragma checksum "F:\Mayurdhvajsinh\practice\w10Demo\Know10UWP\Know10UWP\FlipView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "38E788BF78E44A865F8E73C0B8D3E79C"
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
    partial class FlipView : 
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
                    this.flipView1 = (global::Windows.UI.Xaml.Controls.FlipView)(target);
                    #line 11 "..\..\..\FlipView.xaml"
                    ((global::Windows.UI.Xaml.Controls.FlipView)this.flipView1).SelectionChanged += this.FlipView_SelectionChanged;
                    #line default
                }
                break;
            case 2:
                {
                    this.flipView12 = (global::Windows.UI.Xaml.Controls.FlipView)(target);
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

