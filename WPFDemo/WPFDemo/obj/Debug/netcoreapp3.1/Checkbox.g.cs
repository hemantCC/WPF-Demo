﻿#pragma checksum "..\..\..\Checkbox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E6A05D4FF866C3DDB93F30319ECA0B66F2332B37"
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
using WPFDemo;


namespace WPFDemo {
    
    
    /// <summary>
    /// Checkbox
    /// </summary>
    public partial class Checkbox : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 50 "..\..\..\Checkbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox AllCheck;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Checkbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Jalapeno;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Checkbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Olives;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Checkbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Cucumber;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Checkbox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Pickel;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFDemo;component/checkbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Checkbox.xaml"
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
            this.AllCheck = ((System.Windows.Controls.CheckBox)(target));
            
            #line 50 "..\..\..\Checkbox.xaml"
            this.AllCheck.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\Checkbox.xaml"
            this.AllCheck.Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Jalapeno = ((System.Windows.Controls.CheckBox)(target));
            
            #line 53 "..\..\..\Checkbox.xaml"
            this.Jalapeno.Checked += new System.Windows.RoutedEventHandler(this.Jalapeno_Checked);
            
            #line default
            #line hidden
            
            #line 53 "..\..\..\Checkbox.xaml"
            this.Jalapeno.Unchecked += new System.Windows.RoutedEventHandler(this.Jalapeno_Checked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Olives = ((System.Windows.Controls.CheckBox)(target));
            
            #line 54 "..\..\..\Checkbox.xaml"
            this.Olives.Checked += new System.Windows.RoutedEventHandler(this.Jalapeno_Checked);
            
            #line default
            #line hidden
            
            #line 54 "..\..\..\Checkbox.xaml"
            this.Olives.Unchecked += new System.Windows.RoutedEventHandler(this.Jalapeno_Checked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Cucumber = ((System.Windows.Controls.CheckBox)(target));
            
            #line 55 "..\..\..\Checkbox.xaml"
            this.Cucumber.Checked += new System.Windows.RoutedEventHandler(this.Jalapeno_Checked);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\Checkbox.xaml"
            this.Cucumber.Unchecked += new System.Windows.RoutedEventHandler(this.Jalapeno_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Pickel = ((System.Windows.Controls.CheckBox)(target));
            
            #line 56 "..\..\..\Checkbox.xaml"
            this.Pickel.Checked += new System.Windows.RoutedEventHandler(this.Jalapeno_Checked);
            
            #line default
            #line hidden
            
            #line 56 "..\..\..\Checkbox.xaml"
            this.Pickel.Unchecked += new System.Windows.RoutedEventHandler(this.Jalapeno_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 58 "..\..\..\Checkbox.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

