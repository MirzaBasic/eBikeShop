﻿

#pragma checksum "H:\Windows\DesktopWeb\PEP-Seminarski\PeP\PeP\PeP_Mobile\Products\Pretraga.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "83199886218EC7F3DB58E6F630E612D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PeP_Mobile.Products
{
    partial class Pretraga : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 13 "..\..\Products\Pretraga.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.pretragaNazivInput_TextChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 15 "..\..\Products\Pretraga.xaml"
                ((global::Windows.UI.Xaml.Controls.ListViewBase)(target)).ItemClick += this.listProizvodiNaziv_ItemClick;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


