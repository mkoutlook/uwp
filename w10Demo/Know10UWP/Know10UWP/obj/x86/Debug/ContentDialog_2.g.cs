﻿#pragma checksum "F:\Mayurdhvajsinh\practice\w10Demo\Know10UWP\Know10UWP\ContentDialog_2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "37ACE466E628AE0BFF32B7117798A656"
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
    partial class ContentDialog_2 : 
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
                    this.termsOfUseContentDialog = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                    #line 14 "..\..\..\ContentDialog_2.xaml"
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)this.termsOfUseContentDialog).Opened += this.TermsOfUseContentDialog_Opened;
                    #line default
                }
                break;
            case 2:
                {
                    this.ConfirmAgeCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 35 "..\..\..\ContentDialog_2.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ConfirmAgeCheckBox).Checked += this.ConfirmAgeCheckBox_Checked;
                    #line 35 "..\..\..\ContentDialog_2.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.ConfirmAgeCheckBox).Unchecked += this.ConfirmAgeCheckBox_Unchecked;
                    #line default
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

