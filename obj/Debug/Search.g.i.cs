﻿#pragma checksum "..\..\Search.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F10485CB45E1ED50CC2ECF95AB4B5A90A0954B3D326FE39557DB7177269124D3"
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
    /// Search
    /// </summary>
    public partial class Search : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnContinue;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbFrom;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTo;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCategory;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpDate;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Result;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBookTicket;
        
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
            System.Uri resourceLocater = new System.Uri("/TicketTest;component/search.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Search.xaml"
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
            this.btnContinue = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\Search.xaml"
            this.btnContinue.Click += new System.Windows.RoutedEventHandler(this.btnContinue_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbFrom = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\Search.xaml"
            this.tbFrom.GotFocus += new System.Windows.RoutedEventHandler(this.tbFrom_GotFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbTo = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\Search.xaml"
            this.tbTo.GotFocus += new System.Windows.RoutedEventHandler(this.tbTo_GotFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\Search.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cbCategory = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.dpDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.Result = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.btnBookTicket = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\Search.xaml"
            this.btnBookTicket.Click += new System.Windows.RoutedEventHandler(this.btnBookTicket_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

