﻿#pragma checksum "..\..\..\..\Views\AddNew.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43A4F26750408F3152964FBD9717C30D2FA7984F"
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


namespace WPFCoreProject.Views {
    
    
    /// <summary>
    /// AddNew
    /// </summary>
    public partial class AddNew : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Views\AddNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ImageBrush addNewBackgroundImage;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\AddNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addNewAddButton;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Views\AddNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock addNewTitleTextBlock;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\Views\AddNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addNewCategoryTextBox;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\Views\AddNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addNewNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\..\Views\AddNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addNewPriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 160 "..\..\..\..\Views\AddNew.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addNewExitButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFCoreProjectUI;V1.0.0.0;component/views/addnew.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AddNew.xaml"
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
            this.addNewBackgroundImage = ((System.Windows.Media.ImageBrush)(target));
            return;
            case 2:
            this.addNewAddButton = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\Views\AddNew.xaml"
            this.addNewAddButton.Click += new System.Windows.RoutedEventHandler(this.addNewAddButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.addNewTitleTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.addNewCategoryTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 110 "..\..\..\..\Views\AddNew.xaml"
            this.addNewCategoryTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.addNewCategoryTextBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.addNewNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 133 "..\..\..\..\Views\AddNew.xaml"
            this.addNewNameTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.addNewNameTextBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addNewPriceTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 155 "..\..\..\..\Views\AddNew.xaml"
            this.addNewPriceTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.addNewPriceTextBox_GotFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.addNewExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 173 "..\..\..\..\Views\AddNew.xaml"
            this.addNewExitButton.Click += new System.Windows.RoutedEventHandler(this.addNewExitButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

