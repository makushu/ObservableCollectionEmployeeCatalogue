﻿#pragma checksum "..\..\..\ViewModel\AddEmployee.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "52C5681DA69EC8CC75BFF08FB642EBD8B6DCB4031487BE545649CD56996068C3"
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
using TheCatalogueEmployee.ViewModel;


namespace TheCatalogueEmployee.ViewModel {
    
    
    /// <summary>
    /// AddEmployee
    /// </summary>
    public partial class AddEmployee : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 69 "..\..\..\ViewModel\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdAdd;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\ViewModel\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAddName;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\ViewModel\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAddSurname;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\ViewModel\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpAddDateOfBirth;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\ViewModel\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboAddGender;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\ViewModel\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAddHomeAddress;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\ViewModel\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddEmployee;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\ViewModel\AddEmployee.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCloseAddGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/TheCatalogueEmployee;component/viewmodel/addemployee.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewModel\AddEmployee.xaml"
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
            this.grdAdd = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.txtAddName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtAddSurname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.dpAddDateOfBirth = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.cboAddGender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.txtAddHomeAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnAddEmployee = ((System.Windows.Controls.Button)(target));
            
            #line 102 "..\..\..\ViewModel\AddEmployee.xaml"
            this.btnAddEmployee.Click += new System.Windows.RoutedEventHandler(this.btnAddEmployee_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnCloseAddGrid = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
