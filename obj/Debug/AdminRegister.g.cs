﻿#pragma checksum "..\..\AdminRegister.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "699A4C132CAF5CF4DC8F122730D583CE19E6DAB57065CFCBD4500E915769E5D5"
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
using TicketTest;


namespace TicketTest {
    
    
    /// <summary>
    /// AdminRegister
    /// </summary>
    public partial class AdminRegister : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\AdminRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRegister;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AdminRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegister;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\AdminRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbUsername;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\AdminRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passBoxRegister;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\AdminRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock placeholderPassword;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\AdminRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passBoxConfirm;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\AdminRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock placeholderConfirmPassword;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\AdminRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgHome;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TicketTest;component/adminregister.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AdminRegister.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lblRegister = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.btnRegister = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\AdminRegister.xaml"
            this.btnRegister.Click += new System.Windows.RoutedEventHandler(this.btnRegister_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbUsername = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\AdminRegister.xaml"
            this.tbUsername.GotFocus += new System.Windows.RoutedEventHandler(this.tbUsername_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.passBoxRegister = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 60 "..\..\AdminRegister.xaml"
            this.passBoxRegister.GotFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 60 "..\..\AdminRegister.xaml"
            this.passBoxRegister.LostFocus += new System.Windows.RoutedEventHandler(this.PasswordBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.placeholderPassword = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.passBoxConfirm = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 73 "..\..\AdminRegister.xaml"
            this.passBoxConfirm.GotFocus += new System.Windows.RoutedEventHandler(this.PasswordBoxConfirm_GotFocus);
            
            #line default
            #line hidden
            
            #line 73 "..\..\AdminRegister.xaml"
            this.passBoxConfirm.LostFocus += new System.Windows.RoutedEventHandler(this.PasswordBoxConfirm_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.placeholderConfirmPassword = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            
            #line 86 "..\..\AdminRegister.xaml"
            ((System.Windows.Controls.Image)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgClose_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.imgHome = ((System.Windows.Controls.Image)(target));
            
            #line 87 "..\..\AdminRegister.xaml"
            this.imgHome.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.imgHome_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

