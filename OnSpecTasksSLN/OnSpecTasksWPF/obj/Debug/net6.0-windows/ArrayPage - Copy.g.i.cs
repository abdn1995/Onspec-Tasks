﻿#pragma checksum "..\..\..\ArrayPage - Copy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "334B18E98FA4C79A11D39111DD5EA7D5AE84BD77"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OnSpecTasksWPF;
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


namespace OnSpecTasksWPF {
    
    
    /// <summary>
    /// ArrayPage
    /// </summary>
    public partial class ArrayPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\ArrayPage - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ArrayTextBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\ArrayPage - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TargetTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\ArrayPage - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GetIndicesButton;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\ArrayPage - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ResultText;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OnSpecTasksWPF;V1.0.0.0;component/arraypage%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ArrayPage - Copy.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ArrayTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\ArrayPage - Copy.xaml"
            this.ArrayTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\ArrayPage - Copy.xaml"
            this.ArrayTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\ArrayPage - Copy.xaml"
            this.ArrayTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_KeyDown_Array);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TargetTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\ArrayPage - Copy.xaml"
            this.TargetTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.TextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\ArrayPage - Copy.xaml"
            this.TargetTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.TextBox_LostFocus_1);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\ArrayPage - Copy.xaml"
            this.TargetTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.TextBox_KeyDown_Target);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GetIndicesButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\ArrayPage - Copy.xaml"
            this.GetIndicesButton.Click += new System.Windows.RoutedEventHandler(this.GetIndicesButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ResultText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

