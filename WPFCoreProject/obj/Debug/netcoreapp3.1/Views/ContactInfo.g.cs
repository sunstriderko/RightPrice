﻿#pragma checksum "..\..\..\..\Views\ContactInfo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CC83A2FBF8DD5C6B901030C8C20BA9DDFD1DB8B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPFCoreProjectUI.Views;


namespace WPFCoreProjectUI.Views {
    
    
    /// <summary>
    /// ContactInfo
    /// </summary>
    public partial class ContactInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\Views\ContactInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush contactInfoBackgroundImage;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Views\ContactInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button contactInfoExitButton;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Views\ContactInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock contactInfoHeaderTextblock;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\Views\ContactInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel contactInfoStackPanel;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\Views\ContactInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock contactInfoUsernameTextblock;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\Views\ContactInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox contactInfoUsernameTextbox;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\Views\ContactInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock contactInfoTextblock;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\..\Views\ContactInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox contactInfoEmailTextbox;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\..\..\Views\ContactInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock contactInfoPhoneTextblock;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\..\Views\ContactInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox contactInfoPhoneTextbox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFCoreProjectUI;component/views/contactinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\ContactInfo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.contactInfoBackgroundImage = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 2:
            this.contactInfoExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\Views\ContactInfo.xaml"
            this.contactInfoExitButton.Click += new System.Windows.RoutedEventHandler(this.contactInfoExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.contactInfoHeaderTextblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.contactInfoStackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.contactInfoUsernameTextblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.contactInfoUsernameTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.contactInfoTextblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.contactInfoEmailTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.contactInfoPhoneTextblock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.contactInfoPhoneTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

