﻿#pragma checksum "..\..\..\..\Forms\AddNew.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7D1A6C2FD47DBF2E2DBCD8734D838F2D4CBD12F7"
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
using WPFCoreProject;


namespace WPFCoreProject {
    
    
    /// <summary>
    /// AddNew
    /// </summary>
    public partial class AddNew : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\..\Forms\AddNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addNewAddButton;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Forms\AddNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock addNewTitleTextBlock;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\Forms\AddNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addNewNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\Forms\AddNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addNewPriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\..\Forms\AddNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addNewExitButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFCoreProject;component/forms/addnew.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Forms\AddNew.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.addNewAddButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\Forms\AddNew.xaml"
            this.addNewAddButton.Click += new System.Windows.RoutedEventHandler(this.addNewAddButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.addNewTitleTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.addNewNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.addNewPriceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.addNewExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 148 "..\..\..\..\Forms\AddNew.xaml"
            this.addNewExitButton.Click += new System.Windows.RoutedEventHandler(this.addNewExitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

